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
using System.Data.Common;

namespace personnalisation_chequiers
{
    public partial class Compte : Form
    {
        public Compte()
        {
            InitializeComponent();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //Ajouter:
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs Vide!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    D.cn = D.pf.CreateConnection();
                    D.cn.ConnectionString = "Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True";
                    D.cn.Open();
                    DbCommand cmd = D.pf.CreateCommand();
                    cmd.Connection = D.cn;
                    cmd.CommandText = "INSERT INTO compte(Pseudo,password)values('" + textBox1.Text + "','" + textBox2.Text + "')";
                    cmd.ExecuteNonQuery();
                    D.cn.Close();
                    MessageBox.Show("Creation effectué avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            //--- supprimer-------
            if (textBox1.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Le Nom D'Utilisateur!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    D.cn = D.pf.CreateConnection();
                    D.cn.ConnectionString = "Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True";
                    D.cn.Open();
                    DbCommand cmd = D.pf.CreateCommand();
                    cmd.Connection = D.cn;
                    cmd.CommandText = "delete compte where Pseudo ='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    D.cn.Close();
                    MessageBox.Show("SUPRESION effectué avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EPOSTCHECKPRO f = new EPOSTCHECKPRO();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void Compte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs Vide!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

               
                    D.cn = D.pf.CreateConnection();
                    D.cn.ConnectionString = "Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True";
                    D.cn.Open();
                    DbCommand cmd = D.pf.CreateCommand();
                    cmd.Connection = D.cn;
                    // cmd.CommandText = "update Client set Nom_Client ='" + textBox2.Text + "', Libellé_Client='" + textBox3.Text + "', Gestion_Numéro='" + textBox4.Text + "', urgent_position='" + Convert.ToInt16(textBox5.Text) + "', urgent_longueur='" + Convert.ToInt16(textBox6.Text) + "', urgent_valeur='" + textBox7 + "' where Id_Client=" + Convert.ToInt16(textBox1.Text) + "'";
                    cmd.CommandText = "update compte set password='" + textBox2.Text + "' where Pseudo ='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    D.cn.Close();
                    MessageBox.Show(" La Modification a été effectué avec succès!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                

            }


        }
           
           
          
        }
        }
    
