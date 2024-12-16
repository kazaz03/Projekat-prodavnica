namespace WindowsFormsApplication1
{
    partial class KreiranjeKupca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreiranjeKupca));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAžuriranje = new System.Windows.Forms.Button();
            this.buttonKreiranje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxTražiPrezime = new System.Windows.Forms.TextBox();
            this.textBoxTražiIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazBrisanjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(218, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "ID kupca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(300, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Šifra:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(244, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Korisničko ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Adresa:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Grad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAžuriranje
            // 
            this.buttonAžuriranje.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAžuriranje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAžuriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAžuriranje.ForeColor = System.Drawing.Color.White;
            this.buttonAžuriranje.Location = new System.Drawing.Point(343, 370);
            this.buttonAžuriranje.Name = "buttonAžuriranje";
            this.buttonAžuriranje.Size = new System.Drawing.Size(126, 31);
            this.buttonAžuriranje.TabIndex = 35;
            this.buttonAžuriranje.Text = "Ažuriranje kupca";
            this.buttonAžuriranje.UseVisualStyleBackColor = false;
            this.buttonAžuriranje.Click += new System.EventHandler(this.buttonAžuriranje_Click);
            // 
            // buttonKreiranje
            // 
            this.buttonKreiranje.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonKreiranje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKreiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKreiranje.ForeColor = System.Drawing.Color.White;
            this.buttonKreiranje.Location = new System.Drawing.Point(343, 336);
            this.buttonKreiranje.Name = "buttonKreiranje";
            this.buttonKreiranje.Size = new System.Drawing.Size(126, 28);
            this.buttonKreiranje.TabIndex = 34;
            this.buttonKreiranje.Text = "Kreiranje kupca";
            this.buttonKreiranje.UseVisualStyleBackColor = false;
            this.buttonKreiranje.Click += new System.EventHandler(this.buttonKreiranje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 153);
            this.dataGridView1.TabIndex = 32;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(287, 375);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(50, 20);
            this.textBoxID.TabIndex = 31;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(343, 292);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 30;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(343, 266);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 29;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(343, 240);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 28;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(94, 323);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresa.TabIndex = 27;
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Location = new System.Drawing.Point(94, 292);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrad.TabIndex = 26;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(94, 266);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 25;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(94, 240);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 24;
            // 
            // textBoxTražiPrezime
            // 
            this.textBoxTražiPrezime.Location = new System.Drawing.Point(120, 45);
            this.textBoxTražiPrezime.Name = "textBoxTražiPrezime";
            this.textBoxTražiPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTražiPrezime.TabIndex = 23;
            this.textBoxTražiPrezime.TextChanged += new System.EventHandler(this.textBoxTražiPrezime_TextChanged);
            // 
            // textBoxTražiIme
            // 
            this.textBoxTražiIme.Location = new System.Drawing.Point(14, 45);
            this.textBoxTražiIme.Name = "textBoxTražiIme";
            this.textBoxTražiIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxTražiIme.TabIndex = 22;
            this.textBoxTražiIme.TextChanged += new System.EventHandler(this.textBoxTražiIme_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Ime:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(117, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Prezime:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem,
            this.prikazBrisanjeNarudžbeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Meni";
            // 
            // dodavanjeAžuriranjeArtiklaToolStripMenuItem
            // 
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Name = "dodavanjeAžuriranjeArtiklaToolStripMenuItem";
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Text = "Dodavanje / Ažuriranje artikla";
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeAžuriranjeArtiklaToolStripMenuItem_Click);
            // 
            // prikazBrisanjeNarudžbeToolStripMenuItem
            // 
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Name = "prikazBrisanjeNarudžbeToolStripMenuItem";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Text = "Prikaz / Brisanje narudžbe";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Click += new System.EventHandler(this.prikazBrisanjeNarudžbeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // KreiranjeKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(584, 425);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAžuriranje);
            this.Controls.Add(this.buttonKreiranje);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxGrad);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxTražiPrezime);
            this.Controls.Add(this.textBoxTražiIme);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KreiranjeKupca";
            this.Text = "Kreiranje / Ažuriranje novog kupca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KreiranjeKupca_FormClosed);
            this.Load += new System.EventHandler(this.KreiranjeKupca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAžuriranje;
        private System.Windows.Forms.Button buttonKreiranje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxGrad;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxTražiPrezime;
        private System.Windows.Forms.TextBox textBoxTražiIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeAžuriranjeArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazBrisanjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}