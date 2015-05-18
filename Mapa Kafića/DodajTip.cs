using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace Mapa_Kafića
{
    public partial class Tip : Form
    {

        bool succes;
        bool uspeh;
        //string fail;
        public Tip()
        {
            InitializeComponent();
            this.uspeh = true;
            this.succes = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tipoviTextBox.Focus();
            string folder = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\..\..\tipIcons\";
            string filter = "*.png";
            string[] files = Directory.GetFiles(folder, filter);

            foreach (String  file in files){
                ikonaComboBox.Items.Add(file);
            }

            
        }

        private void dodajTipButton_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(tipoviTextBox.Text))
            {
                tipToolTip.SetToolTip(tipoviTextBox, "Uesite bar jedan tip");
                tipToolTip.Show(tipToolTip.GetToolTip(tipoviTextBox), tipoviTextBox, 5000);
                tipoviTextBox.Focus();
            }
            else
            {
                string inputFile = "baza.s3db";
                string dbConnection = String.Format("Data Source={0}", inputFile);
                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();

                // Define the SQL Create table statement  
                string createLogTableSQL = "CREATE TABLE IF NOT EXISTS `Tip`" +
                                              "(`id`	INTEGER DEFAULT 0 PRIMARY KEY AUTOINCREMENT," +
                                               "`tip`	TEXT UNIQUE," +
                                               "'opis' TEXT,"
                                              + "'ikona' TEXT"
                                              + ");";

                using (SQLiteTransaction sqlTransaction = cnn.BeginTransaction())
                {
                    // Create the table  
                    SQLiteCommand createCommand = new SQLiteCommand(createLogTableSQL, cnn);
                    createCommand.ExecuteNonQuery();
                    createCommand.Dispose();
                    // Commit the changes into the database  
                    sqlTransaction.Commit();
                } // end using    

                string tip = tipoviTextBox.Text;





                string quary = "SELECT tip FROM Tip where tip ='" + tip.Trim() + "';";
                SQLiteCommand q = new SQLiteCommand(cnn);
                q.CommandText = quary;
                object res = q.ExecuteScalar();
                if (res == null)
                {


                    try
                    {
                        string sql = "insert into Tip (tip, opis, ikona) values ('" + tip.Trim() + "','" +
                            opisTipaTextBox.Text.Trim() + "','" + ikonaComboBox.Text.Trim() + "')";
                        SQLiteCommand mycommand = new SQLiteCommand(cnn);
                        //proveriti na sajtu
                        //mycommand.Parameters.Add(@name);
                        mycommand.CommandText = sql;
                        int rowsUpdated = mycommand.ExecuteNonQuery();
                    }
                    catch (SQLiteException sl)
                    {
                        sl.ToString();
                        throw;
                    }
                }
                



                cnn.Close();

                if (!uspeh)
                {
                    Tip t = new Tip();
                    t.Show();
                    System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                    ToolTip1.SetToolTip(t.tipoviTextBox, "test");

                }
                else
                {
                    this.Close();
                }


            } 
        }

        private void tipToolTip_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void Tip_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            //if (!succes)
            //{
                TipPrikaz p = new TipPrikaz();
                p.Show();
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tipoviTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ikonaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(ikonaComboBox.Text);
        }
    }
}
