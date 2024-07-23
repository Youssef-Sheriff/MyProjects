namespace College_Management
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            userPassTxt = new TextBox();
            loginButton = new Button();
            loginButtons = new ComboBox();
            adminCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // userNameTxt
            // 
            userNameTxt.Location = new Point(198, 76);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.Size = new Size(100, 23);
            userNameTxt.TabIndex = 0;
            userNameTxt.TextChanged += userNameTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 79);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 128);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click_1;
            // 
            // userPassTxt
            // 
            userPassTxt.Location = new Point(198, 125);
            userPassTxt.Name = "userPassTxt";
            userPassTxt.Size = new Size(100, 23);
            userPassTxt.TabIndex = 3;
            userPassTxt.TextChanged += userPassTxt_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(211, 217);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginButtons
            // 
            loginButtons.FormattingEnabled = true;
            loginButtons.Items.AddRange(new object[] { "Student", "Doctor", "Admin" });
            loginButtons.Location = new Point(187, 174);
            loginButtons.Name = "loginButtons";
            loginButtons.Size = new Size(121, 23);
            loginButtons.TabIndex = 6;
            loginButtons.Text = "Who are";
            loginButtons.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Location = new Point(325, 178);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(60, 19);
            adminCheckBox.TabIndex = 7;
            adminCheckBox.Text = "admin";
            adminCheckBox.UseVisualStyleBackColor = true;
            adminCheckBox.CheckedChanged += adminCheckBox_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adminCheckBox);
            Controls.Add(loginButtons);
            Controls.Add(loginButton);
            Controls.Add(userPassTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userNameTxt);
            Name = "RegisterForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTxt;
        private Label label1;
        private Label label2;
        private TextBox userPassTxt;
        private Button loginButton;
        private ComboBox loginButtons;
        private CheckBox adminCheckBox;
    }
}
