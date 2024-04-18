
namespace Claculator
{
    partial class Calculator
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
            screen = new TextBox();
            clear = new Button();
            seven = new Button();
            four = new Button();
            division = new Button();
            eight = new Button();
            multiplication = new Button();
            nine = new Button();
            plus = new Button();
            minus = new Button();
            zero = new Button();
            dot = new Button();
            equal = new Button();
            five = new Button();
            six = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            ans = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // screen
            // 
            screen.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            screen.Location = new Point(12, 12);
            screen.Multiline = true;
            screen.Name = "screen";
            screen.Size = new Size(427, 51);
            screen.TabIndex = 5;
            screen.TextChanged += screen_TextChanged;
            // 
            // clear
            // 
            clear.BackColor = Color.FromArgb(255, 192, 192);
            clear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear.ForeColor = Color.White;
            clear.Location = new Point(12, 136);
            clear.Name = "clear";
            clear.Size = new Size(124, 43);
            clear.TabIndex = 6;
            clear.Text = "AC";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // seven
            // 
            seven.Font = new Font("Segoe UI", 14.25F);
            seven.Location = new Point(12, 185);
            seven.Name = "seven";
            seven.Size = new Size(124, 43);
            seven.TabIndex = 7;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // four
            // 
            four.Font = new Font("Segoe UI", 14.25F);
            four.Location = new Point(12, 234);
            four.Name = "four";
            four.Size = new Size(124, 43);
            four.TabIndex = 8;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // division
            // 
            division.BackColor = Color.FromArgb(255, 224, 192);
            division.Font = new Font("Microsoft Tai Le", 15.75F);
            division.ForeColor = Color.Gray;
            division.Location = new Point(142, 136);
            division.Name = "division";
            division.Size = new Size(124, 43);
            division.TabIndex = 10;
            division.Text = "/";
            division.UseVisualStyleBackColor = false;
            division.Click += division_Click;
            // 
            // eight
            // 
            eight.Font = new Font("Segoe UI", 14.25F);
            eight.Location = new Point(142, 185);
            eight.Name = "eight";
            eight.Size = new Size(124, 43);
            eight.TabIndex = 11;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // multiplication
            // 
            multiplication.BackColor = Color.FromArgb(255, 224, 192);
            multiplication.Font = new Font("Microsoft Tai Le", 15.75F);
            multiplication.ForeColor = Color.Gray;
            multiplication.Location = new Point(272, 136);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(124, 43);
            multiplication.TabIndex = 14;
            multiplication.Text = "x";
            multiplication.UseVisualStyleBackColor = false;
            multiplication.Click += multiplication_Click;
            // 
            // nine
            // 
            nine.Font = new Font("Segoe UI", 14.25F);
            nine.Location = new Point(272, 185);
            nine.Name = "nine";
            nine.Size = new Size(124, 43);
            nine.TabIndex = 15;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(255, 224, 192);
            plus.Font = new Font("Microsoft Tai Le", 15.75F);
            plus.ForeColor = Color.Gray;
            plus.Location = new Point(402, 234);
            plus.Name = "plus";
            plus.Size = new Size(37, 92);
            plus.TabIndex = 21;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.FromArgb(255, 224, 192);
            minus.Font = new Font("Microsoft Tai Le", 15.75F);
            minus.ForeColor = Color.Gray;
            minus.Location = new Point(402, 136);
            minus.Name = "minus";
            minus.Size = new Size(37, 92);
            minus.TabIndex = 22;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // zero
            // 
            zero.Font = new Font("Segoe UI", 14.25F);
            zero.Location = new Point(12, 332);
            zero.Name = "zero";
            zero.Size = new Size(124, 47);
            zero.TabIndex = 23;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // dot
            // 
            dot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dot.Location = new Point(142, 332);
            dot.Name = "dot";
            dot.Size = new Size(67, 47);
            dot.TabIndex = 24;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // equal
            // 
            equal.AccessibleRole = AccessibleRole.Alert;
            equal.BackColor = Color.FromArgb(255, 192, 128);
            equal.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equal.ForeColor = Color.WhiteSmoke;
            equal.Location = new Point(272, 332);
            equal.Name = "equal";
            equal.Size = new Size(167, 47);
            equal.TabIndex = 25;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // five
            // 
            five.Font = new Font("Segoe UI", 14.25F);
            five.Location = new Point(142, 234);
            five.Name = "five";
            five.Size = new Size(124, 43);
            five.TabIndex = 26;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // six
            // 
            six.Font = new Font("Segoe UI", 14.25F);
            six.Location = new Point(272, 234);
            six.Name = "six";
            six.Size = new Size(124, 43);
            six.TabIndex = 27;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI", 14.25F);
            one.Location = new Point(12, 283);
            one.Name = "one";
            one.Size = new Size(124, 43);
            one.TabIndex = 28;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // two
            // 
            two.Font = new Font("Segoe UI", 14.25F);
            two.Location = new Point(142, 283);
            two.Name = "two";
            two.Size = new Size(124, 43);
            two.TabIndex = 29;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // three
            // 
            three.Font = new Font("Segoe UI", 14.25F);
            three.Location = new Point(272, 283);
            three.Name = "three";
            three.Size = new Size(124, 43);
            three.TabIndex = 30;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // ans
            // 
            ans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ans.Location = new Point(215, 332);
            ans.Name = "ans";
            ans.Size = new Size(51, 47);
            ans.TabIndex = 31;
            ans.Text = "Ans";
            ans.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 51);
            textBox1.TabIndex = 32;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(451, 391);
            Controls.Add(textBox1);
            Controls.Add(ans);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(equal);
            Controls.Add(dot);
            Controls.Add(zero);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(nine);
            Controls.Add(multiplication);
            Controls.Add(eight);
            Controls.Add(division);
            Controls.Add(four);
            Controls.Add(seven);
            Controls.Add(clear);
            Controls.Add(screen);
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private TextBox screen;
        private Button clear;
        private Button seven;
        private Button four;
        private Button division;
        private Button eight;
        private Button multiplication;
        private Button nine;
        private Button plus;
        private Button minus;
        private Button zero;
        private Button dot;
        private Button equal;
        private Button five;
        private Button six;
        private Button one;
        private Button two;
        private Button three;
        private Button ans;
        private TextBox textBox1;
    }
}
