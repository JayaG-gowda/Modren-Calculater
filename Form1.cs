namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string a;
        Double b, c;

        public Form1()
        {
           
            InitializeComponent();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c=Double.Parse(textBox1.Text);
            textBox1.Clear();
            if (a == "+")
                textBox1.Text =Convert.ToString( b + c);
            textBox2.Clear();
            textBox2.Text = Convert.ToString(b) + "  " + (a)+" "+c;
            if (a == "-")
                textBox1.Text = Convert.ToString(b - c);
            textBox2.Clear();
            textBox2.Text = Convert.ToString(b) + "  " + (a) + " " + c;
            if (a == "*")
                textBox1.Text = Convert.ToString(b * c);
            textBox2.Clear();
            textBox2.Text = Convert.ToString(b) + "  " + (a) + " " + c;
            if (a == "/")
                textBox1.Text = Convert.ToString(b / c);
            textBox2.Clear();
            textBox2.Text = Convert.ToString(b) + "  " + (a) + " " + c;
            if (a == "%")
                textBox1.Text = Convert.ToString(b % c);
            textBox2.Clear();
            textBox2.Text = Convert.ToString(b) + "  " + (a) + " " + c;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double ee =Double.Parse(textBox1.Text);
            ee *= (-1);
            textBox1.Text = ee.ToString();
        }

        private void _Click(object sender, EventArgs e) 
        {
            Button bb = (Button)sender;
            a = bb.Text;
            b = Double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox2.Text = Convert.ToString(b) + "  " + (a);
        }

        private void Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + b.Text;
        }     
    }
}
