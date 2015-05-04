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
            DataTable t = tip.GetDataTable("SELECT tip FROM tip; ");
            tipTable.DataSource = t;
        }

        private void TipPrikaz_Load(object sender, EventArgs e)
        {

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
                String wop = tipTable.Rows[tipTable.SelectedRows[0].Index].Cells[0].Value.ToString();
                SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
                tip.TestConnection();
                tip.Delete("Tip", "tip = '" + wop + "'");
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
                String wop = tipTable.Rows[0].Cells[0].Value.ToString();
                SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
                tip.TestConnection();
                tip.Delete("Tip", "tip = '" + wop + "'");
                this.Close();
                TipPrikaz p = new TipPrikaz();
                p.Show();
            }
           


        }
    }
}
