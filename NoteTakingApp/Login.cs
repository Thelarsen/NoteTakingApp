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
            db = new Database();
            usernameEntry.Text = "admin";
            passwordEntry.Text = "admin";   
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameEntry.Text.Trim();
            string password = passwordEntry.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            password = Crypt.hashPassword(password);

            //User user = db.con.Query<User>("SELECT * FROM users WHERE username=? AND password=?", username, password).FirstOrDefault();
            User user = db.con.Table<User>().Where(u => u.username == username && u.password == password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hide();            
            MainWindow mainWindow = new MainWindow(user);
            mainWindow.FormClosed += MainWindowClosed;
            mainWindow.Show();
        }

        private void MainWindowClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
