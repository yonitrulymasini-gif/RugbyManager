namespace RugbyManager
{
    partial class FormSupprimerJoueur
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvJoueurs;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblSupprimerJoueur;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvJoueurs = new DataGridView();
            btnSupprimer = new Button();
            btnRetour = new Button();
            lblSupprimerJoueur = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).BeginInit();
            SuspendLayout();
            // 
            // dgvJoueurs
            // 
            dgvJoueurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJoueurs.Location = new Point(115, 99);
            dgvJoueurs.Name = "dgvJoueurs";
            dgvJoueurs.Size = new Size(511, 150);
            dgvJoueurs.TabIndex = 0;
            dgvJoueurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJoueurs.MultiSelect = false;
            dgvJoueurs.ReadOnly = true;
            dgvJoueurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(115, 331);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(125, 35);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(499, 331);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(127, 35);
            btnRetour.TabIndex = 2;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // lblSupprimerJoueur
            // 
            lblSupprimerJoueur.AutoSize = true;
            lblSupprimerJoueur.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupprimerJoueur.Location = new Point(264, 26);
            lblSupprimerJoueur.Name = "lblSupprimerJoueur";
            lblSupprimerJoueur.Size = new Size(224, 30);
            lblSupprimerJoueur.TabIndex = 3;
            lblSupprimerJoueur.Text = "Supprimer un joueur";
            // 
            // FormSupprimerJoueur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSupprimerJoueur);
            Controls.Add(btnRetour);
            Controls.Add(btnSupprimer);
            Controls.Add(dgvJoueurs);
            Name = "FormSupprimerJoueur";
            Text = "Supprimer un joueur";
            Load += FormSupprimerJoueur_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}