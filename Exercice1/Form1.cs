namespace Exercice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //initialise variable
        Random random = new Random();
        int dé = 0;
        int resultat = 0;

        private void btnGenerer_Click(object sender, EventArgs e)
        {

            if (GenererDe())
            {
                var ordinaire = new DéOrdinaire(6, "oridinaire", 0, 0);
                int nombre = ordinaire.Resultat(0, 6);
                resultat = resultat + nombre;
                lblType.Text = ordinaire.TypeDe();
                lblValeur.Text = "Valeur : " + nombre.ToString();
                lblResultat.Text = "Résultat : " + resultat.ToString();
            }
            else
            {
                var pipe = new DéPipé(6, "ordinaire", 50, 3);
                int nombre = pipe.Resultat(50, 6);
                resultat = resultat + nombre;
                lblType.Text = pipe.TypeDe();
                lblValeur.Text = "Valeur : " + nombre.ToString();
                lblResultat.Text = "Résultat : " + resultat.ToString();
            }
        }

        private Boolean GenererDe()
        {
            dé = random.Next(1, 3);

            if (dé == 1)
            {
                //dé ordinaire
                return true;
            }
            else
            {
                //dé pipé
                return false;
            }
        }
    }
}