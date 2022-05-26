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
    public partial class NewCaseForm : Form
    {
        Database db;
        User user;
        public NewCaseForm(User _user)
        {
            InitializeComponent();
            db = new Database(); // New database connection.
            user = _user; // Passed from MainWindow.
        }

        // Close program if cancel button is clicked.
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // Form.Close: closes window.
        }

        // Writes new case data to database and closes window.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Check if case name has been filled in.
            if (caseName.Text.Trim() == "")
            {
                MessageBox.Show("Case name required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Case Case = new Case();
            Case.name = caseName.Text;
            Case.description = caseDescription.Text;
            Case.user_id = user.id;
            Case.created = DateTime.Now;
            // Write to database and close window.
            db.con.Insert(Case);
            Close(); // Form.Close: closes window.
        }
    }
}
