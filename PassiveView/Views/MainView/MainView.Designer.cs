namespace PassiveView.Views.MainView
{
    partial class MainView
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
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbxCreatedUsers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNrOfCreatedUsers = new System.Windows.Forms.Label();
            this.btnClearAllUsers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(81, 173);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(106, 31);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(106, 88);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FirstName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastName:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(20, 134);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(103, 134);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "................................";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnCreateUser);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.tbxFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxLastName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserForm";
            // 
            // lstbxCreatedUsers
            // 
            this.lstbxCreatedUsers.FormattingEnabled = true;
            this.lstbxCreatedUsers.Location = new System.Drawing.Point(6, 43);
            this.lstbxCreatedUsers.Name = "lstbxCreatedUsers";
            this.lstbxCreatedUsers.Size = new System.Drawing.Size(266, 147);
            this.lstbxCreatedUsers.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblNrOfCreatedUsers);
            this.groupBox2.Controls.Add(this.btnClearAllUsers);
            this.groupBox2.Controls.Add(this.lstbxCreatedUsers);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 226);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Display";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Created Users:";
            // 
            // lblNrOfCreatedUsers
            // 
            this.lblNrOfCreatedUsers.AutoSize = true;
            this.lblNrOfCreatedUsers.Location = new System.Drawing.Point(141, 22);
            this.lblNrOfCreatedUsers.Name = "lblNrOfCreatedUsers";
            this.lblNrOfCreatedUsers.Size = new System.Drawing.Size(103, 13);
            this.lblNrOfCreatedUsers.TabIndex = 4;
            this.lblNrOfCreatedUsers.Text = "................................";
            // 
            // btnClearAllUsers
            // 
            this.btnClearAllUsers.Location = new System.Drawing.Point(108, 196);
            this.btnClearAllUsers.Name = "btnClearAllUsers";
            this.btnClearAllUsers.Size = new System.Drawing.Size(75, 23);
            this.btnClearAllUsers.TabIndex = 0;
            this.btnClearAllUsers.Text = "Clear All";
            this.btnClearAllUsers.UseVisualStyleBackColor = true;
            this.btnClearAllUsers.Click += new System.EventHandler(this.btnClearAllUsers_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbxCreatedUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNrOfCreatedUsers;
        private System.Windows.Forms.Button btnClearAllUsers;
    }
}

