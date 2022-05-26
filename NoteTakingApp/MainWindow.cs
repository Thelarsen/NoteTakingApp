using NoteTakingApp.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing.Layout;

namespace NoteTakingApp
{
    public partial class MainWindow : Form
    {
        Database db;
        User user;

        public MainWindow(User _user)
        {
            InitializeComponent();
            db = new Database(); // New database connection.
            user = _user; // Parameter passed on login, logged in user is user in the program.
            // Check if user role is admin, if not hide admin permissions from user.
            if (user.role != "admin")
            {
                adminMenu.Visible = false;
            }
            ClearFields();
        }

        // Loading a list of all cases from the logged in user and grabs the data from the database.
        private void LoadCases()
        {
            // Grabs data from "Case" table in database where the user id linked to a case is the same as the user id logged in.
            List<Case> caseList = db.con.Table<Case>().Where(c => c.user_id == user.id).OrderByDescending(c => c.id).ToList();
            // Empty case list.
            caseListBox.Items.Clear();
            // Loop through each case and add given data to the list.
            foreach (Case caseitem in caseList) 
            {
                ListViewItem item = new ListViewItem();
                item.Text = caseitem.id.ToString();
                item.SubItems.Add(caseitem.name);
                item.SubItems.Add(caseitem.created.ToString("dd.MM.yyyy"));
                item.SubItems.Add(caseitem.is_closed ? "Yes" : "No");
                item.Tag = caseitem;
                // Add data to the list
                caseListBox.Items.Add(item);
            }
        }

        // Empty all fields showing loaded data.
        private void ClearFields()
        {
            caseId.Text = "";
            caseName.Text = "";
            caseOpened.Text = "";
            caseClosed.Text = "";
            examiner.Text = "";
            description.Text = "";
        }

        // Load/update list of cases.
        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadCases();
        }

        // Close window on click.
        private void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        // Open new window for creating new case on button click.
        private void newCaseBtn_Click(object sender, EventArgs e)
        {
            NewCaseForm newcase = new NewCaseForm(user); // Passed from NewCaseForm.
            newcase.FormClosed += newcasewindow_closed; // Creates event to call function to close window.
            newcase.ShowDialog(this); // Shows new window.
        }

        // Load/update case list when newcasewindow_closed is called.
        private void newcasewindow_closed(object sender, FormClosedEventArgs e)
        {
            LoadCases();
        }

        // Function called when a case is selected and will show more details about the case next to the list of cases.
        private void caseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check to see if a case is marked.
            if (caseListBox.SelectedItems.Count > 0) 
            {
                ListViewItem caseitem = caseListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;
                User user = db.con.Table<User>().Where(u => u.id == Case.user_id).FirstOrDefault();

                // Load data from database to fill in the details.
                caseId.Text = Case.id.ToString();
                caseName.Text = Case.name;
                caseOpened.Text = Case.created.ToString("dd.MM.yyyy HH:mm");
                
                // Check if case is closed, if it is show the date it was closed, if not leave empty.
                if (Case.is_closed)
                {
                    caseClosed.Text = Case.closed.ToString("dd.MM.yyyy HH:mm");
                }
                else
                {
                    caseClosed.Text = "";
                }
                
                // Check if user is found in database, if it is fill in the user, if not show as "Error".
                if (user != null)
                {
                    examiner.Text = user.name;
                }
                else
                {
                    examiner.Text = "Error";
                }
                description.Text = Case.description;

            }
            // If no case is marked the details remain empty.
            else
            {
                ClearFields();
            }
        }

        // Opens the window for user admin when clicked in the menu.
        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users(); // Passed from Users.
            users.ShowDialog(this); // Opens window for user admin.
        }

        // Opens the window for case management when clicked in the menu.
        private void caseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaseManagement caseManagement = new CaseManagement(); // Passed from CaseManagement.
            caseManagement.ShowDialog(this); // Opens window for case management.
            LoadCases();
        }


        // Opens CaseForm for a chosen case on double click.
        private void caseListBox_dblclick(object sender, EventArgs e)
        {
            // Check to see if a case has been selected in the list.
            if (caseListBox.SelectedItems.Count > 0)
            {
                ListViewItem caseitem = caseListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;
                CaseForm caseform = new CaseForm(Case); // Passed from CaseForm.
                caseform.FormClosed += Caseform_FormClosed; // Creates event to call function to close window.
                caseform.ShowDialog(this); // Opens new window for caseform for the given case.
            }
            else
            {
                MessageBox.Show("Please select a case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Load/update case list when Caseform_FormClosed is called.
        private void Caseform_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCases();
        }

        /* Creates a PDF of the case when called. Creates front page, title, lists all notes, lists all audits from each note,
         creates header and footer on all pages except front page, saves the PDF file and opens the file. */
        private void createPDFMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem caseitem;
            Case Case;
            List<Note> notes;
            List<Auditlog> auditlogs;
            User user;

            if (caseListBox.SelectedItems.Count > 0)
            {
                caseitem = caseListBox.SelectedItems[0];
                Case = caseitem.Tag as Case;
                notes = db.con.Table<Note>().Where(n => n.case_id == Case.id).OrderBy(n => n.created).ToList();
                auditlogs = db.con.Table<Auditlog>().Where(a => a.case_id == Case.id).OrderBy(n => n.created).ToList();
                user = db.con.Table<User>().Where(u => u.id == Case.user_id).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("User connected to this case not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create pdf document and margins on the page.
            PdfDocument doc = new PdfDocument();
            LayoutHelper helper = new LayoutHelper(doc, XUnit.FromCentimeter(2.5), XUnit.FromCentimeter(29.7 - 2.5));
            double left = XUnit.FromCentimeter(1.25);
            double width = XUnit.FromCentimeter(21 - 2.5);

            // Fonts for document.
            XFont headerFontB = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XFont headerFontI = new XFont("Times New Roman", 20, XFontStyle.Italic);
            XFont headerFontR = new XFont("Times New Roman", 20, XFontStyle.Regular);
            XFont titleFont = new XFont("Times New Roman", 16, XFontStyle.Bold);
            XFont normalFont = new XFont("Times New Roman", 12);
            XFont normalFontB = new XFont("Times New Roman", 12, XFontStyle.Bold);
            XFont headerextraFont = new XFont("Times New Roman", 40, XFontStyle.Bold);
            XFont topheaderFont = new XFont("Times New Roman", 10, XFontStyle.Italic);


            // Front page.
            helper.CreatePage();
            XRect FPrect = new XRect(0, 0, helper.Page.Width, helper.Page.Height);

            FPrect.Y = helper.GetLinePosition(200);

            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"Case Number:", headerFontB, XBrushes.Black, FPrect, XStringFormats.TopCenter);
            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"{Case.id} ", headerFontR, XBrushes.Black, FPrect, XStringFormats.TopCenter);

            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"Case Name:", headerFontB, XBrushes.Black, FPrect, XStringFormats.TopCenter);
            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"{Case.name}", headerFontR, XBrushes.Black, FPrect, XStringFormats.TopCenter);

            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"Analyst:", headerFontB, XBrushes.Black, FPrect, XStringFormats.TopCenter);
            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"{user.name}", headerFontR, XBrushes.Black, FPrect, XStringFormats.TopCenter);

            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"Case Created:", headerFontB, XBrushes.Black, FPrect, XStringFormats.TopCenter);
            FPrect.Y = helper.GetLinePosition(headerextraFont.Height);
            helper.g.DrawString($"{Case.created}", headerFontR, XBrushes.Black, FPrect, XStringFormats.TopCenter);

            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"Printed Date:", headerFontB, XBrushes.Black, FPrect, XStringFormats.TopCenter);
            FPrect.Y = helper.GetLinePosition(headerFontB.Height);
            helper.g.DrawString($"{DateTime.Now}", headerFontR, XBrushes.Black, FPrect, XStringFormats.TopCenter);

            helper.CreatePage();
            helper.setStartYPosition(0);

            // Title Notes.
            XRect trect = new XRect(0, 0, helper.Page.Width, helper.Page.Height);
            trect.Y = helper.GetLinePosition(headerFontB.Height * 2);
            helper.g.DrawString($"Notes for: {Case.name}", titleFont, XBrushes.Black, trect, XStringFormats.TopCenter);

            // Loop through case notes.
            double dateWidthN = width / 4.2;
            double noteWidthN = width - dateWidthN;
            foreach (Note note in notes)
            {
                string editedFlag = note.is_edited ? "*" : ""; // Edited notes will be tagged with "*".
                // Date created and content of note is written to page.
                helper.writeString($"{note.created}{editedFlag}", normalFont, left, dateWidthN, true);
                helper.writeString($"{note.content}", normalFont, left + dateWidthN, noteWidthN - left);

                // Create line between each note.
                double y = helper.CurrentPosition - 7;
                if (y > XUnit.FromCentimeter(3))
                {
                    double x1, x2;
                    x1 = left;
                    x2 = helper.Page.Width - left;
                    XPen lineBlack = new XPen(XColors.Black, 0.5);
                    helper.g.DrawLine(lineBlack, x1, y, x2, y);
                }
                helper.GetLinePosition(normalFont.Height);
            }


            helper.setStartYPosition(0);
            // Title for Auditlog.
            XRect arect = new XRect(0, 0, helper.Page.Width, helper.Page.Height);
            arect.Y = helper.GetLinePosition(headerFontB.Height * 2);
            helper.g.DrawString($"Auditlog for: {Case.name}", titleFont, XBrushes.Black, arect, XStringFormats.TopCenter);

            // Loop through auditlog.
            double dateWidthA = width / 4.2;
            double noteWidthA = width - dateWidthA;
            foreach (Auditlog al in auditlogs)
            {
                // Date created and edited content of note is written to page, followed by original note and date created.
                helper.writeString($"{al.created}", normalFont, left, dateWidthA, true);
                var textWidth = helper.writeString("Original: ", normalFontB, left + dateWidthA, noteWidthA, true);
                helper.writeString(al.original_content, normalFont, left + textWidth + dateWidthA, noteWidthA - textWidth - left);
                helper.GetLinePosition(normalFont.Height / 2);
                helper.writeString($"{al.created}", normalFont, left, dateWidthA, true);
                helper.writeString("Audit: ", normalFontB, left + dateWidthA, noteWidthA, true);
                helper.writeString(al.edited_content, normalFont, left + textWidth + dateWidthA, noteWidthA - textWidth - left);

                // Create line between each audit.
                double y = helper.CurrentPosition - 7;
                if (y > XUnit.FromCentimeter(3))
                {
                    double x1, x2;
                    x1 = left;
                    x2 = helper.Page.Width - left;
                    XPen lineBlack = new XPen(XColors.Black, 0.5);
                    helper.g.DrawLine(lineBlack, x1, y, x2, y);
                }
                helper.GetLinePosition(normalFont.Height);
            }


            // Loop through pages and add header and footer to each page except front page.
            int pageNo = 0;
            int numPages = doc.Pages.Count;
            XRect hrect = new XRect((double)XUnit.FromCentimeter(1.25), (double)XUnit.FromCentimeter(1.25), helper.Page.Width - (double)XUnit.FromCentimeter(2.5), helper.Page.Height - (double)XUnit.FromCentimeter(2.5));
            foreach (PageInfo pi in helper.PageInfos)
            {
                pageNo++;
                if (pageNo == 1) continue; // Skip front page.

                // Header for pages.
                pi.g.DrawString($"Case Number: {Case.id}, Case Name: {Case.name}, Analyst: {user.name}", topheaderFont, XBrushes.Black, hrect, XStringFormats.TopLeft);
                pi.g.DrawString($"Printed: {DateTime.Now}", topheaderFont, XBrushes.Black, hrect, XStringFormats.TopRight);
                // Footer for pages.
                pi.g.DrawString($"{pageNo} / {numPages}", normalFont, XBrushes.Black, hrect, XStringFormats.BottomCenter);
            }


            doc.Save("pdf.pdf"); // Save the pfd document.
            Process.Start("pdf.pdf"); // Open the pdf document.
        }
    }
}
