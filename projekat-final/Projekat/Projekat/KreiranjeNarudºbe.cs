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
    public partial class KreiranjeNarudžbe : Form
    {
        public KreiranjeNarudžbe()
        {
            InitializeComponent();
        }

        String konekcioniString = Form1.konekcioniString;
        String kupacID = Form1.kupacID;
        public static String narudzba;

        private void KreiranjeNarudžbe_Load(object sender, EventArgs e)
        {
            PrikazArtikala();
            UzmiZadnjuNarudžbu();
            Korpa();
            Total();
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
            String query = "SELECT a.artikal_id AS 'ID artikla', a.naziv_artikla AS 'Naziv', a.vrsta_artikla AS 'Vrsta',a.cijena AS 'Cijena',s.kolicina_stanje AS 'Količina' FROM artikal a,skladiste s WHERE a.artikal_id=s.artikal_id";
            try
            {
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

        private void buttonKreirajNarudžbu_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO narudzbenica(kupac_id,datum_narudzbe) VALUES('" + kupacID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Narudžba je kreirana.");
                konekcija.Close();
                UzmiZadnjuNarudžbu();
                PrikazArtikala();
                Korpa();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UzmiZadnjuNarudžbu() {
            try
            {
                String queryN = "SELECT narudzbenica_id FROM narudzbenica WHERE kupac_id='" + kupacID + "'ORDER BY narudzbenica_id DESC";
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(queryN, konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    narudzba = reader[0].ToString();
                }
                reader.Close();
                konekcija.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Korpa()
        {
            String query = "SELECT s.stavka_id AS 'ID stavke', s.narudzbenica_id AS 'ID narudzbe', s.artikal_id AS 'ID artikla',s.kolicina AS 'Količina',a.naziv_artikla AS 'Naziv artikla' FROM artikal a,stavka_narudzbenice s,narudzbenica n WHERE s.artikal_id=a.artikal_id AND n.narudzbenica_id=s.narudzbenica_id AND s.narudzbenica_id='"+narudzba+"' AND n.kupac_id='"+kupacID+"'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView2.DataSource = tabela;
                dataAdapter.Dispose();
                konekcija.Close();

                ModificirajGridView(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO stavka_narudzbenice(narudzbenica_id,artikal_id,kolicina) VALUES('"+narudzba+"','"+textBoxID.Text+"','"+textBoxKOL.Text+"')";
            String queryK = "SELECT kolicina_stanje FROM skladiste WHERE artikal_id='"+textBoxID.Text+"'";
            
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                MySqlCommand cmdK= new MySqlCommand(queryK,konekcija);

                    MySqlDataReader reader;
                    reader = cmdK.ExecuteReader();
                    reader.Read();
                    String kolicina = reader[0].ToString();
                    int rez = Convert.ToInt32(kolicina) - Convert.ToInt32(textBoxKOL.Text);
                    String queryU = "UPDATE skladiste SET kolicina_stanje='"+rez+"' WHERE artikal_id='"+textBoxID.Text+"'";
                    MySqlCommand cmdU = new MySqlCommand(queryU,konekcija);
                    reader.Close();

                if (Convert.ToInt32(kolicina) < Convert.ToInt32(textBoxKOL.Text))
                {
                    errorProvider1.SetError(textBoxKOL, "Prevelik broj.");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    cmdU.ExecuteNonQuery();
                    MessageBox.Show("Artikl ubačen u korpu.");
                    
                }

                konekcija.Close();
                PrikazArtikala();
                Korpa();
                Total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonObriši_Click(object sender, EventArgs e)
        {
            String queryK = "SELECT kolicina,kolicina_stanje FROM stavka_narudzbenice sn,skladiste s WHERE sn.artikal_id=s.artikal_id AND s.artikal_id='" + textBoxID.Text + "' AND narudzbenica_id='" + narudzba + "'";
            String queryI = "SELECT sn.stavka_id FROM stavka_narudzbenice sn,skladiste s WHERE sn.artikal_id=s.artikal_id AND sn.artikal_id='" + textBoxID.Text + "' AND narudzbenica_id='" + narudzba + "' ORDER BY stavka_id DESC";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmdI = new MySqlCommand(queryI, konekcija);
                MySqlCommand cmdK = new MySqlCommand(queryK, konekcija);

                    MySqlDataReader readerI;
                    readerI = cmdI.ExecuteReader();
                    readerI.Read();
                    String stavka = readerI[0].ToString();
                    readerI.Close();

                    MySqlDataReader readerK;
                    readerK = cmdK.ExecuteReader();
                    readerK.Read();
                    String kolicina = readerK[0].ToString();
                    String skolicina = readerK[1].ToString();
                    int rez = Convert.ToInt32(skolicina) + Convert.ToInt32(kolicina);
                    String queryU = "UPDATE skladiste SET kolicina_stanje='"+rez+"' WHERE artikal_id='"+textBoxID.Text+"'";
                    MySqlCommand cmdU = new MySqlCommand(queryU, konekcija);
                    readerK.Close();

                String query = "DELETE FROM stavka_narudzbenice WHERE artikal_id='"+textBoxID.Text+"' AND narudzbenica_id='"+narudzba+"' AND stavka_id='"+stavka+"'";
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                cmdU.ExecuteNonQuery();
                MessageBox.Show("Artikl izbrisan iz korpe.");
                konekcija.Close();
                PrikazArtikala();
                Korpa();
                Total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KreiranjeNarudžbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Total() 
        {
            int ukupno=0;
            String query = "SELECT sn.kolicina,a.cijena FROM stavka_narudzbenice sn,artikal a, narudzbenica n WHERE n.narudzbenica_id=sn.narudzbenica_id AND sn.artikal_id=a.artikal_id AND sn.narudzbenica_id='"+narudzba+"' AND n.kupac_id='"+kupacID+"'  ";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query,konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    {
                        String kol = reader[0].ToString();
                        String cij = reader[1].ToString();
                        int rez = Convert.ToInt32(kol) * Convert.ToInt32(cij);
                        ukupno += rez;
                    }

                reader.Close();
                konekcija.Close();
                textBoxTotal.Text = ukupno.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prikazNarudžbiIStavkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazNarudžbi pn = new PrikazNarudžbi();
            this.Hide();
            pn.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }



       
    }
}
