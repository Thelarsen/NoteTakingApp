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
    public partial class Login : Form
    {
        Database db;
        public Login()
        {
            InitializeComponent();
            db = new Database(); // New database connection.
            // Automatically fill in user credentials on login window for quick testing.
            //usernameEntry.Text = "admin";
            //passwordEntry.Text = "admin";   
        }

        // Close program if cancel button is clicked.
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // Form.Close: closes window.
        }

        /* Validate login credentials when login button is clicked. Encrypt password entry before validating the user credentials.
         * Show error message if user credentials are wrong, open program if user credentials are correct. */
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameEntry.Text.Trim();
            string password = passwordEntry.Text.Trim();
            // Check if username or password is missing.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            password = Crypt.hashPassword(password); // Passed from Crypt and encrypts password entry.

            // Compare login credentials to user data stored in the database.
            User user = db.con.Table<User>().Where(u => u.username == username && u.password == password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hide(); // Control.Hide: hide login window.   
            MainWindow mainWindow = new MainWindow(user); // Passed from MainWindow on successful login.
            mainWindow.FormClosed += MainWindowClosed; // Creates event to call function to close window.
            mainWindow.Show(); // Open program for logged in user.
        }

        // Close program if window is closed.
        private void MainWindowClosed(object sender, FormClosedEventArgs e)
        {
            Close(); // Form.Close: closes window.
        }
    }
}
