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
            DataTable t = tip.GetDataTable("SELECT etiketa,boja FROM etiketa; ");

            //tipoviListView dodavanje ikona tipa + naziva tipa
            //ImageList ikone = new ImageList();

            //pravimo novi list view item i dodeljujemo mu boju
            foreach (DataRow row in t.Rows)
            {

                ListViewItem it = new ListViewItem();

                it.ForeColor = Color.FromName(row["boja"].ToString());
                it.Text = row["etiketa"].ToString();
                etiketeListView.Items.Add(it);

            }

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
                String wop = etiketeListView.SelectedItems[0].Text.Trim();

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
                //String wop = tipTable.Rows[0].Cells[0].Value.ToString();
                SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
                tip.TestConnection();
                //tip.Delete("Etiketa", "etiketa = '" + wop + "'");
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
            deleteEntery.Enabled = false;
        }

        private void etiketeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (etiketeListView.SelectedItems.Count == 0)
            {
                deleteEntery.Enabled = false;
            }
            else
                deleteEntery.Enabled = true;
        }
    }
}
