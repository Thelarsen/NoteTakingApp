namespace NoteTakingApp
{
    partial class CaseManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openCaseBtn = new System.Windows.Forms.Button();
            this.closeCaseBtn = new System.Windows.Forms.Button();
            this.allCasesListBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Cases";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 407);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.allCasesListBox);
            this.panel4.Location = new System.Drawing.Point(12, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 383);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.openCaseBtn);
            this.panel3.Controls.Add(this.closeCaseBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(669, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 383);
            this.panel3.TabIndex = 0;
            // 
            // openCaseBtn
            // 
            this.openCaseBtn.Location = new System.Drawing.Point(19, 22);
            this.openCaseBtn.Name = "openCaseBtn";
            this.openCaseBtn.Size = new System.Drawing.Size(75, 23);
            this.openCaseBtn.TabIndex = 1;
            this.openCaseBtn.Text = "Open Case";
            this.openCaseBtn.UseVisualStyleBackColor = true;
            this.openCaseBtn.Click += new System.EventHandler(this.openCase_Click);
            // 
            // closeCaseBtn
            // 
            this.closeCaseBtn.Location = new System.Drawing.Point(19, 66);
            this.closeCaseBtn.Name = "closeCaseBtn";
            this.closeCaseBtn.Size = new System.Drawing.Size(75, 23);
            this.closeCaseBtn.TabIndex = 0;
            this.closeCaseBtn.Text = "Close Case";
            this.closeCaseBtn.UseVisualStyleBackColor = true;
            this.closeCaseBtn.Click += new System.EventHandler(this.closeCase_Click);
            // 
            // allCasesListBox
            // 
            this.allCasesListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.allCasesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.allCasesListBox.FullRowSelect = true;
            this.allCasesListBox.HideSelection = false;
            this.allCasesListBox.Location = new System.Drawing.Point(0, 0);
            this.allCasesListBox.Name = "allCasesListBox";
            this.allCasesListBox.Size = new System.Drawing.Size(669, 383);
            this.allCasesListBox.TabIndex = 0;
            this.allCasesListBox.UseCompatibleStateImageBehavior = false;
            this.allCasesListBox.View = System.Windows.Forms.View.Details;
            this.allCasesListBox.SelectedIndexChanged += new System.EventHandler(this.allCasesListBox_SelectedIndexChanged);
            this.allCasesListBox.DoubleClick += new System.EventHandler(this.loadCaseDblClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Case ID";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Case Name";
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Examiner";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opened";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Closed";
            this.columnHeader5.Width = 68;
            // 
            // CaseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CaseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Case Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView allCasesListBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeCaseBtn;
        private System.Windows.Forms.Button openCaseBtn;
    }
}