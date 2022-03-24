using NoteTakingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Userform : Form
    {
        User user;
        Database db;
        bool isEditing = false;
        Timer timer;

        public Userform(User _user)
        {
            InitializeComponent();
            db = new Database();
            if (_user != null)
            {
                isEditing = true;
                Text = "Edit user";
                user = _user;
                name.Text = user.name;
                username.Text = user.username;
                password.Text = "";
                password.Enabled = false;
                ckSetPassword.Enabled = true;
                ckSetPassword.Checked = false;
                roleDropDown.Text = user.role;
            }
            else
            {
                Text = "New user";
                user = new User();
                roleDropDown.Text = "user";
                password.Enabled = true;
                ckSetPassword.Enabled = false;
                ckSetPassword.Checked = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //TODO:Validate fields
            user.name = name.Text;
            user.username = username.Text;
            if (ckSetPassword.Checked)
            {
                user.password = Crypt.hashPassword(password.Text);
            }
            user.role = roleDropDown.Text;
            if (isEditing)
            {
                db.con.InsertOrReplace(user);
            }
            else
            {
                db.con.Insert(user);
            }

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password.PasswordChar = password.PasswordChar == '*' ? char.MinValue : '*';
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            Timer t = (Timer)sender;
            t.Stop();
            t.Enabled = false;
        }

        private void ckSetPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.Enabled = ckSetPassword.Checked;
            if (!ckSetPassword.Checked) password.Text = "";
        }
    }
}
