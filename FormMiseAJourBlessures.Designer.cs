namespace RugbyManager
{
    partial class FormMiseAJourBlessures
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
            lblMajBlessures = new Label();
            btnMiseAJourBlessures = new Button();
            dgvJoueurs = new DataGridView();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).BeginInit();
            SuspendLayout();
            // 
            // lblMajBlessures
            // 
            lblMajBlessures.AutoSize = true;
            lblMajBlessures.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMajBlessures.Location = new Point(611, 141);
            lblMajBlessures.Name = "lblMajBlessures";
            lblMajBlessures.Size = new Size(552, 60);
            lblMajBlessures.TabIndex = 0;
            lblMajBlessures.Text = "MISE À JOUR DES BLESSURES";
            // 
            // btnMiseAJourBlessures
            // 
            btnMiseAJourBlessures.Location = new Point(689, 286);
            btnMiseAJourBlessures.Name = "btnMiseAJourBlessures";
            btnMiseAJourBlessures.Size = new Size(145, 34);
            btnMiseAJourBlessures.TabIndex = 1;
            btnMiseAJourBlessures.Text = "Mettre à jour";
            btnMiseAJourBlessures.UseVisualStyleBackColor = true;
            btnMiseAJourBlessures.Click += btnMajBlessures_Click;
            // 
            // dgvJoueurs
            // 
            dgvJoueurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJoueurs.Location = new Point(12, 49);
            dgvJoueurs.Name = "dgvJoueurs";
            dgvJoueurs.Size = new Size(565, 400);
            dgvJoueurs.TabIndex = 2;
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetour.Location = new Point(947, 284);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(141, 34);
            btnRetour.TabIndex = 10;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormMiseAJourBlessures
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 492);
            Controls.Add(btnRetour);
            Controls.Add(dgvJoueurs);
            Controls.Add(btnMiseAJourBlessures);
            Controls.Add(lblMajBlessures);
            Name = "FormMiseAJourBlessures";
            Text = "FormMiseAJourBlessures";
            Load += FormMiseAJourBlessures_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMajBlessures;
        private Button btnMiseAJourBlessures;
        private DataGridView dgvJoueurs;
        private Button btnRetour;
    }
}