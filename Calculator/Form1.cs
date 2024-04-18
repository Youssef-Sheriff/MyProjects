namespace Claculator;

public partial class Calculator : Form
{
    string word = "";
    double answer = 0.0;
    public Calculator()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void zero_Click(object sender, EventArgs e)
    {
        // that's mean if the user click on the button zero the zero will be added to the screen

        if (screen.Text != string.Empty) // if the screen is empty
        {
            screen.Text = screen.Text + "0";
            word += "0";
        }
            
    }

    private void dot_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + ".";
        word += ".";
    }

    private void one_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "1";
        word += "1";
    }

    private void two_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "2";
        word += "2";
    }

    private void three_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "3";
        word += "3";
    }

    private void four_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "4";
        word += "4";
    }

    private void five_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "5";
        word += "5";
    }

    private void six_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "6";
        word += "6";
    }

    private void seven_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "7";
        word += "7";
    }

    private void eight_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "8";
        word += "8";
    }

    private void nine_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "9";
        word += "9";
    }

    private void plus_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "+";
        word += "+";
    }

    private void minus_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "-";
        word += "-";
    }

    private void multiplication_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "*";
        word += "*";
    }

    private void division_Click(object sender, EventArgs e)
    {
        screen.Text = screen.Text + "/";
        word += "/";
    }

    private void clear_Click(object sender, EventArgs e)
    {
        // clear the screen
        screen.Clear();
    }

    private void equal_Click(object sender, EventArgs e)
    {
        var szOfWord = word.Length;
        foreach (var ch in word)
        {
            if (ch == '+')
            {
                var index = word.IndexOf(ch);
                var first = word.Substring(0, index);
                var second = word.Substring(index + 1, szOfWord - index - 1);
                answer = Convert.ToDouble(first) + Convert.ToDouble(second);
                screen.Text = answer.ToString();
                word = answer.ToString();
            }
            else if (ch == '-')
            {
                var index = word.IndexOf(ch);
                var first = word.Substring(0, index);
                var second = word.Substring(index + 1, szOfWord - index - 1);
                answer = Convert.ToDouble(first) - Convert.ToDouble(second);
                screen.Text = answer.ToString();
                word = answer.ToString();
            }
            else if (ch == '*')
            {
                var index = word.IndexOf(ch);
                var first = word.Substring(0, index);
                var second = word.Substring(index + 1, szOfWord - index - 1);
                answer = Convert.ToDouble(first) * Convert.ToDouble(second);
                screen.Text = answer.ToString();
                word = answer.ToString();
            }
            else if (ch == '/')
            {
                var index = word.IndexOf(ch);
                var first = word.Substring(0, index);
                var second = word.Substring(index + 1, szOfWord - index - 1);
                answer = Convert.ToDouble(first) / Convert.ToDouble(second);
                screen.Text = answer.ToString();
                word = answer.ToString();
            }
        }
    }
        
   
        private void screen_TextChanged(object sender, EventArgs e)
    {
        
    }
}
