namespace NoteTakingApp
{
    partial class Userform
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleDropDown = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.passwordPrompt = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ckSetPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(81, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(281, 20);
            this.name.TabIndex = 1;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(81, 39);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(281, 20);
            this.username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Role";
            // 
            // roleDropDown
            // 
            this.roleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleDropDown.FormattingEnabled = true;
            this.roleDropDown.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.roleDropDown.Location = new System.Drawing.Point(81, 115);
            this.roleDropDown.Name = "roleDropDown";
            this.roleDropDown.Size = new System.Drawing.Size(89, 21);
            this.roleDropDown.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(206, 154);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(287, 154);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // passwordPrompt
            // 
            this.passwordPrompt.AutoSize = true;
            this.passwordPrompt.Location = new System.Drawing.Point(13, 92);
            this.passwordPrompt.Name = "passwordPrompt";
            this.passwordPrompt.Size = new System.Drawing.Size(53, 13);
            this.passwordPrompt.TabIndex = 5;
            this.passwordPrompt.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(81, 89);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(281, 20);
            this.password.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckSetPassword
            // 
            this.ckSetPassword.AutoSize = true;
            this.ckSetPassword.Location = new System.Drawing.Point(81, 66);
            this.ckSetPassword.Name = "ckSetPassword";
            this.ckSetPassword.Size = new System.Drawing.Size(113, 17);
            this.ckSetPassword.TabIndex = 4;
            this.ckSetPassword.Text = "Set new password";
            this.ckSetPassword.UseVisualStyleBackColor = true;
            this.ckSetPassword.CheckedChanged += new System.EventHandler(this.ckSetPassword_CheckedChanged);
            // 
            // Userform
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(384, 189);
            this.Controls.Add(this.ckSetPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordPrompt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.roleDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Userform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Userform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleDropDown;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label passwordPrompt;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckSetPassword;
    }
}