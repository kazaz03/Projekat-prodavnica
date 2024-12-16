namespace WindowsFormsApplication1
{
    partial class DodavanjeArtikla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjeArtikla));
            this.textBoxTražiŠifra = new System.Windows.Forms.TextBox();
            this.textBoxTražiNaziv = new System.Windows.Forms.TextBox();
            this.textBoxNazivArtikla = new System.Windows.Forms.TextBox();
            this.textBoxVrstaArtikla = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxKoličina = new System.Windows.Forms.TextBox();
            this.textBoxIDArtikla = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodavanjeArtikla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAžuriranjeArtikla = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonDodajKoličinu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazBrisanjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTražiŠifra
            // 
            this.textBoxTražiŠifra.Location = new System.Drawing.Point(12, 29);
            this.textBoxTražiŠifra.Name = "textBoxTražiŠifra";
            this.textBoxTražiŠifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxTražiŠifra.TabIndex = 0;
            this.textBoxTražiŠifra.TextChanged += new System.EventHandler(this.textBoxTražiŠifra_TextChanged);
            // 
            // textBoxTražiNaziv
            // 
            this.textBoxTražiNaziv.Location = new System.Drawing.Point(118, 28);
            this.textBoxTražiNaziv.Name = "textBoxTražiNaziv";
            this.textBoxTražiNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxTražiNaziv.TabIndex = 1;
            this.textBoxTražiNaziv.TextChanged += new System.EventHandler(this.textBoxTražiNaziv_TextChanged);
            // 
            // textBoxNazivArtikla
            // 
            this.textBoxNazivArtikla.Location = new System.Drawing.Point(97, 223);
            this.textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            this.textBoxNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivArtikla.TabIndex = 2;
            // 
            // textBoxVrstaArtikla
            // 
            this.textBoxVrstaArtikla.Location = new System.Drawing.Point(97, 249);
            this.textBoxVrstaArtikla.Name = "textBoxVrstaArtikla";
            this.textBoxVrstaArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxVrstaArtikla.TabIndex = 3;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(97, 275);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 4;
            // 
            // textBoxKoličina
            // 
            this.textBoxKoličina.Location = new System.Drawing.Point(97, 306);
            this.textBoxKoličina.Name = "textBoxKoličina";
            this.textBoxKoličina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKoličina.TabIndex = 5;
            // 
            // textBoxIDArtikla
            // 
            this.textBoxIDArtikla.Location = new System.Drawing.Point(332, 249);
            this.textBoxIDArtikla.Name = "textBoxIDArtikla";
            this.textBoxIDArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDArtikla.TabIndex = 6;
            this.textBoxIDArtikla.TextChanged += new System.EventHandler(this.textBoxIDArtikla_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 153);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonDodavanjeArtikla
            // 
            this.buttonDodavanjeArtikla.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDodavanjeArtikla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDodavanjeArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodavanjeArtikla.ForeColor = System.Drawing.Color.White;
            this.buttonDodavanjeArtikla.Location = new System.Drawing.Point(97, 332);
            this.buttonDodavanjeArtikla.Name = "buttonDodavanjeArtikla";
            this.buttonDodavanjeArtikla.Size = new System.Drawing.Size(100, 34);
            this.buttonDodavanjeArtikla.TabIndex = 12;
            this.buttonDodavanjeArtikla.Text = "Dodavanje artikla";
            this.buttonDodavanjeArtikla.UseVisualStyleBackColor = false;
            this.buttonDodavanjeArtikla.Click += new System.EventHandler(this.buttonDodavanjeArtikla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Naziv artikla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vrsta artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(263, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID artikla:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(234, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dodaj količinu:";
            // 
            // buttonAžuriranjeArtikla
            // 
            this.buttonAžuriranjeArtikla.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAžuriranjeArtikla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAžuriranjeArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAžuriranjeArtikla.ForeColor = System.Drawing.Color.White;
            this.buttonAžuriranjeArtikla.Location = new System.Drawing.Point(252, 332);
            this.buttonAžuriranjeArtikla.Name = "buttonAžuriranjeArtikla";
            this.buttonAžuriranjeArtikla.Size = new System.Drawing.Size(110, 34);
            this.buttonAžuriranjeArtikla.TabIndex = 21;
            this.buttonAžuriranjeArtikla.Text = "Ažuriranje artikla";
            this.buttonAžuriranjeArtikla.UseVisualStyleBackColor = false;
            this.buttonAžuriranjeArtikla.Click += new System.EventHandler(this.buttonAžuriranjeArtikla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(332, 296);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // buttonDodajKoličinu
            // 
            this.buttonDodajKoličinu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDodajKoličinu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDodajKoličinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajKoličinu.ForeColor = System.Drawing.Color.White;
            this.buttonDodajKoličinu.Location = new System.Drawing.Point(402, 332);
            this.buttonDodajKoličinu.Name = "buttonDodajKoličinu";
            this.buttonDodajKoličinu.Size = new System.Drawing.Size(112, 34);
            this.buttonDodajKoličinu.TabIndex = 23;
            this.buttonDodajKoličinu.Text = "Dodavanje količine";
            this.buttonDodajKoličinu.UseVisualStyleBackColor = false;
            this.buttonDodajKoličinu.Click += new System.EventHandler(this.buttonDodajKoličinu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "Meni";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem,
            this.prikazBrisanjeNarudžbeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Meni";
            // 
            // kreiranjeAžuriranjeNovogKupcaToolStripMenuItem
            // 
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem.Name = "kreiranjeAžuriranjeNovogKupcaToolStripMenuItem";
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem.Text = "Kreiranje / Ažuriranje novog kupca";
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem_Click);
            // 
            // prikazBrisanjeNarudžbeToolStripMenuItem
            // 
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Name = "prikazBrisanjeNarudžbeToolStripMenuItem";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Text = "Prikaz / Brisanje narudžbe";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Click += new System.EventHandler(this.prikazBrisanjeNarudžbeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // DodavanjeArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(582, 378);
            this.Controls.Add(this.buttonDodajKoličinu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAžuriranjeArtikla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodavanjeArtikla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxIDArtikla);
            this.Controls.Add(this.textBoxKoličina);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxVrstaArtikla);
            this.Controls.Add(this.textBoxNazivArtikla);
            this.Controls.Add(this.textBoxTražiNaziv);
            this.Controls.Add(this.textBoxTražiŠifra);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DodavanjeArtikla";
            this.Text = "Dodavanje / Ažuriranje artikla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodavanjeArtikla_FormClosed);
            this.Load += new System.EventHandler(this.KreiranjeNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTražiŠifra;
        private System.Windows.Forms.TextBox textBoxTražiNaziv;
        private System.Windows.Forms.TextBox textBoxNazivArtikla;
        private System.Windows.Forms.TextBox textBoxVrstaArtikla;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxKoličina;
        private System.Windows.Forms.TextBox textBoxIDArtikla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodavanjeArtikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAžuriranjeArtikla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonDodajKoličinu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeAžuriranjeNovogKupcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazBrisanjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}