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
        int d� = 0;
        int resultat = 0;

        private void btnGenerer_Click(object sender, EventArgs e)
        {

            if (GenererDe())
            {
                var ordinaire = new D�Ordinaire(6, "oridinaire", 0, 0);
                int nombre = ordinaire.Resultat(0, 6);
                resultat = resultat + nombre;
                lblType.Text = ordinaire.TypeDe();
                lblValeur.Text = "Valeur : " + nombre.ToString();
                lblResultat.Text = "R�sultat : " + resultat.ToString();
            }
            else
            {
                var pipe = new D�Pip�(6, "ordinaire", 50, 3);
                int nombre = pipe.Resultat(50, 6);
                resultat = resultat + nombre;
                lblType.Text = pipe.TypeDe();
                lblValeur.Text = "Valeur : " + nombre.ToString();
                lblResultat.Text = "R�sultat : " + resultat.ToString();
            }
        }

        private Boolean GenererDe()
        {
            d� = random.Next(1, 3);

            if (d� == 1)
            {
                //d� ordinaire
                return true;
            }
            else
            {
                //d� pip�
                return false;
            }
        }
    }
}