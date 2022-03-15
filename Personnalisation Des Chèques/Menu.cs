using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnalisation_chequiers
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            transfert_de_fichier_TXT_vers_BDD f = new transfert_de_fichier_TXT_vers_BDD();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EPOSTCHECKPRO f = new EPOSTCHECKPRO();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creation_d_un_Fichier_Texte f = new Creation_d_un_Fichier_Texte();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            Client f = new Client();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void btncatégorie_Click(object sender, EventArgs e)
        {
            Catégorie f = new Catégorie();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void btncomposition_Click(object sender, EventArgs e)
        {
            Composition f = new Composition();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void btndescription_Click(object sender, EventArgs e)
        {
            Description f = new Description();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }
    }
}
