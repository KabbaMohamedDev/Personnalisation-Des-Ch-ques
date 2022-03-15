namespace personnalisation_chequiers
{
    partial class transfert_de_fichier_TXT_vers_BDD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transfert_de_fichier_TXT_vers_BDD));
            this.btnparcourir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btngenerer = new System.Windows.Forms.Button();
            this.btnimporter = new System.Windows.Forms.Button();
            this.btnprecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btncréerdossier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnparcourir
            // 
            this.btnparcourir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnparcourir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparcourir.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btnparcourir.Location = new System.Drawing.Point(12, 33);
            this.btnparcourir.Name = "btnparcourir";
            this.btnparcourir.Size = new System.Drawing.Size(82, 26);
            this.btnparcourir.TabIndex = 0;
            this.btnparcourir.Text = "Parcourir";
            this.btnparcourir.UseVisualStyleBackColor = true;
            this.btnparcourir.Click += new System.EventHandler(this.btnparcourir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btngenerer
            // 
            this.btngenerer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerer.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btngenerer.Location = new System.Drawing.Point(243, 66);
            this.btngenerer.Name = "btngenerer";
            this.btngenerer.Size = new System.Drawing.Size(146, 36);
            this.btngenerer.TabIndex = 2;
            this.btngenerer.Text = "Générer";
            this.btngenerer.UseVisualStyleBackColor = false;
            this.btngenerer.Click += new System.EventHandler(this.btngenerer_Click);
            // 
            // btnimporter
            // 
            this.btnimporter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimporter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimporter.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btnimporter.Location = new System.Drawing.Point(395, 33);
            this.btnimporter.Name = "btnimporter";
            this.btnimporter.Size = new System.Drawing.Size(84, 26);
            this.btnimporter.TabIndex = 3;
            this.btnimporter.Text = "Importer";
            this.btnimporter.UseVisualStyleBackColor = true;
            this.btnimporter.Click += new System.EventHandler(this.btnimporter_Click);
            // 
            // btnprecedent
            // 
            this.btnprecedent.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btnprecedent.Location = new System.Drawing.Point(12, 106);
            this.btnprecedent.Name = "btnprecedent";
            this.btnprecedent.Size = new System.Drawing.Size(89, 23);
            this.btnprecedent.TabIndex = 4;
            this.btnprecedent.Text = "<==";
            this.btnprecedent.UseVisualStyleBackColor = true;
            this.btnprecedent.Click += new System.EventHandler(this.btnprecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btnSuivant.Location = new System.Drawing.Point(395, 106);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(84, 23);
            this.btnSuivant.TabIndex = 5;
            this.btnSuivant.Text = "==>";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(426, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Déverrouiller";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btncréerdossier
            // 
            this.btncréerdossier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncréerdossier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncréerdossier.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btncréerdossier.Location = new System.Drawing.Point(100, 66);
            this.btncréerdossier.Name = "btncréerdossier";
            this.btncréerdossier.Size = new System.Drawing.Size(137, 36);
            this.btncréerdossier.TabIndex = 7;
            this.btncréerdossier.Text = "Créer Dossier Archive";
            this.btncréerdossier.UseVisualStyleBackColor = true;
            this.btncréerdossier.Click += new System.EventHandler(this.btncréerdossier_Click);
            // 
            // transfert_de_fichier_TXT_vers_BDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.ClientSize = new System.Drawing.Size(497, 136);
            this.ControlBox = false;
            this.Controls.Add(this.btncréerdossier);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnprecedent);
            this.Controls.Add(this.btnimporter);
            this.Controls.Add(this.btngenerer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnparcourir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "transfert_de_fichier_TXT_vers_BDD";
            this.Text = "Transfert de Fichier TXT vers BDD";
            this.Load += new System.EventHandler(this.transfert_de_fichier_TXT_vers_BDD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnparcourir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btngenerer;
        private System.Windows.Forms.Button btnimporter;
        private System.Windows.Forms.Button btnprecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btncréerdossier;
    }
}