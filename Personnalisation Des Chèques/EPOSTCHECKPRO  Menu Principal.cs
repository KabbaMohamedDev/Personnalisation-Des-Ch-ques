using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace personnalisation_chequiers
{
    public partial class EPOSTCHECKPRO__Menu_Principal : Form
    {
        public EPOSTCHECKPRO__Menu_Principal()
        {
            InitializeComponent();
        }

        private void EPOSTCHECKPRO__Menu_Principal_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'personnalisation_des_ChéquiersDataSet4.Chéque'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.chéqueTableAdapter.Fill(this.personnalisation_des_ChéquiersDataSet4.Chéque);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EPOSTCHECKPRO f = new EPOSTCHECKPRO();
            f.Show();
            this.Hide();//pour cacher l'interface.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            transfert_de_fichier_TXT_vers_BDD f = new transfert_de_fichier_TXT_vers_BDD();
            f.Show();
            this.Hide();//pour cacher l'interface.
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            textBox3.Text = NumberTowords(Convert.ToInt32(textBox2.Text));

            textBox4.Text = ArabicTowords(Convert.ToInt32(textBox2.Text));



            Chéque f2 = new Chéque();
            CrystalReport1 cr = new CrystalReport1();
            TextObject text = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text2"];
            TextObject text1 = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text3"];
            TextObject text2 = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text4"];
            TextObject text3 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text5"];
            TextObject text4 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text6"];
            TextObject text5 = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text1"];
            TextObject text8 = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text8"];
            TextObject text9 = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text9"];
            TextObject text7 = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text7"];
            TextObject text10 = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text10"];
            TextObject text11 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text11"];
            TextObject text12 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text12"];
            TextObject text13 = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text13"];
            text.Text = comboBox1.Text;
            text1.Text = comboBox2.Text;
            text2.Text = textBox1.Text;
            text3.Text = textBox2.Text;
            text4.Text = textBox3.Text;
            text5.Text = textBox4.Text;
            text8.Text = label3.Text;
            text9.Text = label4.Text;
            text7.Text = label6.Text;
            text10.Text = label5.Text;
            text11.Text = label7.Text;
            text12.Text = label8.Text;
            text13.Text = groupBox1.Text;
           
                  DataSet1 ds = new DataSet1();
                  System.IO.MemoryStream ms = new System.IO.MemoryStream();
                  pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
                  Byte[] bt = ms.ToArray();
                  ds.DataTable1.Rows.Add(bt);
                  cr.SetDataSource(ds.Tables["DataTable1"]);
             
            f2.crystalReportViewer1.ReportSource = cr;
            f2.ShowDialog();


            /*      DataSet1 ds = new DataSet1();
                  System.IO.MemoryStream ms = new System.IO.MemoryStream();
                  pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                  Byte[] bt = ms.ToArray();
                  ds.DataTable1.Rows.Add(bt);
                  CrystalReport1 cr = new CrystalReport1();
                  cr.SetDataSource(ds.Tables["DataTable1"]);

                  Chéque fr = new Chéque();
                  fr.crystalReportViewer1.ReportSource = cr;
                  fr.ShowDialog();
                  */





            //       byte[] Byt = ms.ToArray();
            //    byte[] Byt = ms.ToArray;
            /*    byte[] byt = new byte[1];
             byt = ms.ToArray();  */

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public static string NumberTowords(int number)
        {
            if (number == 0) return "zero";

            if (number < 0) return "minus" + NumberTowords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberTowords(number / 1000000) + "Million";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                ; words += NumberTowords(number / 1000) + "Mille";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberTowords(number / 100) + "Cent";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "") words += "and";

                var unitsMap = new[] { "Zéro", "Un", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf", "Dix", "Onze", "Douze", "Treize", "Quatorze", "Quinze", "Seize", "Dix-Sept", "Dix-Huit", "Dix-Neuf" };

                var tensMap = new[] { "Zéro", "Dix", "Vingt ", "Trente", "Quarante", "Cinquante", "Soixante", "Soixante-Dix", "Quatre-Vingts", "Quatre-Vingt-Dix" };

                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];

                    if ((number % 10) > 0) words += "- " + unitsMap[number % 10];

                }
            }

            return words;
        }









        public static string ArabicTowords(int number)
        {
            if (number == 0) return "صفر";

            if (number < 0) return "minus" + ArabicTowords(Math.Abs(number));

            string woords = "";


            if ((number / 1000000) > 0)
            {
                woords += ArabicTowords(number / 1000000) + "مليون";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                ; woords += ArabicTowords(number / 1000) + "الف";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                woords += ArabicTowords(number / 100) + "مئة";
                number %= 100;
            }

            if (number > 0)
            {
                if (woords != "") woords += "و";


                var unitsara = new[] { "صفر ", "واحد", "اثنان", "ثلاثة", "اربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة", "عشرة", "أحد عشر", "اثنا عشر", " ثلاثة عشر", "اربعة عشر", "خمسة عشر", "ستة عشر", "سبعة عشر", " ثمانية عشر", " تسعة عشر" };

                var tensara = new[] { "صفر", "عشرة", "عشرون", "ثلاثون", "اربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون" };

                if (number < 20) woords += unitsara[number];
                else
                {
                    woords += tensara[number / 10];

                    if ((number % 10) > 0) woords += " " + unitsara[number % 10];

                }
            }

            return woords;
        }
    //    Image file;

        private void btnsignature_Click(object sender, EventArgs e)
        {
            /*
             
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image|*.jpg;jpeg;PNJ";

            // "JPG(*.JPG)|*.jpg"
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                pictureBox1.Image = file;



            }

            */

            OpenFileDialog Opnd = new OpenFileDialog();
            Opnd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Opnd.Filter = "Text Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (Opnd.ShowDialog(this) == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(Opnd.FileName);
            }

        }

       

























    }


}