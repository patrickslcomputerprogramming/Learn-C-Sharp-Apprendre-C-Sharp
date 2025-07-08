namespace CovertisseurrTemperature
{
    public partial class Form1 : Form
    {
        //Champs
        private double temperature_entree;
        private string type_entree;
        private double temperature_sortie_celcius;
        private double temperature_sortie_fahrenheit;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblTemperatureEntree_Click(object sender, EventArgs e)
        {
            txbTemperatureEntree.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlContenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbTemperatureEntree_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.temperature_entree = double.Parse(txbTemperatureEntree.Text);
            }
            catch
            {
                //Calculer message d'erreur pour type de données saisies incorrectes
                string messageDonneesIncorrectes = "Erreur de saisie détectée!\nTempérature doit être un nombre entier.";
                //Afficher message d'erreur 
                MessageBox.Show(messageDonneesIncorrectes);

                //Effacer données incorrect saisies
                txbTemperatureEntree.TextChanged -= new System.EventHandler(this.txbTemperatureEntree_TextChanged); //Desactiver l'evennement
                txbTemperatureEntree.Clear();
                txbTemperatureEntree.TextChanged += new System.EventHandler(this.txbTemperatureEntree_TextChanged); //Desactiver l'evennement
            }
        }

        private void cbbTypeEntree_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.type_entree = cbbTypeEntree.Text;
        }

        private void txbTemperatureCelcius_TextChanged(object sender, EventArgs e)
        {
            txbTemperatureCelcius.Text = Math.Round(this.temperature_sortie_celcius, 2).ToString();
        }

        private void txbTemperatureFahrenheit_TextChanged(object sender, EventArgs e)
        {
            txbTemperatureFahrenheit.Text = Math.Round(this.temperature_sortie_fahrenheit, 2).ToString();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //Si le champ Temperature est vide
            if (txbTemperatureEntree.Text == "")
            {
                //Calculer message d'erreur
                string messageChampVide = "Erreur de saisie détectée!";
                messageChampVide += "\nLe champ \"Temperature\" est vide.";
                //Afficher message d'erreur
                MessageBox.Show(messageChampVide);
            }
            //Si le champ Temperature n'est pas vide
            else
            {
                //Calculer des données de sorties
                //Créer une instance de la classe de calcul
                ConvertirTemperature calculer = new ConvertirTemperature(temperature_entree, type_entree);
                //Calculer 
                if (cbbTypeEntree.Text == "Celcius")
                {
                    temperature_sortie_fahrenheit = calculer.CelciusVersFahrenheit();
                    temperature_sortie_celcius = temperature_entree;
                }
                else if (cbbTypeEntree.Text == "Fahrenheit")
                {
                    temperature_sortie_celcius = calculer.FahrenheitVersCelcius();
                    temperature_sortie_fahrenheit = temperature_entree;
                }
                //Afficher des données de sorties
                this.txbTemperatureCelcius_TextChanged(this, e);
                this.txbTemperatureFahrenheit_TextChanged(this, e);

                //Effacer les champs Temperature et Type
                //txbTemperatureEntree
                txbTemperatureEntree.TextChanged -= new System.EventHandler(this.txbTemperatureEntree_TextChanged); //Desactiver l'evennement
                txbTemperatureEntree.Clear();
                txbTemperatureEntree.TextChanged += new System.EventHandler(this.txbTemperatureEntree_TextChanged); //Desactiver l'evennement

                //txbTemperatureEntree
                cbbTypeEntree.SelectedIndex = -1;
            }
        }

        private void lblTypeEntree_Click(object sender, EventArgs e)
        {
            cbbTypeEntree.Focus();
        }
    }

    // Déclarer une classe
    class ConvertirTemperature
    {
        //Champs
        private double degre_celcius;
        private double degre_fahrenheit;

        // Méthode Constructeur 
        public ConvertirTemperature(double temp, string typ)
        {
            if (typ == "Celcius")
            {
                degre_celcius = temp;
            }
            else if (typ == "Fahrenheit")
            {
                degre_fahrenheit = temp;
            }
        }

        // Méthodes
        public double CelciusVersFahrenheit()
        {
            //Calculer et envoyer les données de sortie
            return ((1.8 * degre_celcius) + 32);
        }

        // Méthodes
        public double FahrenheitVersCelcius()
        {
            //Calculer et envoyer les données de sortie
            return ((degre_fahrenheit - 32) / 1.8);
        }
    }
}