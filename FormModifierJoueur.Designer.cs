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
            cmbJoueurs = new ComboBox();
            cmbPoste = new ComboBox();
            cmbEquipe = new ComboBox();
            nudVitesse = new NumericUpDown();
            nudEndurance = new NumericUpDown();
            nudForce = new NumericUpDown();
            nudTechnique = new NumericUpDown();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            uiLedLabel7 = new Sunny.UI.UILedLabel();
            uiLedLabel6 = new Sunny.UI.UILedLabel();
            uiLedLabel5 = new Sunny.UI.UILedLabel();
            uiLedLabel4 = new Sunny.UI.UILedLabel();
            uiLedLabel3 = new Sunny.UI.UILedLabel();
            uiLedLabel2 = new Sunny.UI.UILedLabel();
            uiLedLabel1 = new Sunny.UI.UILedLabel();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton6 = new Sunny.UI.UIButton();
            uiIntegerUpDown1 = new Sunny.UI.UIIntegerUpDown();
            ((System.ComponentModel.ISupportInitialize)nudVitesse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndurance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudForce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTechnique).BeginInit();
            SuspendLayout();
            // 
            // cmbJoueurs
            // 
            cmbJoueurs.FormattingEnabled = true;
            cmbJoueurs.Location = new Point(1139, 219);
            cmbJoueurs.Margin = new Padding(3, 4, 3, 4);
            cmbJoueurs.Name = "cmbJoueurs";
            cmbJoueurs.Size = new Size(138, 28);
            cmbJoueurs.TabIndex = 7;
            cmbJoueurs.SelectedIndexChanged += cmbJoueurs_SelectedIndexChanged;
            // 
            // cmbPoste
            // 
            cmbPoste.FormattingEnabled = true;
            cmbPoste.Location = new Point(1139, 284);
            cmbPoste.Margin = new Padding(3, 4, 3, 4);
            cmbPoste.Name = "cmbPoste";
            cmbPoste.Size = new Size(138, 28);
            cmbPoste.TabIndex = 8;
            // 
            // cmbEquipe
            // 
            cmbEquipe.FormattingEnabled = true;
            cmbEquipe.Location = new Point(1139, 339);
            cmbEquipe.Margin = new Padding(3, 4, 3, 4);
            cmbEquipe.Name = "cmbEquipe";
            cmbEquipe.Size = new Size(138, 28);
            cmbEquipe.TabIndex = 9;
            // 
            // nudVitesse
            // 
            nudVitesse.Location = new Point(1140, 400);
            nudVitesse.Margin = new Padding(3, 4, 3, 4);
            nudVitesse.Name = "nudVitesse";
            nudVitesse.Size = new Size(137, 27);
            nudVitesse.TabIndex = 10;
            // 
            // nudEndurance
            // 
            nudEndurance.Location = new Point(1139, 521);
            nudEndurance.Margin = new Padding(3, 4, 3, 4);
            nudEndurance.Name = "nudEndurance";
            nudEndurance.Size = new Size(138, 27);
            nudEndurance.TabIndex = 11;
            // 
            // nudForce
            // 
            nudForce.Location = new Point(1139, 464);
            nudForce.Margin = new Padding(3, 4, 3, 4);
            nudForce.Name = "nudForce";
            nudForce.Size = new Size(138, 27);
            nudForce.TabIndex = 12;
            // 
            // nudTechnique
            // 
            nudTechnique.Location = new Point(1139, 576);
            nudTechnique.Margin = new Padding(3, 4, 3, 4);
            nudTechnique.Name = "nudTechnique";
            nudTechnique.Size = new Size(138, 27);
            nudTechnique.TabIndex = 13;
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiSmoothLabel1.Location = new Point(544, 35);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.RectSize = 15;
            uiSmoothLabel1.Size = new Size(621, 125);
            uiSmoothLabel1.TabIndex = 24;
            uiSmoothLabel1.Text = "MODIFIER";
            // 
            // uiLedLabel7
            // 
            uiLedLabel7.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel7.Location = new Point(561, 569);
            uiLedLabel7.MinimumSize = new Size(1, 1);
            uiLedLabel7.Name = "uiLedLabel7";
            uiLedLabel7.Size = new Size(215, 44);
            uiLedLabel7.TabIndex = 45;
            uiLedLabel7.Text = "TECHNIQUE : ";
            // 
            // uiLedLabel6
            // 
            uiLedLabel6.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel6.Location = new Point(630, 517);
            uiLedLabel6.MinimumSize = new Size(1, 1);
            uiLedLabel6.Name = "uiLedLabel6";
            uiLedLabel6.Size = new Size(151, 44);
            uiLedLabel6.TabIndex = 44;
            uiLedLabel6.Text = "FORCE : ";
            // 
            // uiLedLabel5
            // 
            uiLedLabel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel5.Location = new Point(555, 467);
            uiLedLabel5.MinimumSize = new Size(1, 1);
            uiLedLabel5.Name = "uiLedLabel5";
            uiLedLabel5.Size = new Size(209, 44);
            uiLedLabel5.TabIndex = 43;
            uiLedLabel5.Text = "ENDURANCE :";
            // 
            // uiLedLabel4
            // 
            uiLedLabel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel4.Location = new Point(595, 416);
            uiLedLabel4.MinimumSize = new Size(1, 1);
            uiLedLabel4.Name = "uiLedLabel4";
            uiLedLabel4.Size = new Size(187, 44);
            uiLedLabel4.TabIndex = 42;
            uiLedLabel4.Text = "VITESSE : ";
            // 
            // uiLedLabel3
            // 
            uiLedLabel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel3.Location = new Point(620, 364);
            uiLedLabel3.MinimumSize = new Size(1, 1);
            uiLedLabel3.Name = "uiLedLabel3";
            uiLedLabel3.Size = new Size(162, 44);
            uiLedLabel3.TabIndex = 41;
            uiLedLabel3.Text = "EQUIPE : ";
            // 
            // uiLedLabel2
            // 
            uiLedLabel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel2.Location = new Point(639, 307);
            uiLedLabel2.MinimumSize = new Size(1, 1);
            uiLedLabel2.Name = "uiLedLabel2";
            uiLedLabel2.Size = new Size(125, 44);
            uiLedLabel2.TabIndex = 40;
            uiLedLabel2.Text = "POSTE :";
            // 
            // uiLedLabel1
            // 
            uiLedLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel1.Location = new Point(657, 257);
            uiLedLabel1.MinimumSize = new Size(1, 1);
            uiLedLabel1.Name = "uiLedLabel1";
            uiLedLabel1.Size = new Size(125, 44);
            uiLedLabel1.TabIndex = 39;
            uiLedLabel1.Text = "NOM :";
            // 
            // uiButton1
            // 
            uiButton1.BackColor = SystemColors.ControlLight;
            uiButton1.FillColor = Color.White;
            uiButton1.FillColor2 = Color.White;
            uiButton1.FillHoverColor = Color.DodgerBlue;
            uiButton1.FillPressColor = Color.White;
            uiButton1.FillSelectedColor = Color.White;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton1.ForeColor = Color.Black;
            uiButton1.Location = new Point(657, 708);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.White;
            uiButton1.RectHoverColor = Color.FromArgb(224, 224, 224);
            uiButton1.RectPressColor = Color.White;
            uiButton1.RectSelectedColor = Color.White;
            uiButton1.Size = new Size(293, 64);
            uiButton1.TabIndex = 47;
            uiButton1.Text = "VALIDER";
            uiButton1.TipsColor = Color.White;
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiButton6
            // 
            uiButton6.BackColor = SystemColors.ControlLight;
            uiButton6.FillColor = Color.White;
            uiButton6.FillColor2 = Color.White;
            uiButton6.FillHoverColor = Color.DodgerBlue;
            uiButton6.FillPressColor = Color.White;
            uiButton6.FillSelectedColor = Color.White;
            uiButton6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton6.ForeColor = Color.Black;
            uiButton6.Location = new Point(657, 794);
            uiButton6.MinimumSize = new Size(1, 1);
            uiButton6.Name = "uiButton6";
            uiButton6.RectColor = Color.White;
            uiButton6.RectHoverColor = Color.FromArgb(224, 224, 224);
            uiButton6.RectPressColor = Color.White;
            uiButton6.RectSelectedColor = Color.White;
            uiButton6.Size = new Size(293, 64);
            uiButton6.TabIndex = 46;
            uiButton6.Text = "RETOUR";
            uiButton6.TipsColor = Color.White;
            uiButton6.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton6.Click += uiButton6_Click;
            // 
            // uiIntegerUpDown1
            // 
            uiIntegerUpDown1.Font = new Font("Microsoft Sans Serif", 12F);
            uiIntegerUpDown1.Location = new Point(885, 326);
            uiIntegerUpDown1.Margin = new Padding(4, 5, 4, 5);
            uiIntegerUpDown1.MinimumSize = new Size(1, 16);
            uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            uiIntegerUpDown1.Padding = new Padding(5);
            uiIntegerUpDown1.ShowText = false;
            uiIntegerUpDown1.Size = new Size(188, 36);
            uiIntegerUpDown1.TabIndex = 48;
            uiIntegerUpDown1.Text = "0";
            uiIntegerUpDown1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormModifierJoueur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(uiIntegerUpDown1);
            Controls.Add(uiButton1);
            Controls.Add(uiButton6);
            Controls.Add(uiLedLabel7);
            Controls.Add(uiLedLabel6);
            Controls.Add(uiLedLabel5);
            Controls.Add(uiLedLabel4);
            Controls.Add(uiLedLabel3);
            Controls.Add(uiLedLabel2);
            Controls.Add(uiLedLabel1);
            Controls.Add(uiSmoothLabel1);
            Controls.Add(nudTechnique);
            Controls.Add(nudForce);
            Controls.Add(nudEndurance);
            Controls.Add(nudVitesse);
            Controls.Add(cmbEquipe);
            Controls.Add(cmbPoste);
            Controls.Add(cmbJoueurs);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModifierJoueur";
            Text = "FormModifierJoueur";
            Load += FormModifierJoueur_Load;
            ((System.ComponentModel.ISupportInitialize)nudVitesse).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndurance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudForce).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTechnique).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbJoueurs;
        private ComboBox cmbPoste;
        private ComboBox cmbEquipe;
        private NumericUpDown nudVitesse;
        private NumericUpDown nudEndurance;
        private NumericUpDown nudForce;
        private NumericUpDown numericUpDown2;
        private NumericUpDown nudTechnique;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UILedLabel uiLedLabel7;
        private Sunny.UI.UILedLabel uiLedLabel6;
        private Sunny.UI.UILedLabel uiLedLabel5;
        private Sunny.UI.UILedLabel uiLedLabel4;
        private Sunny.UI.UILedLabel uiLedLabel3;
        private Sunny.UI.UILedLabel uiLedLabel2;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown1;
    }
}