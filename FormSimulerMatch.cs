using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RugbyManager
{
    public partial class FormSimulerMatch : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=valorant_manager;Uid=root;Pwd=root;";

        public FormSimulerMatch()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SimulerMatch_Load(object sender, EventArgs e)
        {
            dgvJoueurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJoueurs.MultiSelect = false;
            dgvJoueurs.ReadOnly = true;
            dgvJoueurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AfficherJoueursDisponibles();
            ChargerEquipesAdversaires();
        }

        private void ChargerEquipesAdversaires()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id, nom FROM Equipes ORDER BY nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("id");
                    dt.Columns.Add("nom");

                    while (reader.Read())
                    {
                        dt.Rows.Add(reader.GetInt32("id"), reader.GetString("nom"));
                    }

                    cmbAdversaire.DataSource = dt;
                    cmbAdversaire.DisplayMember = "nom";
                    cmbAdversaire.ValueMember = "id";
                    cmbAdversaire.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement équipes : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AfficherJoueursDisponibles()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT j.id, j.nom, e.nom AS equipe, j.poste,
                               j.vitesse, j.endurance, j.force_physique, j.technique
                        FROM Joueurs j
                        LEFT JOIN Equipes e ON j.equipe_id = e.id
                        WHERE j.blesse = 0
                        ORDER BY j.nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nom");
                    dt.Columns.Add("Equipe");
                    dt.Columns.Add("Poste");
                    dt.Columns.Add("Vitesse");
                    dt.Columns.Add("Endurance");
                    dt.Columns.Add("Force");
                    dt.Columns.Add("Technique");

                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.IsDBNull(2) ? "Sans équipe" : reader.GetString(2),
                            reader.GetString("poste"),
                            reader.GetInt32("vitesse"),
                            reader.GetInt32("endurance"),
                            reader.GetInt32("force_physique"),
                            reader.GetInt32("technique")
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
        private void txtAdversaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            FormAccueil formMain = new FormAccueil();
            formMain.Show();
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (cmbAdversaire.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un adversaire !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

<<<<<<< Updated upstream:FormSimulerMatch.cs
            if (uiDataGridView1.Rows.Count < 1)
=======
            if (dgvJoueurs.Rows.Count == 0 || dgvJoueurs.Rows[0].IsNewRow)
>>>>>>> Stashed changes:SimulerMatch.cs
            {
                MessageBox.Show("Pas de joueurs disponibles !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomAdversaire = cmbAdversaire.Text;

            double totalStats = 0;
            int nbJoueurs = 0;
            foreach (DataGridViewRow row in uiDataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                totalStats += (Convert.ToInt32(row.Cells["Vitesse"].Value) +
                              Convert.ToInt32(row.Cells["Endurance"].Value) +
                              Convert.ToInt32(row.Cells["Force"].Value) +
                              Convert.ToInt32(row.Cells["Technique"].Value)) / 4.0;
                nbJoueurs++;
            }

            double moyenneEquipe = nbJoueurs > 0 ? totalStats / nbJoueurs : 50;
            Random rand = new Random();
            double chanceVictoire = moyenneEquipe / 100.0;
            bool gagne = rand.NextDouble() < chanceVictoire;

            int scoreNous = gagne ? rand.Next(10, 30) : rand.Next(0, 25);
            int scoreAdversaire = gagne ? rand.Next(0, scoreNous) : rand.Next(10, 30);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmdMatch = new MySqlCommand(@"
                        INSERT INTO Matchs (adversaire, score_nous, score_adversaire) 
                        VALUES (@adversaire, @scoreNous, @scoreAdversaire)", conn);
                    cmdMatch.Parameters.AddWithValue("@adversaire", nomAdversaire);
                    cmdMatch.Parameters.AddWithValue("@scoreNous", scoreNous);
                    cmdMatch.Parameters.AddWithValue("@scoreAdversaire", scoreAdversaire);
                    cmdMatch.ExecuteNonQuery();

<<<<<<< Updated upstream:FormSimulerMatch.cs
                    // Mettre à jour les stats et blessures
                    foreach (DataGridViewRow row in uiDataGridView1.Rows)
=======
                    foreach (DataGridViewRow row in dgvJoueurs.Rows)
>>>>>>> Stashed changes:SimulerMatch.cs
                    {
                        if (row.IsNewRow) continue;
                        int id = Convert.ToInt32(row.Cells["ID"].Value);

                        if (gagne)
                        {
                            MySqlCommand cmdUpdate = new MySqlCommand(@"
                                UPDATE Joueurs SET technique = LEAST(technique + 3, 100), 
                                                   vitesse = LEAST(vitesse + 1, 100) 
                                WHERE id = @id", conn);
                            cmdUpdate.Parameters.AddWithValue("@id", id);
                            cmdUpdate.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlCommand cmdUpdate = new MySqlCommand(@"
                                UPDATE Joueurs SET endurance = GREATEST(endurance - 1, 0) 
                                WHERE id = @id", conn);
                            cmdUpdate.Parameters.AddWithValue("@id", id);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        if (rand.NextDouble() < 0.2)
                        {
                            MySqlCommand cmdBlesse = new MySqlCommand(@"
                                UPDATE Joueurs SET blesse = TRUE, matchs_indisponibles = 3 
                                WHERE id = @id", conn);
                            cmdBlesse.Parameters.AddWithValue("@id", id);
                            cmdBlesse.ExecuteNonQuery();
                        }
                    }

                    string resultat = gagne ? "🎉 VICTOIRE !" : "😞 DÉFAITE !";
                    MessageBox.Show(
                        $"{resultat}\n\n{scoreNous} - {scoreAdversaire} contre {nomAdversaire}\n\nMoyenne équipe : {moyenneEquipe:F1}/100",
                        "Résultat du match", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AfficherJoueursDisponibles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}