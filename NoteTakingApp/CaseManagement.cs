using NoteTakingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class CaseManagement : Form
    {
        Database db;

        public CaseManagement()
        {
            InitializeComponent();
            db = new Database(); // New database connection.
            LoadCases();
        }

        // Loading/updating list of cases.
        private void Cases_Load(object sender, EventArgs e)
        {
            LoadCases();
        }

        // Create/update list of cases.
        private void LoadCases()
        {
            List<Case> caseList = db.con.Table<Case>().OrderByDescending(c => c.id).ToList();
            allCasesListBox.Items.Clear();

            // Loop through each case and add data to the list.
            foreach (Case caseitem in caseList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = caseitem.id.ToString();
                item.SubItems.Add(caseitem.name);

                User user = db.con.Table<User>().Where(u => u.id == caseitem.user_id).FirstOrDefault();

                item.SubItems.Add(user.username);
                item.SubItems.Add(caseitem.created.ToString("dd.MM.yyyy"));
                item.SubItems.Add(caseitem.is_closed ? "Yes" : "No");
                item.Tag = caseitem;
                allCasesListBox.Items.Add(item);
            }
        }

        // Function called when a case is clicked on/marked and will show more details about the case next to the list of cases.
        private void allCasesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Button to open case from list of cases.
        private void openCase_Click(object sender, EventArgs e)
        {
            // Check to see if a case is marked.
            if (allCasesListBox.SelectedItems.Count > 0)
            {
                ListViewItem caseitem = allCasesListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;

                // Check if case is open, ask for confirmation to open case before writing to database.
                if (!Case.is_closed)
                {
                    MessageBox.Show("This case is already open.", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure?", "Open Case", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Case.is_closed = false;
                        // Write changes to database.
                        db.con.InsertOrReplace(Case);
                    }
                }

                // Refresh UI.
                LoadCases();
            }

            else
            {
                MessageBox.Show("Please select a case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Button to close a case from list of cases.
        private void closeCase_Click(object sender, EventArgs e)
        {
            // Check to see if a case is marked.
            if (allCasesListBox.SelectedItems.Count > 0)
            {
                ListViewItem caseitem = allCasesListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;

                // Check if case is closed, ask for confirmation to close case before writing to database.
                if (Case.is_closed)
                {
                    MessageBox.Show("This case is already closed.", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure?", "Close Case", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Case.is_closed = true;
                        Case.closed = DateTime.Now;
                        // Write changes to database.
                        db.con.InsertOrReplace(Case);
                    }
                }

                // Refresh UI.
                LoadCases();
            }

            else
            {
                MessageBox.Show("Please select a case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Opens the selected case in read only mode when doubleclicked.
        private void loadCaseDblClick(object sender, EventArgs e)
        {

            if (allCasesListBox.SelectedItems.Count > 0)
            {
                ListViewItem caseitem = allCasesListBox.SelectedItems[0];
                Case Case = caseitem.Tag as Case;
                // Set case.is_closed to true to make the cases read only.
                Case.is_closed = true;
                CaseForm caseform = new CaseForm(Case); // Passed from CaseForm.
                caseform.ShowDialog(this); // Opens new window for caseform for the given case.
            }
            else
            {
                MessageBox.Show("Please select a case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
