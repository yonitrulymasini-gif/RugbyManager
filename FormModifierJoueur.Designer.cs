namespace RugbyManager
{
    partial class FormModifierJoueur
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
            lblJoueur = new Label();
            lblEquipe = new Label();
            lblVitesse = new Label();
            lblEndurance = new Label();
            lblForce = new Label();
            lblTechnique = new Label();
            lblPoste = new Label();
            cmbJoueurs = new ComboBox();
            cmbPoste = new ComboBox();
            cmbEquipe = new ComboBox();
            nudVitesse = new NumericUpDown();
            nudEndurance = new NumericUpDown();
            nudForce = new NumericUpDown();
            nudTechnique = new NumericUpDown();
            lblModifierJoueur = new Label();
            btnValider = new Button();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)nudVitesse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndurance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudForce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTechnique).BeginInit();
            SuspendLayout();
            // 
            // lblJoueur
            // 
            lblJoueur.AutoSize = true;
            lblJoueur.Location = new Point(48, 38);
            lblJoueur.Name = "lblJoueur";
            lblJoueur.Size = new Size(42, 15);
            lblJoueur.TabIndex = 0;
            lblJoueur.Text = "Joueur";
            // 
            // lblEquipe
            // 
            lblEquipe.AutoSize = true;
            lblEquipe.Location = new Point(48, 128);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(46, 15);
            lblEquipe.TabIndex = 1;
            lblEquipe.Text = "Équipe ";
            // 
            // lblVitesse
            // 
            lblVitesse.AutoSize = true;
            lblVitesse.Location = new Point(48, 174);
            lblVitesse.Name = "lblVitesse";
            lblVitesse.Size = new Size(43, 15);
            lblVitesse.TabIndex = 2;
            lblVitesse.Text = "Vitesse";
            // 
            // lblEndurance
            // 
            lblEndurance.AutoSize = true;
            lblEndurance.Location = new Point(48, 265);
            lblEndurance.Name = "lblEndurance";
            lblEndurance.Size = new Size(63, 15);
            lblEndurance.TabIndex = 3;
            lblEndurance.Text = "Endurance";
            // 
            // lblForce
            // 
            lblForce.AutoSize = true;
            lblForce.Location = new Point(48, 224);
            lblForce.Name = "lblForce";
            lblForce.Size = new Size(36, 15);
            lblForce.TabIndex = 4;
            lblForce.Text = "Force";
            // 
            // lblTechnique
            // 
            lblTechnique.AutoSize = true;
            lblTechnique.Location = new Point(48, 306);
            lblTechnique.Name = "lblTechnique";
            lblTechnique.Size = new Size(62, 15);
            lblTechnique.TabIndex = 5;
            lblTechnique.Text = "Technique";
            // 
            // lblPoste
            // 
            lblPoste.AutoSize = true;
            lblPoste.Location = new Point(48, 87);
            lblPoste.Name = "lblPoste";
            lblPoste.Size = new Size(39, 15);
            lblPoste.TabIndex = 6;
            lblPoste.Text = "Poste ";
            // 
            // cmbJoueurs
            // 
            cmbJoueurs.FormattingEnabled = true;
            cmbJoueurs.Location = new Point(218, 38);
            cmbJoueurs.Name = "cmbJoueurs";
            cmbJoueurs.Size = new Size(121, 23);
            cmbJoueurs.TabIndex = 7;
            cmbJoueurs.SelectedIndexChanged += cmbJoueurs_SelectedIndexChanged;
            // 
            // cmbPoste
            // 
            cmbPoste.FormattingEnabled = true;
            cmbPoste.Location = new Point(218, 87);
            cmbPoste.Name = "cmbPoste";
            cmbPoste.Size = new Size(121, 23);
            cmbPoste.TabIndex = 8;
            // 
            // cmbEquipe
            // 
            cmbEquipe.FormattingEnabled = true;
            cmbEquipe.Location = new Point(218, 128);
            cmbEquipe.Name = "cmbEquipe";
            cmbEquipe.Size = new Size(121, 23);
            cmbEquipe.TabIndex = 9;
            // 
            // nudVitesse
            // 
            nudVitesse.Location = new Point(219, 174);
            nudVitesse.Name = "nudVitesse";
            nudVitesse.Size = new Size(120, 23);
            nudVitesse.TabIndex = 10;
            // 
            // nudEndurance
            // 
            nudEndurance.Location = new Point(218, 265);
            nudEndurance.Name = "nudEndurance";
            nudEndurance.Size = new Size(121, 23);
            nudEndurance.TabIndex = 11;
            // 
            // nudForce
            // 
            nudForce.Location = new Point(218, 222);
            nudForce.Name = "nudForce";
            nudForce.Size = new Size(121, 23);
            nudForce.TabIndex = 12;
            // 
            // nudTechnique
            // 
            nudTechnique.Location = new Point(218, 306);
            nudTechnique.Name = "nudTechnique";
            nudTechnique.Size = new Size(121, 23);
            nudTechnique.TabIndex = 13;
            // 
            // lblModifierJoueur
            // 
            lblModifierJoueur.AutoSize = true;
            lblModifierJoueur.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModifierJoueur.Location = new Point(375, 83);
            lblModifierJoueur.Name = "lblModifierJoueur";
            lblModifierJoueur.Size = new Size(413, 60);
            lblModifierJoueur.TabIndex = 16;
            lblModifierJoueur.Text = "MODIFIER UN JOUEUR";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(403, 265);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(119, 31);
            btnValider.TabIndex = 18;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(597, 265);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(119, 31);
            btnRetour.TabIndex = 19;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormModifierJoueur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetour);
            Controls.Add(btnValider);
            Controls.Add(lblModifierJoueur);
            Controls.Add(nudTechnique);
            Controls.Add(nudForce);
            Controls.Add(nudEndurance);
            Controls.Add(nudVitesse);
            Controls.Add(cmbEquipe);
            Controls.Add(cmbPoste);
            Controls.Add(cmbJoueurs);
            Controls.Add(lblPoste);
            Controls.Add(lblTechnique);
            Controls.Add(lblForce);
            Controls.Add(lblEndurance);
            Controls.Add(lblVitesse);
            Controls.Add(lblEquipe);
            Controls.Add(lblJoueur);
            Name = "FormModifierJoueur";
            Text = "FormModifierJoueur";
            Load += FormModifierJoueur_Load;
            ((System.ComponentModel.ISupportInitialize)nudVitesse).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndurance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudForce).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTechnique).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJoueur;
        private Label lblEquipe;
        private Label lblVitesse;
        private Label lblEndurance;
        private Label lblForce;
        private Label lblTechnique;
        private Label lblPoste;
        private ComboBox cmbJoueurs;
        private ComboBox cmbPoste;
        private ComboBox cmbEquipe;
        private NumericUpDown nudVitesse;
        private NumericUpDown nudEndurance;
        private NumericUpDown nudForce;
        private NumericUpDown numericUpDown2;
        private NumericUpDown nudTechnique;
        private Label lblModifierJoueur;
        private Button btnValider;
        private Button btnRetour;
    }
}