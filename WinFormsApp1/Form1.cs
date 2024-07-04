namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int num = (int)numericUpDown1.Value;
            int result = await calculateFactorialAsync(num);
            label2.Text = result.ToString();
        }
        private Task<int> calculateFactorialAsync(int num)
        {
            return Task.Run(() => calculateFactorial(num));
        }
        private int calculateFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;

            }
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
