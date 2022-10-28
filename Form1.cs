namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Tc: {maskedTextBox1.Text}");
            listBox1.Items.Add($"Kiþi : {textBox1.Text} {textBox2.Text}");
            listBox1.Items.Add($"Tel No: {maskedTextBox2.Text}");
            listBox1.Items.Add($"Adres : {Adres.Text} ");
            listBox1.Items.Add($"Medeni Hali : {radioButton1.Text}{radioButton2.Text}");
            listBox1.Items.Add($"Online Katýlým : {checkBox1.Text}");
            listBox1.Items.Add($"Tarih : {dateTimePicker1.Text}");


        }
    }
}