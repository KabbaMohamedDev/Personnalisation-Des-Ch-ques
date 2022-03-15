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
    public partial class Composition : Form
    {
        public Composition()
        {
            InitializeComponent();
        }


        DataView dv = new DataView();
        static SqlConnection cn = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand("select * from Composition", cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        static DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlDataReader dr;


        private void Composition_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'personnalisation_des_ChéquiersDataSet2.Composition'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.compositionTableAdapter.Fill(this.personnalisation_des_ChéquiersDataSet2.Composition);

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

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listComposition";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Veuillez Remplir Les Champs Vide!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Composition (Id,id_Catégorie,type_formule,nombre,libellé,Bac)values('" + Convert.ToInt16(textBox1.Text) + "','" + Convert.ToInt16(textBox2.Text) + "','" + textBox3.Text + "','" + Convert.ToInt16(textBox4.Text) + "','" + textBox5.Text + "','" + Convert.ToInt16(textBox6.Text) + "')";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show(" L'Ajout a été effectué avec succès!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette Composition?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    cn.Open();


                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Composition where Id=" + Convert.ToInt16(textBox1.Text);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("La Composition est Supprimer!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string requete2 = "select * from Composition";
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listComposition";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
            
        }

        private void btnconsulter_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Veuillez Remplir Id!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    dv.RowFilter = "[Id]=" + Convert.ToInt16(textBox1.Text);
                    DataRowView drv;
                    drv = dv[0];
                    textBox2.Text = drv[1].ToString();
                    textBox3.Text = drv[2].ToString();
                    textBox4.Text = drv[3].ToString();
                    textBox5.Text = drv[4].ToString();
                    textBox6.Text = drv[5].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ligne Introuvable!!!", "ERREUR!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
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
                    cmd.CommandText = "update Composition set id_Catégorie='" + Convert.ToInt16(textBox2.Text) + "',type_formule='" + textBox3.Text + "',nombre='" + Convert.ToInt16(textBox4.Text) + "',libellé='" + textBox5.Text + "',Bac='" + Convert.ToInt16(textBox6.Text) + "' where Id ='" + Convert.ToInt16(textBox1.Text) + "'";
                    cmd.ExecuteNonQuery();
                    D.cn.Close();
                    MessageBox.Show(" La Modification a été effectué avec succès!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnafficher_Click_1(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listComposition";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}