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
    public partial class FormAjouterJoueur : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=valorant_manager;Uid=root;Pwd=root;";

        public FormAjouterJoueur()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormAjouterJoueur_Load(object sender, EventArgs e)
        {
            // Charger les postes
            uiComboBox1.Items.Add("duelliste");
            uiComboBox1.Items.Add("controleur");
            uiComboBox1.Items.Add("initiateur");
            uiComboBox1.Items.Add("sentinelle");

            // Charger les équipes depuis la BDD
            ChargerEquipes();
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

                    uiComboBox2.Items.Clear();
                    while (reader.Read())
                    {
                        uiComboBox2.Items.Add(reader.GetString("nom"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement équipes : " + ex.Message, "Erreur",
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
            if (uiTextBox1.Text == "" || uiComboBox1.SelectedItem == null || uiComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmdEquipe = new MySqlCommand(
                        "SELECT id FROM Equipes WHERE nom = ?", conn);
                    cmdEquipe.Parameters.AddWithValue("?", uiComboBox2.SelectedItem.ToString());
                    object result = cmdEquipe.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Équipe introuvable !", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int equipeID = Convert.ToInt32(result);

                    MySqlCommand cmd = new MySqlCommand(@"
                        INSERT INTO Joueurs (nom, equipe_id, poste, vitesse, endurance, force_physique, technique) 
                        VALUES (?, ?, ?, ?, ?, ?, ?)", conn);

                    cmd.Parameters.AddWithValue("@nom", uiTextBox1.Text);
                    cmd.Parameters.AddWithValue("@equipeID", equipeID);
                    cmd.Parameters.AddWithValue("@poste", uiComboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@vitesse", (int)uiIntegerUpDown1.Value);
                    cmd.Parameters.AddWithValue("@endurance", (int)uiIntegerUpDown2.Value);
                    cmd.Parameters.AddWithValue("@force", (int)uiIntegerUpDown3.Value);
                    cmd.Parameters.AddWithValue("@technique", (int)uiIntegerUpDown4.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Joueur ajouté avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormAccueil formMain = new FormAccueil();
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
        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiLedLabel7_Click(object sender, EventArgs e)
        {

        }
        private void uiNumPadTextBox1_ValueChanged(object sender, string value)
        {

        }

        private void uiIntegerUpDown1_ValueChanged(object sender, int value)
        {

        }
    }
}