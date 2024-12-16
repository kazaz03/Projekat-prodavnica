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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public static String kupacID;
       public static String konekcioniString = "Server=localhost; Port=3306; " +
       "Database=projekat_baza; Uid=root; Pwd=1234";

       private void buttonPrijava_Click(object sender, EventArgs e)
       {
           errorProvider1.Clear();
           String korisnickoIme = textBoxIme.Text;
           String sifra = textBoxŠifra.Text;
           String query = "SELECT CONCAT(ime,' ',prezime),pass,kupac_id FROM kupac WHERE user='" + korisnickoIme + "'";

           try
           {
               MySqlConnection konekcija = new MySqlConnection(konekcioniString);
               konekcija.Open();
               MySqlCommand cmd = new MySqlCommand(query, konekcija);
               MySqlDataReader reader;
               reader = cmd.ExecuteReader();
               reader.Read();

               if (!reader.HasRows)
               {
                   errorProvider1.SetError(textBoxIme, "Pogrešno korisničko ime.");
               }
               else 
               {
                   String imeprez = reader[0].ToString();
                   String pass = reader[1].ToString();
                   kupacID = reader[2].ToString();

                   if (sifra == pass)
                   {
                       if (kupacID == "1")
                       {
                           MessageBox.Show("Uspješno ste se logovali Administratore " + imeprez);
                           KreiranjeKupca kr = new KreiranjeKupca();
                           this.Hide();
                           kr.Show();                         
                       }
                       else
                       {
                           MessageBox.Show("Uspješno ste se logovali " + imeprez);
                           KreiranjeNarudžbe kn = new KreiranjeNarudžbe();
                           this.Hide();
                           kn.Show();
                       }
                   }
                   else {
                       errorProvider1.SetError(textBoxŠifra, "Pogrešan password.");
                   }


               }
               reader.Close();
               konekcija.Close();
           }
           catch (Exception ex)
           {
               
               MessageBox.Show(ex.Message);
           }
       }

       private void Form1_FormClosed(object sender, FormClosedEventArgs e)
       {
           Application.Exit();
       }





    }
}
