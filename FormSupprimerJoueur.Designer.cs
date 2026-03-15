namespace RugbyManager
{
    partial class FormSupprimerJoueur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSupprimerJoueur = new Label();
            dgvJoueurs = new DataGridView();
            btnSupprimer = new Button();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).BeginInit();
            SuspendLayout();
            // 
            // lblSupprimerJoueur
            // 
            lblSupprimerJoueur.AutoSize = true;
            lblSupprimerJoueur.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupprimerJoueur.Location = new Point(473, 147);
            lblSupprimerJoueur.Name = "lblSupprimerJoueur";
            lblSupprimerJoueur.Size = new Size(351, 45);
            lblSupprimerJoueur.TabIndex = 0;
            lblSupprimerJoueur.Text = "SUPPRIMER UN JOUEUR";
            // 
            // dgvJoueurs
            // 
            dgvJoueurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJoueurs.Location = new Point(12, 79);
            dgvJoueurs.Name = "dgvJoueurs";
            dgvJoueurs.Size = new Size(441, 385);
            dgvJoueurs.TabIndex = 1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(473, 290);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(123, 34);
            btnSupprimer.TabIndex = 7;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetour.Location = new Point(692, 290);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(132, 34);
            btnRetour.TabIndex = 8;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormSupprimerJoueur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 502);
            Controls.Add(btnRetour);
            Controls.Add(btnSupprimer);
            Controls.Add(dgvJoueurs);
            Controls.Add(lblSupprimerJoueur);
            Name = "FormSupprimerJoueur";
            Text = "FormSupprimerJoueur";
            Load += FormSupprimerJoueur_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSupprimerJoueur;
        private DataGridView dgvJoueurs;
        private Button btnSupprimer;
        private Button btnRetour;
    }
}