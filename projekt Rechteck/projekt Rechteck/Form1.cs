namespace projekt_Rechteck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbxBreite_TextChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;

        }

        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

       

        

        private void tbxFlaeche_TextChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;

        }

        private void tbxUmfang_TextChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;

        }
    }
}
