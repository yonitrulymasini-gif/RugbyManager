using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RugbyManager
{
    public partial class FormModifierJoueur : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=db_schema;Uid=root;Pwd=cesi;";
        int joueurIDSelectionne = -1;

        public FormModifierJoueur()
        {
            InitializeComponent();
        }

        private void FormModifierJoueur_Load(object sender, EventArgs e)
        {
            // Charger les postes
            cmbPoste.Items.Add("duelliste");
            cmbPoste.Items.Add("controleur");
            cmbPoste.Items.Add("initiateur");
            cmbPoste.Items.Add("sentinelle");

            // Charger les joueurs et équipes
            ChargerJoueurs();
            ChargerEquipes();
        }

        private void ChargerJoueurs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id, nom FROM Joueurs ORDER BY nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbJoueurs.Items.Clear();
                    cmbJoueurs.DisplayMember = "Text";
                    cmbJoueurs.ValueMember = "Value";

                    var items = new List<dynamic>();
                    while (reader.Read())
                    {
                        cmbJoueurs.Items.Add(new { Text = reader.GetString("nom"), Value = reader.GetInt32("id") });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement joueurs : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChargerEquipes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT nom FROM Equipes ORDER BY nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbEquipe.Items.Clear();
                    while (reader.Read())
                    {
                        cmbEquipe.Items.Add(reader.GetString("nom"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement équipes : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbJoueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJoueurs.SelectedItem == null) return;

            // Récupérer l'ID du joueur sélectionné
            dynamic selected = cmbJoueurs.SelectedItem;
            joueurIDSelectionne = selected.Value;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT j.poste, j.vitesse, j.endurance, j.force_physique, j.technique, e.nom AS equipe
                        FROM Joueurs j
                        LEFT JOIN Equipes e ON j.equipe_id = e.id
                        WHERE j.id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", joueurIDSelectionne);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Remplir les champs avec les données actuelles du joueur
                        cmbPoste.SelectedItem = reader.GetString("poste");
                        cmbEquipe.SelectedItem = reader.GetString("equipe");
                        nudVitesse.Value = reader.GetInt32("vitesse");
                        nudEndurance.Value = reader.GetInt32("endurance");
                        nudForce.Value = reader.GetInt32("force_physique");
                        nudTechnique.Value = reader.GetInt32("technique");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (joueurIDSelectionne == -1 || cmbPoste.SelectedItem == null || cmbEquipe.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un joueur !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Récupérer l'ID de l'équipe
                    MySqlCommand cmdEquipe = new MySqlCommand(
                        "SELECT id FROM Equipes WHERE nom = @nom", conn);
                    cmdEquipe.Parameters.AddWithValue("@nom", cmbEquipe.SelectedItem.ToString());
                    int equipeID = Convert.ToInt32(cmdEquipe.ExecuteScalar());

                    // Mettre à jour le joueur
                    MySqlCommand cmd = new MySqlCommand(@"
                        UPDATE Joueurs 
                        SET poste = @poste, equipe_id = @equipeID, vitesse = @vitesse, 
                            endurance = @endurance, force_physique = @force, technique = @technique
                        WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@poste", cmbPoste.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@equipeID", equipeID);
                    cmd.Parameters.AddWithValue("@vitesse", (int)nudVitesse.Value);
                    cmd.Parameters.AddWithValue("@endurance", (int)nudEndurance.Value);
                    cmd.Parameters.AddWithValue("@force", (int)nudForce.Value);
                    cmd.Parameters.AddWithValue("@technique", (int)nudTechnique.Value);
                    cmd.Parameters.AddWithValue("@id", joueurIDSelectionne);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Joueur modifié avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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