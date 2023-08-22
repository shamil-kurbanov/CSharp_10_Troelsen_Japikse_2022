namespace Waehrungsrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double euro = 1.0;
        private double dollar = 1.0;
        private double kurs = 1.0;

        private void textBox_Euro_KeyUp(object sender, KeyEventArgs e)
        {
            euro = Convert.ToDouble(textBox_Euro.Text);
            dollar = euro * kurs;
            textBox_Dollar.Text = dollar.ToString("#,##0.00");
        }

        private void textBox_Dollar_KeyUp(object sender, KeyEventArgs e)
        {
            dollar = Convert.ToDouble(textBox_Dollar.Text);
            euro = dollar / kurs;
            textBox_Euro.Text = euro.ToString("#,##0.00");
        }

        private void textBox_Kurs_KeyUp(object sender, KeyEventArgs e)
        {
            kurs = Convert.ToDouble(textBox_Kurs.Text);
            dollar = euro * kurs;
            textBox_Dollar.Text = dollar.ToString("#,##0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Euro.Text = euro.ToString();
            textBox_Dollar.Text = dollar.ToString();
            textBox_Kurs.Text = kurs.ToString();

        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}