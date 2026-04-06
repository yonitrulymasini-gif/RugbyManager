using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RugbyManager
{
    public partial class FormGererEquipes : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=valorant_manager;Uid=root;Pwd=root;";

        public FormGererEquipes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormGererEquipes_Load(object sender, EventArgs e)
        {
            // Configuration DataGridView
            dgvEquipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipes.MultiSelect = false;
            dgvEquipes.ReadOnly = true;
            dgvEquipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ← RÉDUIRE NOMBRE DE LIGNES VISIBLES
            dgvEquipes.Height = 150;           // 6 lignes max
            dgvEquipes.RowTemplate.Height = 25; // Lignes plus petites
            dgvEquipes.ScrollBars = ScrollBars.Vertical;

            AfficherEquipes();
        }

        private void AfficherEquipes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT e.id, e.nom, 
                               (SELECT COUNT(*) FROM Joueurs j WHERE j.equipe_id = e.id) AS nb_joueurs
                        FROM Equipes e 
                        ORDER BY e.nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nom");
                    dt.Columns.Add("Nb Joueurs");

                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetInt32("nb_joueurs")
                        );
                    }

                    uiDataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void uiButton6_Click(object sender, EventArgs e)
        {
            FormAccueil formMain = new FormAccueil();
            formMain.Show();
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une équipe !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells["ID"].Value);
            string nom = uiDataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'équipe '{nom}' ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM Equipes WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Équipe supprimée !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AfficherEquipes(); // actualise la liste
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomEquipe.Text))
            {
                MessageBox.Show("Veuillez saisir un nom d'équipe !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomEquipe.Focus();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO Equipes (nom) VALUES (@nom)", conn);
                    cmd.Parameters.AddWithValue("@nom", txtNomEquipe.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Équipe ajoutée avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNomEquipe.Clear();
                    AfficherEquipes();
                    txtNomEquipe.Focus();
                }
                catch (MySqlException ex) when (ex.Number == 1062)
                {
                    MessageBox.Show("Cette équipe existe déjà !", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
<<<<<<< Updated upstream
=======

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = -1;
            string nom = "";

            if (dgvEquipes.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvEquipes.SelectedRows[0].Cells["ID"].Value);
                nom = dgvEquipes.SelectedRows[0].Cells["Nom"].Value.ToString();
            }
            else if (!string.IsNullOrWhiteSpace(txtNomEquipe.Text))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmdRecherche = new MySqlCommand(
                            "SELECT id FROM Equipes WHERE nom = @nom", conn);
                        cmdRecherche.Parameters.AddWithValue("@nom", txtNomEquipe.Text.Trim());
                        object result = cmdRecherche.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show($"Aucune équipe '{txtNomEquipe.Text.Trim()}' trouvée !", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        id = Convert.ToInt32(result);
                        nom = txtNomEquipe.Text.Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur recherche : " + ex.Message, "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une équipe ou saisissez son nom !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmdCheck = new MySqlCommand(
                        "SELECT COUNT(*) FROM Joueurs WHERE equipe_id = @id", conn);
                    cmdCheck.Parameters.AddWithValue("@id", id);
                    int nbJoueurs = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (nbJoueurs > 0)
                    {
                        DialogResult liberer = MessageBox.Show(
                            $"L'équipe '{nom}' a {nbJoueurs} joueur(s).\n\nLibérer les joueurs ?",
                            "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (liberer == DialogResult.Cancel) return; 
                        if (liberer == DialogResult.Yes)              
                        {
                            MySqlCommand cmdLiberer = new MySqlCommand(
                                "UPDATE Joueurs SET equipe_id = NULL WHERE equipe_id = @id", conn);
                            cmdLiberer.Parameters.AddWithValue("@id", id);
                            cmdLiberer.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur vérification : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult confirm = MessageBox.Show(
                $"Supprimer définitivement '{nom}' ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM Equipes WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Équipe supprimée !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur suppression : " + ex.Message, "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            txtNomEquipe.Clear();
            AfficherEquipes();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }
>>>>>>> Stashed changes
    }
}