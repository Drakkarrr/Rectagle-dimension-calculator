namespace Asdas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);

            double area  = width * length;
            double perimeter = (width + length) * 2;

            lblPerimeter.Text = "The Perimeter is: " + perimeter;
            lblArea.Text = "The Area is: " + area;
        }
    }
}