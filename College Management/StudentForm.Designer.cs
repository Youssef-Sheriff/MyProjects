
namespace College_Management
{
    partial class StudentForm
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
            courseButton = new Button();
            backButton = new Button();
            gradeButton = new Button();
            SuspendLayout();
            // 
            // courseButton
            // 
            courseButton.Location = new Point(339, 103);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(75, 23);
            courseButton.TabIndex = 0;
            courseButton.Text = "Courses";
            courseButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.Location = new Point(339, 203);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // gradeButton
            // 
            gradeButton.Location = new Point(339, 153);
            gradeButton.Name = "gradeButton";
            gradeButton.Size = new Size(75, 23);
            gradeButton.TabIndex = 1;
            gradeButton.Text = "Grade";
            gradeButton.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradeButton);
            Controls.Add(backButton);
            Controls.Add(courseButton);
            Name = "StudentForm";
            Text = "Student";
            ResumeLayout(false);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        #endregion

        private Button courseButton;
        private Button backButton;
        private Button gradeButton;
    }
}