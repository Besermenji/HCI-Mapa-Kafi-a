using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mapa_Kafića
{
    public partial class TipPrikaz : Form
    {
       private bool isButtonPressed;
        public TipPrikaz()
        {
            this.isButtonPressed = false;
            InitializeComponent();
            readTable();

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void readTable() {

            SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
            tip.TestConnection();
            DataTable t = tip.GetDataTable("SELECT tip,ikona FROM tip; ");
            
            //tipoviListView dodavanje ikona tipa + naziva tipa
            ImageList ikone = new ImageList();

            //dodamo sve ikone u lisu
            foreach (DataRow row in t.Rows)
            {
                String tip_row = row["tip"].ToString();
                String ico_row = row["ikona"].ToString();

                ikone.Images.Add(tip_row, Image.FromFile(ico_row));
            }

            //kazemo tipoviListView-u da koristi listu ikona
            tipoviListView.LargeImageList = ikone;

            foreach (DataRow row in t.Rows)
            {
                ListViewItem tmp = tipoviListView.Items.Add(row["tip"].ToString());
                tmp.ImageKey = row["tip"].ToString();
            }
        }

        private void TipPrikaz_Load(object sender, EventArgs e)
        {
            deleteEntery.Enabled = false;
        }

        private void enterEntery_Click(object sender, EventArgs e)
        {
            isButtonPressed = true;
            Tip t = new Tip();
            t.Show();
            this.Close();
        }

        private void TipPrikaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isButtonPressed)
            {
                Pocetna p = new Pocetna();
                p.Show();
            }

        }

        private void deleteEntery_Click(object sender, EventArgs e)
        {
            isButtonPressed = true;
            try
            {
                String wop = tipoviListView.SelectedItems[0].Text.Trim();
                SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
                tip.TestConnection();
                tip.Delete("Tip", "tip = '" + wop.Trim() + "'");
                this.Close();
                TipPrikaz p = new TipPrikaz();
                p.Show();
            }
            catch (NullReferenceException n)
            {
                this.Close();
                TipPrikaz p = new TipPrikaz();
                p.Show();
            }
            catch (ArgumentOutOfRangeException a) {
                //String wop = tipTable.Rows[0].Cells[0].Value.ToString();
                SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
                tip.TestConnection();
                //tip.Delete("Tip", "tip = '" + wop + "'");
                this.Close();
                TipPrikaz p = new TipPrikaz();
                p.Show();
            }
           


        }

        private void tipoviListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoviListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tipoviListView.SelectedItems.Count == 0)
            {
                deleteEntery.Enabled = false;
            }
            else
                deleteEntery.Enabled = true;
        }
    }
}
