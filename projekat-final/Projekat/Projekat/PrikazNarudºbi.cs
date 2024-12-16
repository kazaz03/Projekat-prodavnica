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
    public partial class PrikazNarudžbi : Form
    {
        public PrikazNarudžbi()
        {
            InitializeComponent();
        }
        String konekcioniString = Form1.konekcioniString;
        String kupacID = Form1.kupacID;
        String narudzba = KreiranjeNarudžbe.narudzba;

        private void PrikazNarudžbi_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
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
        private void PrikazNarudzbi()
        {
            String query = "SELECT narudzbenica_id AS 'ID narudzbe',datum_narudzbe AS 'Datum narudzbe' from "+
                "narudzbenica WHERE kupac_id='"+kupacID+"'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridViewNarudžbe.DataSource = tabela;
                dataAdapter.Dispose();
                konekcija.Close();
                ModificirajGridView(dataGridViewNarudžbe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PrikazStavkiNarudzbe()
        {
            String query = "SELECT s.stavka_id AS 'ID stavke', s.narudzbenica_id AS 'ID narudzbe', s.artikal_id AS 'ID artikla',s.kolicina AS 'Količina',"+
                " a.naziv_artikla AS 'Naziv artikla',a.cijena AS 'Cijena' FROM artikal a,stavka_narudzbenice s,narudzbenica n WHERE s.artikal_id=a.artikal_id "+
                " AND n.narudzbenica_id=s.narudzbenica_id AND s.narudzbenica_id='" + textBoxID.Text + "' AND n.kupac_id='" + kupacID + "'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridViewStavkeNarudžbe.DataSource = tabela;
                dataAdapter.Dispose();
                konekcija.Close();
                ModificirajGridView(dataGridViewNarudžbe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Total()
        {
            int ukupno = 0;
            String query = "SELECT sn.kolicina,a.cijena FROM stavka_narudzbenice sn,artikal a, narudzbenica n "+
                "WHERE n.narudzbenica_id=sn.narudzbenica_id AND sn.artikal_id=a.artikal_id AND "+
                "sn.narudzbenica_id='" + textBoxID.Text + "' AND n.kupac_id='" + kupacID + "'  ";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
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

        private void PrikazNarudžbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            PrikazStavkiNarudzbe();
            Total();
        }

        private void kreiranjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreiranjeNarudžbe kn = new KreiranjeNarudžbe();
            this.Hide();
            kn.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }


    }
}
