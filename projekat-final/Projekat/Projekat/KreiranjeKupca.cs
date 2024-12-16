using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class KreiranjeKupca : Form
    {
        public KreiranjeKupca()
        {
            InitializeComponent();
        }


        String konekcioniString = Form1.konekcioniString;
        

        private void KreiranjeKupca_Load(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void ModificirajGridView(DataGridView dgv)
        {
           
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows.IndexOf(dgv.Rows[i]) % 2 == 0)
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                else
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void PrikazKupaca()
        {
            String query = "SELECT kupac_id AS 'ID kupca', ime AS 'Ime', prezime AS 'Prezime',grad AS 'Grad',adresa AS 'Adresa',telefon AS 'Telefon' FROM kupac WHERE kupac_id=kupac_id ";
            try
            {
                if (textBoxTražiIme.Text != "")
                {
                    query += "and ime LIKE '" + textBoxTražiIme.Text + "%'";
                }

                if (textBoxTražiPrezime.Text != "")
                {
                    query += "and prezime LIKE '" + textBoxTražiPrezime.Text + "%'";
                }
              
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataAdapter.Dispose();
                konekcija.Close();

                ModificirajGridView(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxTražiIme_TextChanged(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void textBoxTražiPrezime_TextChanged(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void buttonKreiranje_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO kupac(ime,prezime,grad,adresa,telefon,user,pass) VALUES ('"+textBoxIme.Text+"','"+textBoxPrezime.Text+"','"+textBoxGrad.Text+"','"+textBoxAdresa.Text+"','"+textBoxTelefon.Text+"','"+textBoxUser.Text+"','"+textBoxPass.Text+"')";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dodan novi kupac.");
                konekcija.Close();
                PrikazKupaca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAžuriranje_Click(object sender, EventArgs e)
        {
          
            String query = "UPDATE kupac SET ime='" + textBoxIme.Text + "',prezime='" + textBoxPrezime.Text + "',grad='" + textBoxGrad.Text + "',adresa='" + textBoxAdresa.Text + "',telefon='" + textBoxTelefon.Text + "',user='" + textBoxUser.Text + "',pass='" + textBoxPass.Text + "' WHERE kupac_id='"+textBoxID.Text+"'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kupac ažuriran.");
                konekcija.Close();
                PrikazKupaca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT ime,prezime,grad,adresa,telefon,user,pass FROM kupac WHERE kupac_id='" + textBoxID.Text + "'";
            try
            {
               MySqlConnection konekcija = new MySqlConnection(konekcioniString);
               konekcija.Open();
               MySqlCommand cmd = new MySqlCommand(query, konekcija);
               MySqlDataReader reader;
               reader = cmd.ExecuteReader();
               reader.Read();
               if (reader.HasRows)
               {
                   textBoxIme.Text = reader[0].ToString();
                   textBoxPrezime.Text = reader[1].ToString();
                   textBoxGrad.Text = reader[2].ToString();
                   textBoxAdresa.Text = reader[3].ToString();
                   textBoxTelefon.Text = reader[4].ToString();
                   textBoxUser.Text = reader[5].ToString();
                   textBoxPass.Text = reader[6].ToString();
               }

               reader.Close();
               konekcija.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void KreiranjeKupca_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dodavanjeAžuriranjeArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeArtikla da = new DodavanjeArtikla();
            this.Hide();
            da.Show();
        }

        private void prikazBrisanjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjeNarudžbe bn = new BrisanjeNarudžbe();
            this.Hide();
            bn.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }




    }
}