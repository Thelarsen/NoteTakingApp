namespace NoteTakingApp
{
    partial class CaseForm
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
            this.noteList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteText = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.autditLogBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noteList);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 623);
            this.panel1.TabIndex = 0;
            // 
            // noteList
            // 
            this.noteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.noteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteList.FullRowSelect = true;
            this.noteList.HideSelection = false;
            this.noteList.Location = new System.Drawing.Point(0, 39);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(435, 584);
            this.noteList.TabIndex = 4;
            this.noteList.UseCompatibleStateImageBehavior = false;
            this.noteList.View = System.Windows.Forms.View.Details;
            this.noteList.SelectedIndexChanged += new System.EventHandler(this.noteList_SelectedIndexChanged);
            this.noteList.DoubleClick += new System.EventHandler(this.autditLogBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Timestamp";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preview";
            this.columnHeader2.Width = 300;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 39);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(435, 0);
            this.splitter1.MinExtra = 150;
            this.splitter1.MinSize = 150;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 623);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.noteText);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 623);
            this.panel2.TabIndex = 0;
            // 
            // noteText
            // 
            this.noteText.AcceptsReturn = true;
            this.noteText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteText.Location = new System.Drawing.Point(0, 39);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.ReadOnly = true;
            this.noteText.Size = new System.Drawing.Size(405, 557);
            this.noteText.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.clearBtn);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 27);
            this.panel4.TabIndex = 1;
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearBtn.Location = new System.Drawing.Point(255, 0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 27);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveBtn.Location = new System.Drawing.Point(330, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 27);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.autditLogBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 39);
            this.panel3.TabIndex = 0;
            // 
            // autditLogBtn
            // 
            this.autditLogBtn.Location = new System.Drawing.Point(318, 10);
            this.autditLogBtn.Name = "autditLogBtn";
            this.autditLogBtn.Size = new System.Drawing.Size(75, 23);
            this.autditLogBtn.TabIndex = 6;
            this.autditLogBtn.Text = "&Audit log";
            this.autditLogBtn.UseVisualStyleBackColor = true;
            this.autditLogBtn.Click += new System.EventHandler(this.autditLogBtn_Click);
            // 
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 623);
            this.Controls.Add(this.panel1);
            this.Name = "CaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Case";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListView noteList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button autditLogBtn;
    }
}