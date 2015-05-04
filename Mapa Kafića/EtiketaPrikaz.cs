using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mapa_Kafića
{
    public partial class EtiketaPrikaz : Form
    {

        private bool isButtonPressed;
        public EtiketaPrikaz()
        {
            this.isButtonPressed = false;
            InitializeComponent();
            readTable();
        }

        private void readTable()
        {

            SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
            tip.TestConnection();
            DataTable t = tip.GetDataTable("SELECT etiketa FROM etiketa; ");
            tipTable.DataSource = t;
        }

        private void enterEntery_Click(object sender, EventArgs e)
        {
            isButtonPressed = true;
            DodajEtiketu t = new DodajEtiketu();
            t.Show();
            this.Close();
        }

        private void deleteEntery_Click(object sender, EventArgs e)
        {
            isButtonPressed = true;
            try
            {
                String wop = tipTable.Rows[tipTable.SelectedRows[0].Index].Cells[0].Value.ToString();
                SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
                tip.TestConnection();
                tip.Delete("Etiketa", "etiketa = '" + wop + "'");
                this.Close();
                EtiketaPrikaz p = new EtiketaPrikaz();
                p.Show();
            }
            catch (NullReferenceException n)
            {
                this.Close();
                EtiketaPrikaz p = new EtiketaPrikaz();
                p.Show();
            }
            catch (ArgumentOutOfRangeException a)
            {
                String wop = tipTable.Rows[0].Cells[0].Value.ToString();
                SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
                tip.TestConnection();
                tip.Delete("Etiketa", "etiketa = '" + wop + "'");
                this.Close();
                EtiketaPrikaz p = new EtiketaPrikaz();
                p.Show();
            }
           


        }

        private void EtiketaPrikaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isButtonPressed)
            {
                Pocetna p = new Pocetna();
                p.Show();
            }
        }

        private void EtiketaPrikaz_Load(object sender, EventArgs e)
        {

        }
    }
}
