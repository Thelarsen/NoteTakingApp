namespace NoteTakingApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.caseId = new System.Windows.Forms.Label();
            this.caseClosed = new System.Windows.Forms.Label();
            this.caseName = new System.Windows.Forms.Label();
            this.examiner = new System.Windows.Forms.Label();
            this.caseOpened = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.caseListBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caseListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.createPDFMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newCaseBtn = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.caseListContextMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(804, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.accountToolStripMenuItem.Text = "&Account";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(119, 22);
            this.exitMenu.Text = "E&xit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // adminMenu
            // 
            this.adminMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAdminToolStripMenuItem,
            this.caseManagementToolStripMenuItem});
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(55, 20);
            this.adminMenu.Text = "&Admin";
            // 
            // userAdminToolStripMenuItem
            // 
            this.userAdminToolStripMenuItem.Name = "userAdminToolStripMenuItem";
            this.userAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userAdminToolStripMenuItem.Text = "&User Management";
            this.userAdminToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // caseManagementToolStripMenuItem
            // 
            this.caseManagementToolStripMenuItem.Name = "caseManagementToolStripMenuItem";
            this.caseManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caseManagementToolStripMenuItem.Text = "&Case Management";
            this.caseManagementToolStripMenuItem.Click += new System.EventHandler(this.caseManagementToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 459);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(804, 459);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(367, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(427, 439);
            this.panel5.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.description);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(93, 27);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(334, 412);
            this.panel8.TabIndex = 14;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.Enabled = false;
            this.description.Location = new System.Drawing.Point(0, 135);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.description.Size = new System.Drawing.Size(334, 277);
            this.description.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.caseId);
            this.panel9.Controls.Add(this.caseClosed);
            this.panel9.Controls.Add(this.caseName);
            this.panel9.Controls.Add(this.examiner);
            this.panel9.Controls.Add(this.caseOpened);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(334, 135);
            this.panel9.TabIndex = 13;
            // 
            // caseId
            // 
            this.caseId.AutoSize = true;
            this.caseId.Location = new System.Drawing.Point(6, 6);
            this.caseId.Name = "caseId";
            this.caseId.Size = new System.Drawing.Size(39, 13);
            this.caseId.TabIndex = 7;
            this.caseId.Text = "caseId";
            // 
            // caseClosed
            // 
            this.caseClosed.AutoSize = true;
            this.caseClosed.Location = new System.Drawing.Point(6, 84);
            this.caseClosed.Name = "caseClosed";
            this.caseClosed.Size = new System.Drawing.Size(64, 13);
            this.caseClosed.TabIndex = 10;
            this.caseClosed.Text = "case closed";
            // 
            // caseName
            // 
            this.caseName.AutoSize = true;
            this.caseName.Location = new System.Drawing.Point(6, 32);
            this.caseName.Name = "caseName";
            this.caseName.Size = new System.Drawing.Size(56, 13);
            this.caseName.TabIndex = 8;
            this.caseName.Text = "casename";
            // 
            // examiner
            // 
            this.examiner.AutoSize = true;
            this.examiner.Location = new System.Drawing.Point(6, 110);
            this.examiner.Name = "examiner";
            this.examiner.Size = new System.Drawing.Size(49, 13);
            this.examiner.TabIndex = 11;
            this.examiner.Text = "examiner";
            // 
            // caseOpened
            // 
            this.caseOpened.AutoSize = true;
            this.caseOpened.Location = new System.Drawing.Point(6, 55);
            this.caseOpened.Name = "caseOpened";
            this.caseOpened.Size = new System.Drawing.Size(69, 13);
            this.caseOpened.TabIndex = 9;
            this.caseOpened.Text = "case opened";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(93, 412);
            this.panel7.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Case ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Case name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Case opened: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Case closed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Examiner:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(427, 27);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(357, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 439);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.caseListBox);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 439);
            this.panel3.TabIndex = 3;
            // 
            // caseListBox
            // 
            this.caseListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.caseListBox.ContextMenuStrip = this.caseListContextMenu;
            this.caseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseListBox.FullRowSelect = true;
            this.caseListBox.HideSelection = false;
            this.caseListBox.Location = new System.Drawing.Point(0, 27);
            this.caseListBox.MultiSelect = false;
            this.caseListBox.Name = "caseListBox";
            this.caseListBox.Size = new System.Drawing.Size(347, 412);
            this.caseListBox.TabIndex = 0;
            this.caseListBox.UseCompatibleStateImageBehavior = false;
            this.caseListBox.View = System.Windows.Forms.View.Details;
            this.caseListBox.SelectedIndexChanged += new System.EventHandler(this.caseListBox_SelectedIndexChanged);
            this.caseListBox.DoubleClick += new System.EventHandler(this.caseListBox_dblclick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Case ID";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Case Name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opened";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Closed";
            // 
            // caseListContextMenu
            // 
            this.caseListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCaseToolStripMenuItem,
            this.toolStripMenuItem2,
            this.createPDFMenuItem});
            this.caseListContextMenu.Name = "caseListContextMenu";
            this.caseListContextMenu.Size = new System.Drawing.Size(133, 54);
            // 
            // openCaseToolStripMenuItem
            // 
            this.openCaseToolStripMenuItem.Name = "openCaseToolStripMenuItem";
            this.openCaseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openCaseToolStripMenuItem.Text = "Open case";
            this.openCaseToolStripMenuItem.Click += new System.EventHandler(this.caseListBox_dblclick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // createPDFMenuItem
            // 
            this.createPDFMenuItem.Name = "createPDFMenuItem";
            this.createPDFMenuItem.Size = new System.Drawing.Size(132, 22);
            this.createPDFMenuItem.Text = "Create PDF";
            this.createPDFMenuItem.Click += new System.EventHandler(this.createPDFMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.newCaseBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 27);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cases";
            // 
            // newCaseBtn
            // 
            this.newCaseBtn.Location = new System.Drawing.Point(68, -3);
            this.newCaseBtn.Name = "newCaseBtn";
            this.newCaseBtn.Size = new System.Drawing.Size(75, 23);
            this.newCaseBtn.TabIndex = 2;
            this.newCaseBtn.Text = "New case";
            this.newCaseBtn.UseVisualStyleBackColor = true;
            this.newCaseBtn.Click += new System.EventHandler(this.newCaseBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contemporaneous Notes";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.caseListContextMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminMenu;
        private System.Windows.Forms.ToolStripMenuItem userAdminToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem caseManagementToolStripMenuItem;
        private System.Windows.Forms.Button newCaseBtn;
        private System.Windows.Forms.ListView caseListBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label caseId;
        private System.Windows.Forms.Label caseClosed;
        private System.Windows.Forms.Label caseName;
        private System.Windows.Forms.Label examiner;
        private System.Windows.Forms.Label caseOpened;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip caseListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createPDFMenuItem;
    }
}