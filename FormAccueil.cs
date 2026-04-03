using System.Data;

namespace RugbyManager
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            FormJoueurs formJoueurs = new FormJoueurs();
            formJoueurs.Show();
            this.Hide();
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            FormAjouterJoueur formAjouter = new FormAjouterJoueur();
            formAjouter.Show();
            this.Hide();
        }
        private void uiButton3_Click(object sender, EventArgs e)
        {
            FormSupprimerJoueur formSupprimer = new FormSupprimerJoueur();
            formSupprimer.Show();
            this.Hide();
        }
        private void uiButton4_Click(object sender, EventArgs e)
        {
            FormModifierJoueur formModifier = new FormModifierJoueur();
            formModifier.Show();
            this.Hide();
        }
        private void uiButton5_Click(object sender, EventArgs e)
        {
            FormSimulerMatch simulerMatch = new FormSimulerMatch();
            simulerMatch.Show();
            this.Hide();
        }
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Form1 formMain = new Form1();
            formMain.Show();
            this.Close();
        }
        private void uiButton7_Click(object sender, EventArgs e)
        {
            FormGererEquipes formEquipes = new FormGererEquipes();
            formEquipes.Show();
            this.Hide();
        }
        private void uiButton8_Click(object sender, EventArgs e)
        {
            FormMiseAJourBlessures formBlessures = new FormMiseAJourBlessures();
            formBlessures.Show();
            this.Hide();
        }
    }
}