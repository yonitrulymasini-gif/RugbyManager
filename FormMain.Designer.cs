namespace RugbyManager
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAjouterJoueur = new Button();
            btnModifierJoueur = new Button();
            btnSupprimerJoueur = new Button();
            btnGererEquipes = new Button();
            lblTitre = new Label();
            btnMiseAJourBlessures = new Button();
            btnSimulerMatch = new Button();
            btnQuitter = new Button();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiButton1 = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // btnAjouterJoueur
            // 
            btnAjouterJoueur.FlatStyle = FlatStyle.Flat;
            btnAjouterJoueur.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjouterJoueur.Location = new Point(737, 364);
            btnAjouterJoueur.Margin = new Padding(3, 4, 3, 4);
            btnAjouterJoueur.Name = "btnAjouterJoueur";
            btnAjouterJoueur.Size = new Size(224, 88);
            btnAjouterJoueur.TabIndex = 1;
            btnAjouterJoueur.Text = "Ajouter un joueur";
            btnAjouterJoueur.UseVisualStyleBackColor = true;
            btnAjouterJoueur.Click += btnAjouterJoueur_Click;
            // 
            // btnModifierJoueur
            // 
            btnModifierJoueur.FlatStyle = FlatStyle.Flat;
            btnModifierJoueur.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifierJoueur.Location = new Point(482, 585);
            btnModifierJoueur.Margin = new Padding(3, 4, 3, 4);
            btnModifierJoueur.Name = "btnModifierJoueur";
            btnModifierJoueur.Size = new Size(222, 88);
            btnModifierJoueur.TabIndex = 2;
            btnModifierJoueur.Text = "Modifier un joueur";
            btnModifierJoueur.UseVisualStyleBackColor = true;
            btnModifierJoueur.Click += btnModifierJoueur_Click;
            // 
            // btnSupprimerJoueur
            // 
            btnSupprimerJoueur.FlatStyle = FlatStyle.Flat;
            btnSupprimerJoueur.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimerJoueur.Location = new Point(492, 478);
            btnSupprimerJoueur.Margin = new Padding(3, 4, 3, 4);
            btnSupprimerJoueur.Name = "btnSupprimerJoueur";
            btnSupprimerJoueur.Size = new Size(237, 91);
            btnSupprimerJoueur.TabIndex = 3;
            btnSupprimerJoueur.Text = "Supprimer un joueur";
            btnSupprimerJoueur.UseVisualStyleBackColor = true;
            btnSupprimerJoueur.Click += btnSupprimerJoueur_Click;
            // 
            // btnGererEquipes
            // 
            btnGererEquipes.FlatStyle = FlatStyle.Flat;
            btnGererEquipes.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGererEquipes.Location = new Point(759, 490);
            btnGererEquipes.Margin = new Padding(3, 4, 3, 4);
            btnGererEquipes.Name = "btnGererEquipes";
            btnGererEquipes.Size = new Size(224, 79);
            btnGererEquipes.TabIndex = 4;
            btnGererEquipes.Text = "Gérer équipes";
            btnGererEquipes.UseVisualStyleBackColor = true;
            btnGererEquipes.Click += btnGererEquipes_Click;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(652, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(675, 107);
            lblTitre.TabIndex = 5;
            lblTitre.Text = "VALORANT MANAGER";
            // 
            // btnMiseAJourBlessures
            // 
            btnMiseAJourBlessures.FlatStyle = FlatStyle.Flat;
            btnMiseAJourBlessures.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMiseAJourBlessures.Location = new Point(759, 591);
            btnMiseAJourBlessures.Margin = new Padding(3, 4, 3, 4);
            btnMiseAJourBlessures.Name = "btnMiseAJourBlessures";
            btnMiseAJourBlessures.Size = new Size(224, 77);
            btnMiseAJourBlessures.TabIndex = 6;
            btnMiseAJourBlessures.Text = "Mise à jour blessures";
            btnMiseAJourBlessures.UseVisualStyleBackColor = true;
            btnMiseAJourBlessures.Click += btnMiseAJourBlessures_Click;
            // 
            // btnSimulerMatch
            // 
            btnSimulerMatch.FlatStyle = FlatStyle.Flat;
            btnSimulerMatch.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimulerMatch.Location = new Point(1026, 478);
            btnSimulerMatch.Margin = new Padding(3, 4, 3, 4);
            btnSimulerMatch.Name = "btnSimulerMatch";
            btnSimulerMatch.Size = new Size(222, 91);
            btnSimulerMatch.TabIndex = 7;
            btnSimulerMatch.Text = "Simuler match COMPLET";
            btnSimulerMatch.UseVisualStyleBackColor = true;
            btnSimulerMatch.Click += btnSimulerMatch_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitter.ForeColor = SystemColors.ControlText;
            btnQuitter.Location = new Point(1024, 589);
            btnQuitter.Margin = new Padding(3, 4, 3, 4);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(224, 79);
            btnQuitter.TabIndex = 8;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // uiAvatar1
            // 
            uiAvatar1.FillColor = Color.Black;
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.ForeColor = Color.White;
            uiAvatar1.Location = new Point(582, 23);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(75, 75);
            uiAvatar1.TabIndex = 9;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiButton1
            // 
            uiButton1.BackColor = SystemColors.ControlLight;
            uiButton1.FillColor = Color.White;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton1.ForeColor = Color.Black;
            uiButton1.Location = new Point(815, 119);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(293, 64);
            uiButton1.TabIndex = 10;
            uiButton1.Text = "Afficher les joueurs";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(uiButton1);
            Controls.Add(uiAvatar1);
            Controls.Add(btnQuitter);
            Controls.Add(btnSimulerMatch);
            Controls.Add(btnMiseAJourBlessures);
            Controls.Add(lblTitre);
            Controls.Add(btnGererEquipes);
            Controls.Add(btnSupprimerJoueur);
            Controls.Add(btnModifierJoueur);
            Controls.Add(btnAjouterJoueur);
            ForeColor = SystemColors.ControlText;
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button siticoneActivityButton1;
        private Button btnAjouterJoueur;
        private Button btnModifierJoueur;
        private Button btnSupprimerJoueur;
        private Button btnGererEquipes;
        private Label lblTitre;
        private Button btnMiseAJourBlessures;
        private Button btnSimulerMatch;
        private Button btnQuitter;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIButton uiButton1;
    }
}
