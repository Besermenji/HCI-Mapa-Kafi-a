using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mapa_Kafića
{
    public partial class DodajEtiketu : Form
    {

        bool succes;
        bool uspeh;
        public DodajEtiketu()
        {

            InitializeComponent();
            this.uspeh = true;
            this.succes = true;
        }

        private void tipToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void DodajEtiketu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                EtiketaPrikaz p = new EtiketaPrikaz();
                p.Show();
            
        }

        private void dodajTipButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tipoviTextBox.Text)&&(string.IsNullOrEmpty(textBox1.Text))&& colorComboBox.SelectedIndex == -1)
            {
                tipToolTip.SetToolTip(tipoviTextBox, "Nije sve popunjeno.");
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
                string createLogTableSQL = "CREATE TABLE IF NOT EXISTS `Etiketa`" +
                                            "(`id`	INTEGER DEFAULT 0 PRIMARY KEY AUTOINCREMENT," +
                                            "`etiketa`	TEXT UNIQUE,"+
                                            "'opis' TEXT,"+
                                            "'boja' TEXT"
                                            +");";

                using (SQLiteTransaction sqlTransaction = cnn.BeginTransaction())
                {
                    // Create the table  
                    SQLiteCommand createCommand = new SQLiteCommand(createLogTableSQL, cnn);
                    createCommand.ExecuteNonQuery();
                    createCommand.Dispose();
                    // Commit the changes into the database  
                    sqlTransaction.Commit();
                } // end using    

                string etiketa = tipoviTextBox.Text;


                

                    string quary = "SELECT etiketa FROM Etiketa where etiketa ='" + etiketa.Trim() + "';";
                    SQLiteCommand q = new SQLiteCommand(cnn);
                    q.CommandText = quary;
                    object res = q.ExecuteScalar();
                    if (res == null)
                    {


                        try
                        {
                            string sql = "insert into Etiketa (etiketa, opis, boja) values ('" + etiketa.Trim() + "','" + textBox1.Text.Trim() + "','" + colorComboBox.SelectedItem.ToString().Trim() + "')";
                            SQLiteCommand mycommand = new SQLiteCommand(cnn);
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
                    DodajEtiketu t = new DodajEtiketu();
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

        private void DodajEtiketu_Load(object sender, EventArgs e)
        {

            tipoviTextBox.Focus();
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                   
                    colorComboBox.Items.Add(prop.Name);
                    
                    
            }

        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color p = Color.FromName(colorComboBox.Text);
            labelPrimer.ForeColor = p;
        }
    }
}
