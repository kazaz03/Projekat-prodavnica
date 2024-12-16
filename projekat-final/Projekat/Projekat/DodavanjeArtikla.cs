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
    public partial class DodavanjeArtikla : Form
    {
        public DodavanjeArtikla()
        {
            InitializeComponent();
        }
        String konekcioniString = Form1.konekcioniString;

        private void KreiranjeNarudzbe_Load(object sender, EventArgs e)
        {
            PrikazArtikala();
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
        private void PrikazArtikala()
        {
            String query = "SELECT a.artikal_id AS 'ID artikla', a.naziv_artikla AS 'Naziv artikla', a.vrsta_artikla AS 'Vrsta artikla', a.cijena "+
                "AS 'Cijena artikla', s.kolicina_stanje AS 'Količina' FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id ";
            try
            {
                if (textBoxTražiŠifra.Text != "")
                {
                    query += "and a.artikal_id LIKE '" + textBoxTražiŠifra.Text + "%'";
                }

                if (textBoxTražiNaziv.Text != "")
                {
                    query += "and a.naziv_artikla LIKE '" + textBoxTražiNaziv.Text + "%'";
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

        private void textBoxTražiŠifra_TextChanged(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void textBoxTražiNaziv_TextChanged(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void buttonDodavanjeArtikla_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO artikal (naziv_artikla,vrsta_artikla,cijena) VALUES " +
                "('" + textBoxNazivArtikla.Text + "','" + textBoxVrstaArtikla.Text + "','" + textBoxCijena.Text + "')";
            String query1 = "INSERT INTO skladiste (kolicina_stanje,artikal_id) VALUES ('" + textBoxKoličina.Text + "',";
            String query2 = "SELECT artikal_id from artikal where naziv_artikla='" + textBoxNazivArtikla.Text + "'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                MySqlCommand cmd2 = new MySqlCommand(query2, konekcija);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader;
                reader = cmd2.ExecuteReader();
                reader.Read();
                string sifra = reader[0].ToString();
                query1 += "' " + sifra + "')";
                MySqlCommand cmd1 = new MySqlCommand(query1, konekcija);
                reader.Close();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Dodan novi artikal.");
                konekcija.Close();
                PrikazArtikala();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAžuriranjeArtikla_Click(object sender, EventArgs e)
        {
            String query = "UPDATE artikal SET naziv_artikla='"+textBoxNazivArtikla.Text+"',vrsta_artikla='"+textBoxVrstaArtikla.Text+
                "',cijena='"+textBoxCijena.Text+"' WHERE artikal_id='"+textBoxIDArtikla.Text+"'";
            String query1 = "UPDATE skladiste SET kolicina_stanje='" + textBoxKoličina.Text + "' WHERE artikal_id='"+textBoxIDArtikla.Text+"'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query,konekcija);
                MySqlCommand cmd1 = new MySqlCommand(query1,konekcija);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Artikal je ažuriran.");
                konekcija.Close();
                PrikazArtikala();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDodajKoličinu_Click(object sender, EventArgs e)
        {
            int broj= Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            string query = "SELECT kolicina_stanje from skladiste WHERE artikal_id='"+textBoxIDArtikla.Text+"'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query,konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string kolicina = reader[0].ToString();
                int zbir = Convert.ToInt32(kolicina) + broj;
                reader.Close();
                string query1 = "UPDATE skladiste SET kolicina_stanje='"+zbir.ToString()+
                    "' WHERE artikal_id='"+textBoxIDArtikla.Text+"'";
                MySqlCommand cmd1 = new MySqlCommand(query1, konekcija);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Dodana je količina.");
                konekcija.Close();
                PrikazArtikala();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxIDArtikla_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT a.naziv_artikla, a.vrsta_artikla,a.cijena,s.kolicina_stanje FROM "+
                "artikal a,skladiste s WHERE a.artikal_id=s.artikal_id and a.artikal_id='" + textBoxIDArtikla.Text + "'";
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
                    textBoxNazivArtikla.Text = reader[0].ToString();
                    textBoxVrstaArtikla.Text = reader[1].ToString();
                    textBoxCijena.Text = reader[2].ToString();
                    textBoxKoličina.Text = reader[3].ToString();
                }

                reader.Close();
                konekcija.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DodavanjeArtikla_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kreiranjeAžuriranjeNovogKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreiranjeKupca kk = new KreiranjeKupca();
            this.Hide();
            kk.Show();
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

    }
}
