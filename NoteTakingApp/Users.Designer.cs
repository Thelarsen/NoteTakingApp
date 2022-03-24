namespace NoteTakingApp
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 381);
            this.panel1.TabIndex = 0;
            // 
            // userList
            // 
            this.userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.userList.ContextMenuStrip = this.contextMenuStrip1;
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.FullRowSelect = true;
            this.userList.HideSelection = false;
            this.userList.Location = new System.Drawing.Point(0, 0);
            this.userList.MultiSelect = false;
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(610, 381);
            this.userList.TabIndex = 0;
            this.userList.UseCompatibleStateImageBehavior = false;
            this.userList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 202;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Role";
            this.columnHeader3.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editUserBtn);
            this.panel2.Controls.Add(this.deleteUserBtn);
            this.panel2.Controls.Add(this.newUserBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(496, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 381);
            this.panel2.TabIndex = 1;
            // 
            // editUserBtn
            // 
            this.editUserBtn.Location = new System.Drawing.Point(23, 41);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(75, 23);
            this.editUserBtn.TabIndex = 2;
            this.editUserBtn.Text = "&Edit";
            this.editUserBtn.UseVisualStyleBackColor = true;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Location = new System.Drawing.Point(23, 70);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteUserBtn.TabIndex = 1;
            this.deleteUserBtn.Text = "Delete";
            this.deleteUserBtn.UseVisualStyleBackColor = true;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(23, 12);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(75, 23);
            this.newUserBtn.TabIndex = 0;
            this.newUserBtn.Text = "&New";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 76);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createUserToolStripMenuItem.Text = "Create user";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editUserToolStripMenuItem.Text = "Edit user";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView userList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}