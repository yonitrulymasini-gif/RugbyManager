using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RugbyManager
{
    public partial class FormSupprimerJoueur : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=db_schema;Uid=root;Pwd=cesi;";

        public FormSupprimerJoueur()
        {
            InitializeComponent();
            this.Load += FormSupprimerJoueur_Load;
        }

        private void FormSupprimerJoueur_Load(object sender, EventArgs e)
        {
            dgvJoueurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJoueurs.MultiSelect = false;
            dgvJoueurs.ReadOnly = true;
            dgvJoueurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AfficherJoueurs();
        }

        private void AfficherJoueurs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT j.id, j.nom, e.nom AS equipe, j.poste
                        FROM Joueurs j
                        LEFT JOIN Equipes e ON j.equipe_id = e.id
                        ORDER BY j.nom", conn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nom");
                    dt.Columns.Add("Equipe");
                    dt.Columns.Add("Poste");

                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.IsDBNull(2) ? "Sans équipe" : reader.GetString(2),
                            reader.GetString("poste")
                        );
                    }

                    dgvJoueurs.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvJoueurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un joueur à supprimer !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvJoueurs.SelectedRows[0].Cells["ID"].Value);
            string nom = dgvJoueurs.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le joueur '{nom}' ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM Joueurs WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Joueur supprimé !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AfficherJoueurs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }
    }
}