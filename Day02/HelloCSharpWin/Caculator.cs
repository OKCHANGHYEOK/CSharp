namespace HelloCSharpWin
{
    public partial class Caculator : Form
    {
        public Caculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            HelloLabel.Text = "Hello C#";

            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }
    }
}
