namespace WindowsFormsApplication1
{
    partial class KreiranjeNarudžbe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreiranjeNarudžbe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKreirajNarudžbu = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObriši = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxKOL = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazNarudžbiIStavkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled artikala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(292, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korpa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(442, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KOL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(417, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(542, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "KM";
            // 
            // buttonKreirajNarudžbu
            // 
            this.buttonKreirajNarudžbu.BackColor = System.Drawing.Color.LightGreen;
            this.buttonKreirajNarudžbu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKreirajNarudžbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKreirajNarudžbu.ForeColor = System.Drawing.Color.White;
            this.buttonKreirajNarudžbu.Location = new System.Drawing.Point(295, 49);
            this.buttonKreirajNarudžbu.Name = "buttonKreirajNarudžbu";
            this.buttonKreirajNarudžbu.Size = new System.Drawing.Size(116, 34);
            this.buttonKreirajNarudžbu.TabIndex = 6;
            this.buttonKreirajNarudžbu.Text = "Kreiraj narudžbu";
            this.buttonKreirajNarudžbu.UseVisualStyleBackColor = false;
            this.buttonKreirajNarudžbu.Click += new System.EventHandler(this.buttonKreirajNarudžbu_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(295, 277);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 7;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObriši
            // 
            this.buttonObriši.BackColor = System.Drawing.Color.LightGreen;
            this.buttonObriši.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonObriši.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonObriši.ForeColor = System.Drawing.Color.White;
            this.buttonObriši.Location = new System.Drawing.Point(295, 306);
            this.buttonObriši.Name = "buttonObriši";
            this.buttonObriši.Size = new System.Drawing.Size(75, 23);
            this.buttonObriši.TabIndex = 8;
            this.buttonObriši.Text = "Obriši";
            this.buttonObriši.UseVisualStyleBackColor = false;
            this.buttonObriši.Click += new System.EventHandler(this.buttonObriši_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 280);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(295, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(241, 169);
            this.dataGridView2.TabIndex = 10;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(458, 328);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(78, 20);
            this.textBoxTotal.TabIndex = 11;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(376, 298);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(50, 20);
            this.textBoxID.TabIndex = 12;
            // 
            // textBoxKOL
            // 
            this.textBoxKOL.Location = new System.Drawing.Point(432, 298);
            this.textBoxKOL.Name = "textBoxKOL";
            this.textBoxKOL.Size = new System.Drawing.Size(47, 20);
            this.textBoxKOL.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazNarudžbiIStavkiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Meni";
            // 
            // prikazNarudžbiIStavkiToolStripMenuItem
            // 
            this.prikazNarudžbiIStavkiToolStripMenuItem.Name = "prikazNarudžbiIStavkiToolStripMenuItem";
            this.prikazNarudžbiIStavkiToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.prikazNarudžbiIStavkiToolStripMenuItem.Text = "Prikaz narudžbi i stavki";
            this.prikazNarudžbiIStavkiToolStripMenuItem.Click += new System.EventHandler(this.prikazNarudžbiIStavkiToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // KreiranjeNarudžbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(567, 365);
            this.Controls.Add(this.textBoxKOL);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonObriši);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonKreirajNarudžbu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KreiranjeNarudžbe";
            this.Text = "Kreiranje Narudžbe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KreiranjeNarudžbe_FormClosed);
            this.Load += new System.EventHandler(this.KreiranjeNarudžbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonKreirajNarudžbu;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObriši;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxKOL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prikazNarudžbiIStavkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}