namespace personnalisation_chequiers
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btndescription = new System.Windows.Forms.Button();
            this.btncomposition = new System.Windows.Forms.Button();
            this.btncatégorie = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(489, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Déverrouiller";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btndescription
            // 
            this.btndescription.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescription.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btndescription.Location = new System.Drawing.Point(313, 133);
            this.btndescription.Name = "btndescription";
            this.btndescription.Size = new System.Drawing.Size(179, 66);
            this.btndescription.TabIndex = 9;
            this.btndescription.Text = "Description";
            this.btndescription.UseVisualStyleBackColor = true;
            this.btndescription.Click += new System.EventHandler(this.btndescription_Click);
            // 
            // btncomposition
            // 
            this.btncomposition.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomposition.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btncomposition.Location = new System.Drawing.Point(77, 133);
            this.btncomposition.Name = "btncomposition";
            this.btncomposition.Size = new System.Drawing.Size(179, 66);
            this.btncomposition.TabIndex = 8;
            this.btncomposition.Text = "Composition";
            this.btncomposition.UseVisualStyleBackColor = true;
            this.btncomposition.Click += new System.EventHandler(this.btncomposition_Click);
            // 
            // btncatégorie
            // 
            this.btncatégorie.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatégorie.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btncatégorie.Location = new System.Drawing.Point(313, 47);
            this.btncatégorie.Name = "btncatégorie";
            this.btncatégorie.Size = new System.Drawing.Size(179, 66);
            this.btncatégorie.TabIndex = 7;
            this.btncatégorie.Text = " Catégorie";
            this.btncatégorie.UseVisualStyleBackColor = true;
            this.btncatégorie.Click += new System.EventHandler(this.btncatégorie_Click);
            // 
            // btnclient
            // 
            this.btnclient.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.btnclient.Location = new System.Drawing.Point(77, 47);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(179, 66);
            this.btnclient.TabIndex = 6;
            this.btnclient.Text = "Client";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // button2
            // 
            this.button2.Image = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.button2.Location = new System.Drawing.Point(482, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "==>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::personnalisation_chequiers.Properties.Resources._42DaUeWc_istock_000000560341small;
            this.ClientSize = new System.Drawing.Size(571, 247);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btndescription);
            this.Controls.Add(this.btncomposition);
            this.Controls.Add(this.btncatégorie);
            this.Controls.Add(this.btnclient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btndescription;
        private System.Windows.Forms.Button btncomposition;
        private System.Windows.Forms.Button btncatégorie;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button button2;

    }
}