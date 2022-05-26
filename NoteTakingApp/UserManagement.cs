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
    public partial class Users : Form
    {
        Database db;
        public Users()
        {
            InitializeComponent();
            db = new Database(); // New database connection.
        }

        // Loading/updating list of users.
        private void Users_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Create/update list of users.
        private void LoadUsers()
        {
            List<User> users = db.con.Table<User>().OrderBy(u => u.name).ToList();
            userList.Items.Clear();
            // Loop through each user and add data to the list.
            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem();
                item.Text = user.name;
                item.SubItems.Add(user.username);
                item.SubItems.Add(user.role);
                item.Tag = user;
                userList.Items.Add(item);
            }
        }

        // Opens new window to create new user on button click.
        private void newUserBtn_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm(null); // Passed from Userform.
            userform.FormClosed += Userform_FormClosed; // Creates event to call function to close window.
            userform.ShowDialog(this); // Shows new window for creating new user.
        }

        // Opens new window to edit user details on button click.
        private void editUserBtn_Click(object sender, EventArgs e)
        {
            // Check if a user is selected.
            if(userList.SelectedItems.Count > 0)
            {
                ListViewItem useritem = userList.SelectedItems[0];
                User user = useritem.Tag as User;
                UserForm userform = new UserForm(user); // Passed from Userform.
                userform.FormClosed += Userform_FormClosed; // Creates event to call function to close window.
                userform.ShowDialog(this); // Shows new window for editing user.
            }
            else
            {
                MessageBox.Show("Please select a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //ListViewItem item = userList.SelectedItems
        }

        // Loading/updating list of users.
        private void Userform_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadUsers();
        }

        // Ask user for confirmation to delete a user, then remove the user data.
        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            // Check if a user is selected.
            if (userList.SelectedItems.Count > 0)
            {
                //TODO: only remove login permission from user, do not delete data from database.
                ListViewItem useritem = userList.SelectedItems[0];
                User user = useritem.Tag as User;
                if (MessageBox.Show("Are you sure?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.con.Delete(user);
                    db.con.Execute("DELETE FROM auditlog WHERE user_id=?", user.id);
                    db.con.Execute("DELETE FROM cases WHERE user_id=?", user.id);
                    db.con.Execute("DELETE FROM exhibit WHERE user_id=?", user.id);
                    db.con.Execute("DELETE FROM notes WHERE user_id=?", user.id);
                    LoadUsers();
                }
                
            }
            else
            {
                MessageBox.Show("Please select a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
