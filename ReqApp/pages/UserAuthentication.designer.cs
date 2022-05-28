
namespace ReqApp
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.sizePanel = new System.Windows.Forms.Panel();
            this.closeSignInWindowButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginFeedbackLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameErrorFeedback = new System.Windows.Forms.Label();
            this.passwordErrorFeedback = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.sizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizePanel
            // 
            this.sizePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sizePanel.Controls.Add(this.closeSignInWindowButton);
            this.sizePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sizePanel.Location = new System.Drawing.Point(0, 0);
            this.sizePanel.Name = "sizePanel";
            this.sizePanel.Size = new System.Drawing.Size(1465, 31);
            this.sizePanel.TabIndex = 0;
            this.sizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sizePanel_MouseDown);
            // 
            // closeSignInWindowButton
            // 
            this.closeSignInWindowButton.BackColor = System.Drawing.Color.Gainsboro;
            this.closeSignInWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeSignInWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeSignInWindowButton.FlatAppearance.BorderSize = 0;
            this.closeSignInWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeSignInWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSignInWindowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.closeSignInWindowButton.Location = new System.Drawing.Point(1434, 4);
            this.closeSignInWindowButton.Name = "closeSignInWindowButton";
            this.closeSignInWindowButton.Size = new System.Drawing.Size(25, 23);
            this.closeSignInWindowButton.TabIndex = 1;
            this.closeSignInWindowButton.Text = "X";
            this.closeSignInWindowButton.UseVisualStyleBackColor = false;
            this.closeSignInWindowButton.Click += new System.EventHandler(this.closeSignInWindowButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.loginFeedbackLabel);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.LoginButton);
            this.panel4.Location = new System.Drawing.Point(450, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 462);
            this.panel4.TabIndex = 4;
            // 
            // loginFeedbackLabel
            // 
            this.loginFeedbackLabel.AutoSize = true;
            this.loginFeedbackLabel.BackColor = System.Drawing.Color.White;
            this.loginFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.loginFeedbackLabel.Location = new System.Drawing.Point(223, 421);
            this.loginFeedbackLabel.Name = "loginFeedbackLabel";
            this.loginFeedbackLabel.Size = new System.Drawing.Size(109, 17);
            this.loginFeedbackLabel.TabIndex = 4;
            this.loginFeedbackLabel.Text = "Login Feedback";
            this.loginFeedbackLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userPasswordTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.usernameErrorFeedback, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordErrorFeedback, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameLabel.Location = new System.Drawing.Point(3, 6);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(101, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Kullanıcı Adı";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.usernameTextBox.Location = new System.Drawing.Point(2, 42);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(522, 40);
            this.usernameTextBox.TabIndex = 2;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.userPasswordTextBox.Location = new System.Drawing.Point(2, 175);
            this.userPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(522, 40);
            this.userPasswordTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(3, 135);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(44, 20);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Şifre";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameErrorFeedback
            // 
            this.usernameErrorFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameErrorFeedback.AutoSize = true;
            this.usernameErrorFeedback.ForeColor = System.Drawing.Color.Red;
            this.usernameErrorFeedback.Location = new System.Drawing.Point(3, 98);
            this.usernameErrorFeedback.Name = "usernameErrorFeedback";
            this.usernameErrorFeedback.Size = new System.Drawing.Size(520, 17);
            this.usernameErrorFeedback.TabIndex = 6;
            this.usernameErrorFeedback.Text = "usernameErrorFeedback";
            this.usernameErrorFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameErrorFeedback.Visible = false;
            // 
            // passwordErrorFeedback
            // 
            this.passwordErrorFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordErrorFeedback.AutoSize = true;
            this.passwordErrorFeedback.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorFeedback.Location = new System.Drawing.Point(3, 236);
            this.passwordErrorFeedback.Name = "passwordErrorFeedback";
            this.passwordErrorFeedback.Size = new System.Drawing.Size(520, 17);
            this.passwordErrorFeedback.TabIndex = 7;
            this.passwordErrorFeedback.Text = "passwordErrorFeedback";
            this.passwordErrorFeedback.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.SignInLabel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 50);
            this.panel3.TabIndex = 1;
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SignInLabel.ForeColor = System.Drawing.Color.White;
            this.SignInLabel.Location = new System.Drawing.Point(258, 12);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(65, 29);
            this.SignInLabel.TabIndex = 3;
            this.SignInLabel.Text = "Giriş";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(90)))), ((int)(((byte)(203)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(16, 348);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(526, 60);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Giriş Yap";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1465, 832);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sizePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.sizePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sizePanel;
        private System.Windows.Forms.Button closeSignInWindowButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Label loginFeedbackLabel;
        private System.Windows.Forms.Label usernameErrorFeedback;
        private System.Windows.Forms.Label passwordErrorFeedback;
    }
}

