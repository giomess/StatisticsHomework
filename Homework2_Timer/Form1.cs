using System;

namespace Timer_and_random
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        public Random r = new Random();
        public double product = 0;
        public int count = 0;
        List<int> list = new List<int>();

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            double a = r.NextDouble();
            double b = r.NextDouble();
            this.product = a * b;
            count += 1;
            product *= 100;
            int res = Convert.ToInt32(product);
            list.Add(res); 

            this.richTextBox1.AppendText("First value: " + a + Environment.NewLine);
            this.richTextBox1.AppendText("Second value: " + b + Environment.NewLine);
            this.richTextBox1.AppendText("Product: " + product + Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine);


            this.richTextBox1.ScrollToCaret();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.richTextBox1.AppendText("Number of interations: " + count + Environment.NewLine);
            this.richTextBox1.AppendText("Numbers for the lottery: " + Environment.NewLine);
            foreach (int i in list)
            {
                this.richTextBox1.AppendText(" " + i.ToString() + Environment.NewLine);
            }
        }
    }
}