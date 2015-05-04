using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Finisar.SQLite;

namespace Mapa_Kafića
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            readTable();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TipPrikaz t = new TipPrikaz();
            t.Show();
            this.Visible = false;
            
        }

        private void readTable()
        {

            SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
            tip.TestConnection();
            DataTable t = tip.GetDataTable("SELECT ime, oznaka FROM Lokal; ");
            lokaliList.DataSource = t;
        }
        
        private void Pocetak_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodavanjeKafica f = new DodavanjeKafica();
            f.Show();
            this.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EtiketaPrikaz t = new EtiketaPrikaz();
            t.Show();
            this.Visible = false;
        }

        private void Pocetna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

            }
}
