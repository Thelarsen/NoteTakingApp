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
    public partial class UserForm : Form
    {
        User user;
        Database db;
        bool isEditing = false; // By default isEditing is set to false.
        Timer timer;

        public UserForm(User _user) // User is sent in as a parameter.
        {
            InitializeComponent();
            db = new Database(); // New database connection.
            // Check if a user is selected and overwrite data.
            if (_user != null)
            {
                // If a user is selected isEditing is set to true.
                isEditing = true;
                Text = "Edit user";
                user = _user;
                name.Text = user.name;
                username.Text = user.username;
                password.Text = "";
                // Password is disabled until check button is clicked to change password, as password can be left unchanged for edited users.
                password.Enabled = false;
                // Enable check button for password field.
                ckSetPassword.Enabled = true;
                ckSetPassword.Checked = false;
                // Show current role of user.
                roleDropDown.Text = user.role;
            }
            // If no users are selected a new user is being created.
            else
            {
                Text = "New user";
                user = new User();
                // The default role of new user is set to "users".
                roleDropDown.Text = "user";
                // Password is enabled as it is required for new user.
                password.Enabled = true;
                // Disable check button to leave password of user unchanged.
                ckSetPassword.Enabled = false;
                ckSetPassword.Checked = true;
            }
        }

        // Close program if cancel button is clicked.
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // Form.Close: closes window.
        }

        // Encrypt password and save new/updated user to database.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //TODO:Validate fields
            user.name = name.Text;
            user.username = username.Text;
            // If check password button is checked encrypt password.
            if (ckSetPassword.Checked)
            {
                user.password = Crypt.hashPassword(password.Text); // Passed from Crypt and encrypts password entry.
            }
            user.role = roleDropDown.Text;
            // If isEditing user data is updated in the database.
            if (isEditing)
            {
                db.con.InsertOrReplace(user);
            }
            // If not isEditing user data is saved to database.
            else
            {
                db.con.Insert(user);
            }

            Close();
        }

        // By default password is shown with "*" symbol, on show button click the password will be visible in plain text for a given time.
        private void showPwdBtn_Click(object sender, EventArgs e)
        {
            // Sets the visible characters in the password field as "*" symbols.
            password.PasswordChar = password.PasswordChar == '*' ? char.MinValue : '*';
            timer = new Timer();
            // The time for how long a password is visible, e.g. timer.Interval = 5000; will show password for 5 seconds.
            timer.Interval = 5000;
            // Event called when the timer runs out.
            timer.Tick += Timer_Tick; 
            timer.Enabled = true;
        }

        // Once called the password will go back to showing "*" symbols.
        private void Timer_Tick(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            Timer t = (Timer)sender;
            t.Stop();
            t.Enabled = false;
        }

        // Check button check for password, when checked the password field will be open, otherwise it will be disabled.
        private void ckSetPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.Enabled = ckSetPassword.Checked;
            if (!ckSetPassword.Checked) password.Text = "";
        }
    }
}
