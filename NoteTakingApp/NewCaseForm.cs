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
            db = new Database();
            user = _user;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
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
            db.con.Insert(Case);
            Close();
        }
    }
}
