using System.Data;

namespace RugbyManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnAjouterJoueur_Click(object sender, EventArgs e)
        {
            FormAjouterJoueur formAjouter = new FormAjouterJoueur();
            formAjouter.Show();
            this.Hide();
        }

        private void btnModifierJoueur_Click(object sender, EventArgs e)
        {
            FormModifierJoueur formModifier = new FormModifierJoueur();
            formModifier.Show();
            this.Hide();
        }

        private void btnSupprimerJoueur_Click(object sender, EventArgs e)
        {
            FormSupprimerJoueur formSupprimer = new FormSupprimerJoueur();
            formSupprimer.Show();
            this.Hide();
        }

        private void btnGererEquipes_Click(object sender, EventArgs e)
        {
            FormGererEquipes formEquipes = new FormGererEquipes();
            formEquipes.Show();
            this.Hide();
        }

        private void btnSimulerMatch_Click(object sender, EventArgs e)
        {
            FormSimulerMatch simulerMatch = new FormSimulerMatch();
            simulerMatch.Show();
            this.Hide();
        }

        private void btnMiseAJourBlessures_Click(object sender, EventArgs e)
        {
            FormMiseAJourBlessures formBlessures = new FormMiseAJourBlessures();
            formBlessures.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            FormJoueurs formJoueurs = new FormJoueurs();
            formJoueurs.Show();
            this.Hide();
        }
    }
}