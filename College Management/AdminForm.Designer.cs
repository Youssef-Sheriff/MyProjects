namespace College_Management
{
    partial class AdminForm
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
            newStudentButton = new Button();
            userAdd = new TextBox();
            deleteStudentButton = new Button();
            passAdd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            doctorCheck = new CheckBox();
            studentCheck = new CheckBox();
            backAdmin = new Button();
            SuspendLayout();
            // 
            // newStudentButton
            // 
            newStudentButton.Location = new Point(280, 202);
            newStudentButton.Name = "newStudentButton";
            newStudentButton.Size = new Size(163, 23);
            newStudentButton.TabIndex = 0;
            newStudentButton.Text = "New User";
            newStudentButton.UseVisualStyleBackColor = true;
            newStudentButton.Click += newStudentButton_Click;
            // 
            // userAdd
            // 
            userAdd.Location = new Point(280, 64);
            userAdd.Name = "userAdd";
            userAdd.Size = new Size(163, 23);
            userAdd.TabIndex = 1;
            userAdd.TextChanged += userAdd_TextChanged;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(280, 244);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(163, 23);
            deleteStudentButton.TabIndex = 3;
            deleteStudentButton.Text = "Delete User";
            deleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // passAdd
            // 
            passAdd.Location = new Point(280, 117);
            passAdd.Name = "passAdd";
            passAdd.Size = new Size(163, 23);
            passAdd.TabIndex = 4;
            passAdd.TextChanged += passAdd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 67);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 120);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // doctorCheck
            // 
            doctorCheck.AutoSize = true;
            doctorCheck.Location = new Point(381, 164);
            doctorCheck.Name = "doctorCheck";
            doctorCheck.Size = new Size(62, 19);
            doctorCheck.TabIndex = 7;
            doctorCheck.Text = "Doctor";
            doctorCheck.UseVisualStyleBackColor = true;
            doctorCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // studentCheck
            // 
            studentCheck.AutoSize = true;
            studentCheck.Location = new Point(280, 164);
            studentCheck.Name = "studentCheck";
            studentCheck.Size = new Size(67, 19);
            studentCheck.TabIndex = 8;
            studentCheck.Text = "Student";
            studentCheck.UseVisualStyleBackColor = true;
            // 
            // backAdmin
            // 
            backAdmin.Location = new Point(280, 286);
            backAdmin.Name = "backAdmin";
            backAdmin.Size = new Size(163, 23);
            backAdmin.TabIndex = 9;
            backAdmin.Text = "Back";
            backAdmin.UseVisualStyleBackColor = true;
            backAdmin.Click += backAdmin_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backAdmin);
            Controls.Add(studentCheck);
            Controls.Add(doctorCheck);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passAdd);
            Controls.Add(deleteStudentButton);
            Controls.Add(userAdd);
            Controls.Add(newStudentButton);
            Name = "AdminForm";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newStudentButton;
        private TextBox userAdd;
        private Button deleteStudentButton;
        private TextBox passAdd;
        private Label label1;
        private Label label2;
        private CheckBox doctorCheck;
        private CheckBox studentCheck;
        private Button button1;
        private Button backAdmin;
    }
}