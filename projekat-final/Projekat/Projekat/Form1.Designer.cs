namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxŠifra = new System.Windows.Forms.TextBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(287, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(343, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIme.Location = new System.Drawing.Point(386, 127);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 2;
            // 
            // textBoxŠifra
            // 
            this.textBoxŠifra.Location = new System.Drawing.Point(386, 167);
            this.textBoxŠifra.Name = "textBoxŠifra";
            this.textBoxŠifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxŠifra.TabIndex = 3;
            this.textBoxŠifra.UseSystemPasswordChar = true;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.BackColor = System.Drawing.Color.Red;
            this.buttonPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrijava.ForeColor = System.Drawing.Color.White;
            this.buttonPrijava.Location = new System.Drawing.Point(386, 206);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(100, 29);
            this.buttonPrijava.TabIndex = 4;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(526, 344);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.textBoxŠifra);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxŠifra;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

