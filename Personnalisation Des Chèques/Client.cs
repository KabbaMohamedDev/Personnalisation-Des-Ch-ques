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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        
      DataView dv = new DataView();
      static SqlConnection cn = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True");
      static SqlCommand cmd = new SqlCommand("select * from Client", cn);
      SqlDataAdapter da = new SqlDataAdapter(cmd);
      static DataTable dt = new DataTable();
      DataSet ds = new DataSet();
     SqlDataReader dr;
     // static DataRow dro;
    // public BindingManagerBase dbn;

     

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'personnalisation_des_ChéquiersDataSet1.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.personnalisation_des_ChéquiersDataSet1.Client);
            try
            {
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da.Fill(ds);
                dt = ds.Tables[0];
                dv = dt.DefaultView;
                dataGridView1.DataSource = dt;
            }

            catch
            {
                dataGridView1.Refresh();

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            /*cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Client (Id_Client,Nom_Client,Libellé_Client,Gestion_Numéro,urgent_position,urgent_longueur,urgent_valeur)values('" + Convert.ToInt16(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + Convert.ToInt16(textBox5.Text) + "','" + Convert.ToInt16(textBox6.Text) + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" L'Ajout a été effectué avec succès!!");*/
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs Vide!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Client (Id_Client,Nom_Client,Libellé_Client,Gestion_Numéro,urgent_position,urgent_longueur,urgent_valeur)values('" + Convert.ToInt16(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + Convert.ToInt16(textBox5.Text) + "','" + Convert.ToInt16(textBox6.Text) + "','" + textBox7.Text + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" L'Ajout a été effectué avec succès!!" , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

      /*      DataRowView drv = dv.AddNew();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Veuillez Saisir Id_Client!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                
                drv[0] = Convert.ToInt16(textBox1.Text);
                 }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Veuillez Saisir Nom_Client!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                drv[1] = textBox2.Text;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Veuillez Saisir Libellé_Client!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                drv[2] = textBox3.Text;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Veuillez Saisir Gestion_Numéro!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                drv[3] = textBox4.Text;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Veuillez Saisir urgent_position!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                drv[4] = Convert.ToInt16(textBox5.Text);
            }

            if (textBox6.Text == "")
            {
                MessageBox.Show("Veuillez Saisir urgent_longueur!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                drv[5] = Convert.ToInt16(textBox6.Text);
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("Veuillez Saisir Urgent_valeur!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                drv[6] = textBox7.Text;
            } */
            
   //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
             /*
                DataRowView drv = dv.AddNew();
                drv[0] = Convert.ToInt16(textBox1.Text);
                drv[1] = textBox2.Text;
                drv[2] = textBox3.Text;
                drv[3] = textBox4.Text;
                drv[4] = Convert.ToInt16(textBox5.Text);
                drv[5] = Convert.ToInt16(textBox6.Text);
                drv[6] = textBox7.Text;
              */
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer Ce Client?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    cn.Open();

                    
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Client where Id_Client=" + Convert.ToInt16(textBox1.Text);
                    cmd.ExecuteNonQuery();
                    
      
                    MessageBox.Show("Le Client est Supprimer!" , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string requete2 = "select * from Client";
                    SqlCommand cmd2 = new SqlCommand(requete2, cn);
                    SqlDataReader Dr = cmd2.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(Dr);
                    Dr.Close();
                    dataGridView1.DataSource = t;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cn.Close();


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                /*  dv.Sort = "[Id_Client]";
                  int i = dv.Find(textBox1.Text);
                  DataRowView drv;
                  drv = dv[i];
                  drv.Delete(); */
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                /*      bool tr = false;
                      int i;

                      for (i = 0; i < dt.Rows.Count; i++)
                      {
                          DataRow dr = dt.Rows[i];

                          if (textBox1.Text == "")
                          {
                              MessageBox.Show("Veuillez Saisir Id_Client!!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                          }
             
                              if (dr.RowState != DataRowState.Deleted)
                              {
                                  if (Convert.ToInt16(dt.Rows[i][0]) == Convert.ToInt16(textBox1.Text))
                                  {
                                      tr = true;


                                      dr.Delete();

                                      MessageBox.Show("le Client est supprimer!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                  }
                              }
             
                          }
            

                      if (tr == false)
                      {
                          MessageBox.Show("Aucun Enregistrement!!!" , "Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                      }
                     */
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                /*     if (textBox1.Text == "")
                     {
                         MessageBox.Show("Veuillez Saisir Id_Client!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }

                     else
                     {
                         cn.Open();
                         cmd.Connection = cn;
                         cmd.CommandType = CommandType.Text;
                         cmd.CommandText = "delete from Client where Id_Client=" + Convert.ToInt16(textBox1.Text);
                         cmd.ExecuteNonQuery();
                         cn.Close();
                         textBox1.Clear();
                         MessageBox.Show("le Client est supprimer!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }

                     if (MessageBox.Show("Voulez-vous vraiment supprimer ce Client ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                     {
                         dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                     }
                         */


                /*    if (MessageBox.Show("Voulez-vous vraiment supprimer ce Client ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                     {
                         dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                     } */


            } 
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
        
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listeClient";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
            

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
                Application.Exit();
            
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
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
                    // cmd.CommandText = "update Client set Nom_Client ='" + textBox2.Text + "', Libellé_Client='" + textBox3.Text + "', Gestion_Numéro='" + textBox4.Text + "', urgent_position='" + Convert.ToInt16(textBox5.Text) + "', urgent_longueur='" + Convert.ToInt16(textBox6.Text) + "', urgent_valeur='" + textBox7 + "' where Id_Client=" + Convert.ToInt16(textBox1.Text) + "'";
                    cmd.CommandText = "update Client set Nom_Client='" + textBox2.Text + "',Libellé_Client='" + textBox3.Text + "',Gestion_Numéro='" + textBox4.Text + "',urgent_position='" + Convert.ToInt16(textBox5.Text) + "',urgent_longueur='" + Convert.ToInt16(textBox6.Text) + "',urgent_valeur='" + textBox7.Text + "' where Id_Client ='" + Convert.ToInt16(textBox1.Text) + "'";
                    cmd.ExecuteNonQuery();
                    D.cn.Close();
                    MessageBox.Show(" La Modification a été effectué avec succès!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

       /*     if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs Vide!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                cn.Open();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Client set Nom_Client ='" + textBox2.Text + "', Libellé_Client='" + textBox3.Text + "', Gestion_Numéro='" + textBox4.Text + "', urgent_position='" + Convert.ToInt16(textBox5.Text) + "', urgent_longueur='" + Convert.ToInt16(textBox6.Text) + "', urgent_valeur='" + textBox7 + "' where Id_Client='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("le champ est modifier");
                cn.Close();
            }
            */
            
   /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            
       /*     if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs Vide!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                bool tr = false;
                int i;

                for (i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt16(dt.Rows[i][0]) == Convert.ToInt16(textBox1.Text))
                    {
                        tr = true;
                        dro = dt.Rows[i];
                        dro.BeginEdit();
                        dro[1] = textBox2.Text;
                        dro[2] = textBox3.Text;
                        dro[3] = textBox4.Text;
                        dro[4] = Convert.ToInt16(textBox5.Text);
                        dro[5] = Convert.ToInt16(textBox6.Text);
                        dro[6] = textBox7.Text;
                        dro.EndEdit();
                        MessageBox.Show(dro.RowState.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (tr == false)
                {
                    MessageBox.Show("Ce Num N'exist Pas", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
       /*   dv.Sort = "[Id_Client]";
            int i = dv.Find(Convert.ToInt16(textBox1.Text));
            DataRowView drv;
            drv = dv[i];
            drv.BeginEdit();
            drv[1] = textBox2.Text;
            drv[2] = textBox3.Text;
            drv[3] = textBox4.Text;
            drv[4] = Convert.ToInt16(textBox5.Text);
            drv[5] = Convert.ToInt16(textBox6.Text);
            drv[6] = textBox7.Text;
            drv.EndEdit();  */



             }

        private void btnconsulter_Click(object sender, EventArgs e)
        {


            /* dv.Sort = "[Id_Client]";
             int i = dv.Find(textBox1.Text);
             DataRowView drv;
             drv = dv[i];
             textBox2.Text = drv[1].ToString();
             textBox3.Text = drv[2].ToString();
             textBox4.Text = drv[3].ToString();
             textBox5.Text = drv[4].ToString();
             textBox6.Text = drv[5].ToString();
             textBox7.Text = drv[6].ToString(); */



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            try
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Veuillez Remplir Id_Client!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    dv.RowFilter = "[Id_Client]=" + Convert.ToInt16(textBox1.Text);
                    DataRowView drv;
                    drv = dv[0];
                    textBox2.Text = drv[1].ToString();
                    textBox3.Text = drv[2].ToString();
                    textBox4.Text = drv[3].ToString();
                    textBox5.Text = drv[4].ToString();
                    textBox6.Text = drv[5].ToString();
                    textBox7.Text = drv[6].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ligne Introuvable!!!", "ERREUR!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

               }
                    }

        
    }                                                

