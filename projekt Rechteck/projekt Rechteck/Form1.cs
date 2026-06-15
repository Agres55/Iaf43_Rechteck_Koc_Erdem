namespace projekt_Rechteck
{
    public partial class Form1 : Form
    {
        private Rechteck meinRechteck;

        public Form1()
        {
            InitializeComponent();
        }
        Rechteck rechteck = new Rechteck();



        private void Form1_Load(object sender, EventArgs e)
        {




        }



        private void btnReinzoomen_Click(object sender, EventArgs e)
        {
            try
            {
                rechteck.Zoomen(1.1);
                tbxBreite.Text = Math.Round(rechteck.Breite, 2).ToString();
                tbxHoehe.Text = Math.Round(rechteck.Hoehe, 2).ToString();
            }
            catch (Exception ex)
            {
                // Bei allen problemen kommt diese messagebox
                MessageBox.Show("FEHLER ! " + ex.Message);
            }
        }

        private void btnRauszoomen_Click(object sender, EventArgs e)
        {
            try
            {
                rechteck.Zoomen(1 / 1.1);
                tbxBreite.Text = Math.Round(rechteck.Breite, 2).ToString();
                tbxHoehe.Text = Math.Round(rechteck.Hoehe, 2).ToString();
            }
            catch (Exception ex)
            {
                // Bei allen problemen kommt diese messagebox
                MessageBox.Show("FEHLER ! " + ex.Message);
            }
        }





        private void tbxBreite_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Wenn das Textfeld leer ist mach hier nicht weiter
                if (string.IsNullOrWhiteSpace(tbxBreite.Text))
                {
                    return;
                }

                // Text in eine Zahl umwandeln und im Objekt rechteck speichert
                rechteck.Breite = Convert.ToDouble(tbxBreite.Text);

                // Ergebnisse auf 2 Nachkommastellen runden und anzeigen
                tbxUmfang.Text = Math.Round(rechteck.Umfang(), 3).ToString();
                tbxFlaeche.Text = Math.Round(rechteck.Flaeche(), 3).ToString();
                tbxDiagonale.Text = Math.Round(rechteck.Diagonal(), 3).ToString();


            }
            catch (FormatException)
            {
                // Dieser Fehler kommt wenn der Text keine Zahl war 
                MessageBox.Show("Zahl eingeben !");
            }
            catch (Exception ex)
            {
                // Bei allen problemen kommt diese messagebox
                MessageBox.Show("FEHLER ! " + ex.Message);
            }
        }

        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Wenn das Textfeld leer ist mach hier nicht weiter
                if (string.IsNullOrWhiteSpace(tbxHoehe.Text))
                {
                    return;
                }

                // Text in eine Zahl umwandeln und im Objekt rechteck speichern
                rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text);

                // Ergebnisse auf 3 Nachkommastellen runden und anzeigen
                tbxUmfang.Text = Math.Round(rechteck.Umfang(), 3).ToString();
                tbxFlaeche.Text = Math.Round(rechteck.Flaeche(), 3).ToString();
                tbxDiagonale.Text = Math.Round(rechteck.Diagonal(), 3).ToString();


            }
            catch (FormatException)
            {
                // Dieser Fehler kommt, wenn der Text keine Zahl war 
                MessageBox.Show("Zahl eingeben !");
            }
            catch (Exception ex)
            {
                // Dieser Fehler kommt bei allen anderen Problemen
                MessageBox.Show("FEHLER ! " + ex.Message);
            }
        }

        private void tbxFlaeche_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            rechteck.Drehen();
            tbxBreite.Text = Math.Round(rechteck.Breite, 2).ToString();
            tbxHoehe.Text = Math.Round(rechteck.Hoehe, 2).ToString();
        }
    }
}
