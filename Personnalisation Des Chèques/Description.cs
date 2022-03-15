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
    public partial class Description : Form
    {
        public Description()
        {
            InitializeComponent();
        }

        DataView dv = new DataView();
        static SqlConnection cn = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Personnalisation des Chéquiers;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand("select * from Description", cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        static DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlDataReader dr;



        private void Description_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'personnalisation_des_ChéquiersDataSet3.Description'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.descriptionTableAdapter.Fill(this.personnalisation_des_ChéquiersDataSet3.Description);

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
            textBox8.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listDescription";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
                {
                    MessageBox.Show("Veuillez Remplir Les Champs Vide!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Description (Id_client,début,fin,champ_bdd,libellé,Integrite,zz,Retour)values('" + Convert.ToInt16(textBox1.Text) + "','" + Convert.ToInt16(textBox2.Text) + "','" + Convert.ToInt16(textBox3.Text) + "','" + Convert.ToInt16(textBox4.Text) + "','" + textBox5.Text + "','" + Convert.ToInt16(textBox6.Text) + "','" + Convert.ToInt16(textBox7.Text) + "','" + Convert.ToInt16(textBox8.Text) + "')";
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
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette Description?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    cn.Open();


                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Description where Id_client=" + Convert.ToInt16(textBox1.Text);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("La Description est Supprimer!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string requete2 = "select * from Description";
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

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
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
                    cmd.CommandText = "update Description set début='" + Convert.ToInt16(textBox2.Text) + "',fin='" + Convert.ToInt16(textBox3.Text) + "',champ_bdd='" + Convert.ToInt16(textBox4.Text) + "',libellé='" + textBox5.Text + "',Integrite='" + Convert.ToInt16(textBox6.Text) + "',zz='" + Convert.ToInt16(textBox7.Text) + "',Retour='" + Convert.ToInt16(textBox8.Text) + "' where Id_client ='" + Convert.ToInt16(textBox1.Text) + "'";
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

        private void btnconsulter_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Veuillez Remplir Id_client!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    dv.RowFilter = "[Id_client]=" + Convert.ToInt16(textBox1.Text);
                    DataRowView drv;
                    drv = dv[0];
                   /* textBox2.Text = drv[1].ToString();
                    textBox3.Text = drv[2].ToString();
                    textBox4.Text = drv[3].ToString();
                    textBox5.Text = drv[4].ToString();
                    textBox6.Text = drv[5].ToString();
                    textBox7.Text = drv[6].ToString();
                    textBox8.Text = drv[7].ToString(); */
                }
            }
            catch
            {
                MessageBox.Show("Ligne Introuvable!!!", "ERREUR!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listDescription";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
