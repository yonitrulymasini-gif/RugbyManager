namespace RugbyManager
{
    partial class SimulerMatch
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
            label1 = new Label();
            dgvJoueurs = new DataGridView();
            lblAdversaire = new Label();
            txtAdversaire = new TextBox();
            btnRetour = new Button();
            btnSimuler = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 60);
            label1.TabIndex = 0;
            label1.Text = "SIMULER UN MATCH";
            // 
            // dgvJoueurs
            // 
            dgvJoueurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJoueurs.Location = new Point(55, 129);
            dgvJoueurs.Name = "dgvJoueurs";
            dgvJoueurs.Size = new Size(708, 150);
            dgvJoueurs.TabIndex = 1;
            // 
            // lblAdversaire
            // 
            lblAdversaire.AutoSize = true;
            lblAdversaire.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdversaire.Location = new Point(120, 365);
            lblAdversaire.Name = "lblAdversaire";
            lblAdversaire.Size = new Size(110, 30);
            lblAdversaire.TabIndex = 2;
            lblAdversaire.Text = "Adversaire";
            lblAdversaire.Click += lblAdversaire_Click;
            // 
            // txtAdversaire
            // 
            txtAdversaire.Location = new Point(290, 365);
            txtAdversaire.Name = "txtAdversaire";
            txtAdversaire.Size = new Size(181, 23);
            txtAdversaire.TabIndex = 3;
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetour.Location = new Point(607, 409);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(110, 34);
            btnRetour.TabIndex = 9;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnSimuler
            // 
            btnSimuler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimuler.Location = new Point(607, 329);
            btnSimuler.Name = "btnSimuler";
            btnSimuler.Size = new Size(110, 34);
            btnSimuler.TabIndex = 10;
            btnSimuler.Text = "Simuler";
            btnSimuler.UseVisualStyleBackColor = true;
            btnSimuler.Click += btnSimuler_Click;
            // 
            // SimulerMatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(btnSimuler);
            Controls.Add(btnRetour);
            Controls.Add(txtAdversaire);
            Controls.Add(lblAdversaire);
            Controls.Add(dgvJoueurs);
            Controls.Add(label1);
            Name = "SimulerMatch";
            Text = "SimulerMatch";
            Load += SimulerMatch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvJoueurs;
        private Label lblAdversaire;
        private TextBox txtAdversaire;
        private Button btnRetour;
        private Button btnSimuler;
    }
}