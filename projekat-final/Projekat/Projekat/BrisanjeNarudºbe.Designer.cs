namespace WindowsFormsApplication1
{
    partial class BrisanjeNarudžbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeNarudžbe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDNarudzbe = new System.Windows.Forms.TextBox();
            this.buttonBrisanjeNarudžbe = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeAžuriranjeArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID narudžbe:";
            // 
            // textBoxIDNarudzbe
            // 
            this.textBoxIDNarudzbe.Location = new System.Drawing.Point(105, 225);
            this.textBoxIDNarudzbe.Name = "textBoxIDNarudzbe";
            this.textBoxIDNarudzbe.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDNarudzbe.TabIndex = 2;
            // 
            // buttonBrisanjeNarudžbe
            // 
            this.buttonBrisanjeNarudžbe.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonBrisanjeNarudžbe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrisanjeNarudžbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrisanjeNarudžbe.ForeColor = System.Drawing.Color.White;
            this.buttonBrisanjeNarudžbe.Location = new System.Drawing.Point(222, 216);
            this.buttonBrisanjeNarudžbe.Name = "buttonBrisanjeNarudžbe";
            this.buttonBrisanjeNarudžbe.Size = new System.Drawing.Size(134, 36);
            this.buttonBrisanjeNarudžbe.TabIndex = 3;
            this.buttonBrisanjeNarudžbe.Text = "Brisanje narudžbe";
            this.buttonBrisanjeNarudžbe.UseVisualStyleBackColor = false;
            this.buttonBrisanjeNarudžbe.Click += new System.EventHandler(this.buttonBrisanjeNarudžbe_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 4;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeAžuriranjeNovogKupcaToolStripMenuItem,
            this.dodavanjeAžuriranjeArtikalaToolStripMenuItem,
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
            // dodavanjeAžuriranjeArtikalaToolStripMenuItem
            // 
            this.dodavanjeAžuriranjeArtikalaToolStripMenuItem.Name = "dodavanjeAžuriranjeArtikalaToolStripMenuItem";
            this.dodavanjeAžuriranjeArtikalaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.dodavanjeAžuriranjeArtikalaToolStripMenuItem.Text = "Dodavanje / Ažuriranje artikala";
            this.dodavanjeAžuriranjeArtikalaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeAžuriranjeArtikalaToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // BrisanjeNarudžbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(490, 263);
            this.Controls.Add(this.buttonBrisanjeNarudžbe);
            this.Controls.Add(this.textBoxIDNarudzbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BrisanjeNarudžbe";
            this.Text = "Prikaz/Brisanje narudžbe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrisanjeNarudžbe_FormClosed);
            this.Load += new System.EventHandler(this.BrisanjeNarudžbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDNarudzbe;
        private System.Windows.Forms.Button buttonBrisanjeNarudžbe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeAžuriranjeNovogKupcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeAžuriranjeArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}