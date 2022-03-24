using NoteTakingApp.Classes;
using Rocket.PdfGenerator;
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

namespace NoteTakingApp
{
    public partial class MainWindow : Form
    {
        Database db;
        User user;

        public MainWindow(User _user)
        {
            InitializeComponent();
            db = new Database();
            user = _user;
            if (user.role != "admin")
            {
                adminMenu.Visible = false;
            }
            ClearFields();
        }

        private void LoadCases()
        {
            List<Case> caseList = db.con.Table<Case>().Where(c => c.user_id == user.id).OrderByDescending(c => c.id).ToList();
            caseListBox.Items.Clear();
            foreach (Case caseitem in caseList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = caseitem.id.ToString();
                item.SubItems.Add(caseitem.name);
                item.SubItems.Add(caseitem.created.ToString("dd.MM.yyyy"));
                item.SubItems.Add(caseitem.is_closed ? "Yes" : "No");
                item.Tag = caseitem;
                caseListBox.Items.Add(item);
            }
        }

        private void ClearFields()
        {
            caseId.Text = "";
            caseName.Text = "";
            caseOpened.Text = "";
            caseClosed.Text = "";
            examiner.Text = "";
            description.Text = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadCases();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCaseForm newcase = new NewCaseForm(user);
            newcase.FormClosed += newcasewindow_closed;
            newcase.ShowDialog(this);
        }

        private void newcasewindow_closed(object sender, FormClosedEventArgs e)
        {
            LoadCases();
        }

        private void caseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caseListBox.SelectedItems.Count > 0)
            {
                ListViewItem caseitem = caseListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;
                User user = db.con.Table<User>().Where(u => u.id == Case.user_id).FirstOrDefault();

                caseId.Text = Case.id.ToString();
                caseName.Text = Case.name;
                caseOpened.Text = Case.created.ToString("dd.MM.yyyy HH:mm");
                if (Case.is_closed)
                {
                    caseClosed.Text = Case.closed.ToString("dd.MM.yyyy HH:mm");
                }
                else
                {
                    caseClosed.Text = "";
                }
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
            else
            {
                ClearFields();
            }
        }

        private void userAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog(this);
        }

        private void caseListBox_dblclick(object sender, EventArgs e)
        {
            if (caseListBox.SelectedItems.Count > 0)
            {
                ListViewItem caseitem = caseListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;
                CaseForm caseform = new CaseForm(Case);
                caseform.FormClosed += Caseform_FormClosed;
                caseform.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select a case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Caseform_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCases();
        }

        private void createPDFMenuItem_Click(object sender, EventArgs e)
        {
            if (caseListBox.SelectedItems.Count > 0)
            {
                ListViewItem caseitem = caseListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;
                List<Note> notes = db.con.Table<Note>().Where(n => n.case_id == Case.id).OrderBy(n => n.created).ToList();
                List<Auditlog> auditlogs = db.con.Table<Auditlog>().Where(a => a.case_id == Case.id).OrderBy(n => n.created).ToList();

                //string js = "var pdfInfo = { };";
                //js += "var x = document.location.search.substring(1).split('&');";
                //js += "for (var i in x) { var z = x[i].split('=', 2); pdfInfo[z[0]] = unescape(z[1]); }";
                //js += "function getPdfInfo()";
                //js += "{";
                //js += "    var page = pdfInfo.page || 1;";
                //js += "    var pageCount = pdfInfo.topage || 1;";
                //js += "    document.getElementById('pcurrent').textContent = page;";
                //js += "    document.getElementById('pcount').textContent = pageCount;";
                //js += "}";

                string html = "<html><head>";
                html += "</head>";
                html += "<body>";

                // Front Page.
                html += "<div style=\"font-size:200%;font-weight:bold;text-align:center;\">Case Number: " + Case.id.ToString() + "<br>Case Name: " + 
                    Case.name.ToString() + "<br>Created: " + Case.created.ToString("dd.MM.yyyy HH:mm:ss") + "<br>Printed: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + 
                    "<br>Analyst: " + Case.user_id.ToString() +"</div>";

                // Notes.
                html += "<div class=\"newpage\"/>";
                html += "<div style=\"font-size:60%;padding-bottom:10px;text-align:right;\">Author: Therese</div>";
                html += "<table width=\"100%\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\">";
                foreach (Note note in notes)
                {
                    html += "<tr>";
                    html += "<td style=\"border-Top: 1px solid black;\" valign=\"top\">" + note.created.ToString("dd.MM.yyyy") + "<br/>" + note.created.ToString("HH:mm:ss") + "</td>";
                    html += "<td style=\"width:100%; border-Top: 1px solid black; border-left: 1px solid black;\" valign=\"top\">" + note.content.Replace("\r\n", "<br />") + "</td>";
                    html += "</tr>";
                }
                html += "</table>";



                html += "<div class=\"newpage\">newpage [page]</div>";
                           
                
                               
                
                
                html += "</body></html>";





                // Audit log.
                html += "<div class=\"newpage\"/>";
                html += "<div style=\"font-size:60%;padding-bottom:10px;text-align:right;\">Author: Therese</div>";
                html += "<table width=\"100%\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\">";
                foreach (Auditlog auditlog in auditlogs)
                {
                    html += "<tr>";
                    html += "<td style=\"border-Top: 1px solid black;\" valign=\"top\">" + auditlog.created.ToString("dd.MM.yyyy") + "<br/>" + auditlog.created.ToString("HH:mm:ss") + "</td>";
                    html += "<td style=\"width:100%; border-Top: 1px solid black; border-left: 1px solid black;\" valign=\"top\">" + auditlog.edited_content.Replace("\r\n", "<br />") + "</td>";
                    html += "</tr>";
                }
                html += "</table>";



                string css = "<style>.newpage{page-break-before: always}</style>";

                html = css + html;


                // Allow the document to read Norwegian letters.
                //Dictionary<string, string> chars = new Dictionary<string, string>();
                //chars["ø"] = "&oslash;";
                //chars["Ø"] = "&Oslash;";
                //chars["å"] = "&aring;";
                //chars["Å"] = "&Aring;";
                //chars["æ"] = "&aelig;";
                //chars["Æ"] = "&Aelig;";

                //foreach (KeyValuePair<string, string> pair in chars)
                //{
                //    html = html.Replace(pair.Key, pair.Value);
                //}

                

                HtmlToPdfConverter converter = new HtmlToPdfConverter();
                converter.PageFooterHtml = "<div style=\"text-align:center\">Page [page]</div>";
                converter.UseStandaloneWkHtmlToPdfTool = true;
                byte[] pdf = converter.GeneratePdf(html);
                File.WriteAllBytes("Note.pdf", pdf);
                Process.Start("Note.pdf");
            }
            else
            {
                MessageBox.Show("Please select a case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
