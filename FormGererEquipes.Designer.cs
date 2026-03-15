namespace RugbyManager
{
    partial class FormGererEquipes
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
            dgvEquipes = new DataGridView();
            txtNomEquipe = new TextBox();
            btnAjouter = new Button();
            lblNouvelleEquipe = new Label();
            btnSupprimer = new Button();
            btnRetour = new Button();
            lblGérerEquipe = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipes
            // 
            dgvEquipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipes.Location = new Point(12, 32);
            dgvEquipes.Name = "dgvEquipes";
            dgvEquipes.Size = new Size(354, 213);
            dgvEquipes.TabIndex = 0;
            // 
            // txtNomEquipe
            // 
            txtNomEquipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomEquipe.Location = new Point(416, 299);
            txtNomEquipe.Name = "txtNomEquipe";
            txtNomEquipe.Size = new Size(155, 29);
            txtNomEquipe.TabIndex = 1;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(107, 376);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(110, 34);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // lblNouvelleEquipe
            // 
            lblNouvelleEquipe.AutoSize = true;
            lblNouvelleEquipe.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNouvelleEquipe.Location = new Point(166, 299);
            lblNouvelleEquipe.Name = "lblNouvelleEquipe";
            lblNouvelleEquipe.Size = new Size(164, 30);
            lblNouvelleEquipe.TabIndex = 5;
            lblNouvelleEquipe.Text = "Nouvelle équipe";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(330, 376);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(110, 34);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetour.Location = new Point(553, 376);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(110, 34);
            btnRetour.TabIndex = 7;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // lblGérerEquipe
            // 
            lblGérerEquipe.AutoSize = true;
            lblGérerEquipe.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGérerEquipe.Location = new Point(401, 106);
            lblGérerEquipe.Name = "lblGérerEquipe";
            lblGérerEquipe.Size = new Size(377, 60);
            lblGérerEquipe.TabIndex = 8;
            lblGérerEquipe.Text = "GÉRER LES ÉQUIPES";
            // 
            // FormGererEquipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGérerEquipe);
            Controls.Add(btnRetour);
            Controls.Add(btnSupprimer);
            Controls.Add(lblNouvelleEquipe);
            Controls.Add(btnAjouter);
            Controls.Add(txtNomEquipe);
            Controls.Add(dgvEquipes);
            Name = "FormGererEquipes";
            Text = "FormGererEquipes";
            Load += FormGererEquipes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEquipes;
        private TextBox txtNomEquipe;
        private Button btnAjouter;
        private Label lblNouvelleEquipe;
        private Button btnSupprimer;
        private Button btnRetour;
        private Label lblGérerEquipe;
    }
}