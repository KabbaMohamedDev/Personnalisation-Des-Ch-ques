using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace personnalisation_chequiers
{
    public partial class transfert_de_fichier_TXT_vers_BDD : Form
    {
        public transfert_de_fichier_TXT_vers_BDD()
        {
            InitializeComponent();
        }



        static SqlConnection cn = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand("select * from Client", cn);
        DataSet ds = new DataSet();
        DataTable dt;
        

        private void btnparcourir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void transfert_de_fichier_TXT_vers_BDD_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Client", cn);
            da.Fill(ds, "Client");
            dt = ds.Tables["Client"];

        }

        private void btngenerer_Click(object sender, EventArgs e)
        {
            
            //generer un ficher text de puis une base de donnes : vers le dossier archivage :
            StreamWriter sw = new StreamWriter("C:\\Archive\\texte.txt");

            foreach (DataRow dr in dt.Rows)
            {
                string ligne;
                ligne = dr[0] + "  " + dr[1] + "  " + dr[2] + "  " + dr[3] + "  " + dr[4] + "  " + dr[5] + "  " + dr[6];
              
            }
            MessageBox.Show("Fichier Généré avec succès");
            sw.Close(); 
        }

        private void btnprecedent_Click(object sender, EventArgs e)
        {
            Creation_d_un_Fichier_Texte f = new Creation_d_un_Fichier_Texte();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EPOSTCHECKPRO f = new EPOSTCHECKPRO();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            EPOSTCHECKPRO__Menu_Principal f = new EPOSTCHECKPRO__Menu_Principal();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void btncreationdossierarchive_Click(object sender, EventArgs e)
        {
            bool existe = false;

            DirectoryInfo dir = new DirectoryInfo("C:\\Archive");
            dir.CreateSubdirectory("sub");

            if (!existe)
            {
                MessageBox.Show("Le Dossier est Créer!!");

            }
        }

        private void btncréerdossier_Click(object sender, EventArgs e)
        {
            bool existe = false;

            DirectoryInfo dir = new DirectoryInfo("C:\\Archive");
            dir.CreateSubdirectory("sub");

            if (!existe)
            {
                MessageBox.Show("Le Dossier est Créer!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnimporter_Click(object sender, EventArgs e)
        {
            
            try {

             
              int i = 0;
              foreach (string line in File.ReadAllLines("C:\\Répertoire\\texte.txt"))
              {

                  //    string[] parts = line.Split(' ');

                  string[] parts = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                  // foreach (string part in parts)
                  //{
                  //    Console.WriteLine("{0}", part);


                  cn.Open();
                  cmd.Connection = cn;
                  cmd.CommandType = CommandType.Text;

                  cmd.CommandText = "insert into Client (Id_Client,Nom_Client,Libellé_Client,Gestion_Numéro,urgent_position,urgent_longueur,urgent_valeur)values(@Id_Client,@Nom_Client,@Libellé_Client,@Gestion_Numéro,@urgent_position,@urgent_longueur,@urgent_valeur)";
                  List<string> a = new List<String>();
                  a.Add("@Id_Client");
                  a.Add("@Nom_Client");
                  a.Add("@Libellé_Client");
                  a.Add("@Gestion_Numéro");
                  a.Add("@urgent_position");
                  a.Add("@urgent_longueur");
                  a.Add("@urgent_valeur");
                  i = 0;
                  foreach (string m in a)
                  {
                      cmd.Parameters.AddWithValue(a.ElementAt(i), parts[i]);
                      i++;
                  }
                  cmd.ExecuteNonQuery();
                  cn.Close();


                  //  }
                  i++;

              }

            }


                catch {

                      }
         
        
        }
             

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
           



        }
    }
    