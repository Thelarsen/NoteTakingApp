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
            db = new Database();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            List<User> users = db.con.Table<User>().OrderBy(u => u.name).ToList();
            userList.Items.Clear();
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

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            Userform userform = new Userform(null);
            userform.FormClosed += Userform_FormClosed;
            userform.ShowDialog(this);
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if(userList.SelectedItems.Count > 0)
            {
                ListViewItem useritem = userList.SelectedItems[0];
                User user = useritem.Tag as User;
                Userform userform = new Userform(user);
                userform.FormClosed += Userform_FormClosed;
                userform.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //ListViewItem item = userList.SelectedItems
        }

        private void Userform_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadUsers();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (userList.SelectedItems.Count > 0)
            {
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
