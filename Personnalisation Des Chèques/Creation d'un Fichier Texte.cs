using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace personnalisation_chequiers
{
    public partial class Creation_d_un_Fichier_Texte : Form
    {
        public Creation_d_un_Fichier_Texte()
        {
            InitializeComponent();
        }

        private void btncreationfichiertxt_Click(object sender, EventArgs e)
        {
            //Creation Du Fichier Texte Dans Le Dossier Du Projet//

           /* StreamWriter file = new StreamWriter("test.txt");
            file.Write(richTextBox1.Text);
            file.Close();  */
           
            //Creation Du Fichier Texte Dans Le Dossier Répertoire//

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fils = path + @"\Répertoire\texte.txt";

            File.WriteAllText(fils,richTextBox1.Text);

            bool existe = false;
            existe = File.Exists(fils);

            if (!existe)
            {

                File.Create(fils);
                
            }
            else
            {
                MessageBox.Show("Fichier créer");
            }
      
        }

        private void btnouvrirfichiertxt_Click(object sender, EventArgs e)
        {
            Stream Mystream;
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Mystream = open.OpenFile();
                if (Mystream != null)
                {
                    string path = open.FileName;
                    string filetext = File.ReadAllText(path);
                    richTextBox1.Text = filetext;
                }
            }

        }

        private void btneffacer_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btncréerdossier_Click(object sender, EventArgs e)
        {
            bool existe = false;

           DirectoryInfo dir = new DirectoryInfo("C:\\Répertoire");
           dir.CreateSubdirectory("sub");

           if (!existe)
           {
               MessageBox.Show("Le Dossier est Créer!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }


        }

        private void Creation_d_un_Fichier_Texte_Load(object sender, EventArgs e)
        {

        }

        private void btnsuivant_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }
    }
}