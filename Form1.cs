using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RugbyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            FormAccueil accueil = new FormAccueil();
            accueil.Show();
            this.Hide();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void uiButton4_Click(object sender, EventArgs e)
        {

        }
        private void uiSmoothLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
