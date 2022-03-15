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

namespace personnalisation_chequiers
{
    public partial class EPOSTCHECKPRO : Form
    {
        public EPOSTCHECKPRO()
        {
            InitializeComponent();
        }
        int togmove;
        int Mvalx;
        int Mvaly;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            togmove = 0;

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            togmove = 1;
            Mvalx = e.X;
            Mvaly = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (togmove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mvalx, MousePosition.Y - Mvaly);

            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            //----login-----//
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Saisir LOGIN et MOT DE PASSE !!!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            try
            {
                //------------------------cree une connextion ------------------------
                SqlConnection con = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True");
                //----------------------------------requet----------------------------------
                SqlCommand cmd = new SqlCommand("select * from compte where Pseudo='" + login + "' and password='" + password + "'", con);
                //---------------------------ouvrir la conextion----------------------------
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("Mr/Mme '" + login + "' "  ,  "Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    Menu f = new Menu();
                    f.Show();
                    this.Hide(); //cacher l'interface.

                }
                else
                {
                    MessageBox.Show("Login Failed!!",  "Message",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //------------------------------------------------------------------------------------------------------------------//
            //------------------------------------------------------------------------------------------------------------------//
            //------------------------------------------------------------------------------------------------------------------//


            /* if (textBox1.Text == "EPOSTCHECKPRO")
             {
                 if (textBox2.Text == "EPOSTCHECKPRO")
                 {
                     Creation_d_un_Fichier_Texte f = new Creation_d_un_Fichier_Texte();
                     f.Show();
                     this.Hide();//pour cacher l'interface.
                 }

                 else
                     label3.Visible = true;
             }

             else
                 label7.Visible = true;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compte f = new Compte();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }
    }
}
