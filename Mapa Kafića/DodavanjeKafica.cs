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
    public partial class DodavanjeKafica : Form
    {
        
        List<getKaficInfo.Kafic> kaf;
        private String icoPath;
               public DodavanjeKafica()
        {
            InitializeComponent();
            this.kaf = new List<getKaficInfo.Kafic>();
            this.icoPath = "";
            Enabled = true; 
   
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            izaberiIkonuButton.Enabled = false;
            //inicijalizacija alkoholnog box-a
            AlkoholcomboBox.Visible = false;
            AlkoholcomboBox.Items.Add("Služi do 23h.");
            AlkoholcomboBox.Items.Add("Služi i kasno noću.");

            //inicijalizacija pusackog box-a
            pusenjeKomboBox.Visible = false;
            pusenjeKomboBox.Items.Add("Dozvoljeno samo u bašti.");
            pusenjeKomboBox.Items.Add("Izdvojena prostorija za pušače.");
            pusenjeKomboBox.Items.Add("Podeljen deo za pušače.");
            pusenjeKomboBox.Items.Add("Pušenje dozvoljeno svuda.");

            //fokus na prvo
            ImeLokalaTextBox.Focus();

            //cene kombo box
            //ceneComboBox.Visible = false;
            ceneComboBox.Items.Add("Visoke cene.");
            ceneComboBox.Items.Add("Srednje visoke cene.");
            ceneComboBox.Items.Add("Prosečne cene.");
            ceneComboBox.Items.Add("Niske cene.");

            //inicijalizacija tip kombo boxa
            //draw som base shit
            //wop wop wop
            SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
            tip.TestConnection();
            DataTable t = tip.GetDataTable("SELECT tip FROM Tip; ");

            for (int i = 0; i < t.Rows.Count; i++) {
                tipComboBox.Items.Add(t.Rows[i]["tip"]);
            }

            //inishlajz det etiket niga list

            SQLiteDatabase etiketa = new SQLiteDatabase("", "baza.s3db");
            tip.TestConnection();
            DataTable etik = tip.GetDataTable("SELECT etiketa FROM Etiketa; ");

            for (int i = 0; i < etik.Rows.Count; i++)
            {
                etiketeListBox.Items.Add(etik.Rows[i]["etiketa"]);
            }

            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipLokalaTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ImeLokalaTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tipLokalaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                OpisLokalatextBox.Focus();
        }

        private void ImeLokalaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
               oznakaLokalaTextBox.Focus();
        }

        private void oznakaLokalaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                tipComboBox.Focus();
        }

        private void OpisLokalatextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                textBox1.Focus();
            }
        }

        private void alkoholCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alkoholCheckBox.Checked == true)
            {
                AlkoholcomboBox.Visible = true;
                AlkoholcomboBox.Focus();
                AlkoholcomboBox.DroppedDown = true;
                alkoholCheckBox.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                AlkoholcomboBox.Visible = false;
                alkoholCheckBox.FlatStyle = FlatStyle.Popup;
                pusenjeCheckBox.Focus();
            }
            

            
            
        }

       

        private void AlkoholcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AlkoholcomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                pusenjeCheckBox.Focus();
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                pusenjeCheckBox.FlatStyle = FlatStyle.Flat;
                this.Refresh();
            }
        }

        private void pusenjeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pusenjeCheckBox.Checked == true)
            {
                pusenjeKomboBox.Visible = true;
                pusenjeKomboBox.Focus();
                pusenjeKomboBox.DroppedDown = true;
                pusenjeCheckBox.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                pusenjeKomboBox.Visible = false;
                pusenjeCheckBox.FlatStyle = FlatStyle.Popup;
            }
        }

        private void pusenjeKomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                rezervacijeCheckBox.Focus();
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                rezervacijeCheckBox.FlatStyle = FlatStyle.Flat;
                this.Refresh();
            }
        }

        private void rezervacijeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rezervacijeCheckBox.Checked == true)
            {
                rezervacijeCheckBox.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                rezervacijeCheckBox.FlatStyle = FlatStyle.Popup;
            }
        }

        private void alkoholCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                pusenjeCheckBox.Focus();
                alkoholCheckBox.FlatStyle = FlatStyle.Popup;
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                pusenjeCheckBox.FlatStyle = FlatStyle.Flat;
                this.Refresh();
            }
        }

        private void pusenjeCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                rezervacijeCheckBox.Focus();
                pusenjeCheckBox.FlatStyle = FlatStyle.Popup;
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                rezervacijeCheckBox.FlatStyle = FlatStyle.Flat;
                this.Refresh();
            }
        }

        private void rezervacijeCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                HendikepCheckBox.Focus();
                rezervacijeCheckBox.FlatStyle = FlatStyle.Popup;
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                HendikepCheckBox.FlatStyle = FlatStyle.Flat;
                this.Refresh();
            }
        }

        private void HendikepCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                ceneComboBox.Focus();
                HendikepCheckBox.FlatStyle = FlatStyle.Popup;
                ceneComboBox.DroppedDown = true;
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                //CheckBox.FlatStyle = FlatStyle.Flat;
                //this.Refresh();
            }
        }

        private void ceneComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                informacijeLokalButton.Focus();
                //rezervacijeCheckBox.FlatStyle = FlatStyle.Popup;
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                //HendikepCheckBox.FlatStyle = FlatStyle.Flat;
                this.Refresh();
            }
        }

        private void OpisLokalatextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void ImeLokalaTextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ImeLokalaTextBox.Text)){
                ImeLokalaerrorProvider.Icon = Properties.Resources.err;
                ImeLokalaerrorProvider.SetError(ImeLokalaTextBox, "Unesite ime lokala");
                ImeLokalaTextBox.Focus();
            }
            else{
                ImeLokalaerrorProvider.Icon = Properties.Resources.ok;
                ImeLokalaerrorProvider.SetError(ImeLokalaTextBox, "Odlično!");
            }
        }

        private void oznakaLokalaTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oznakaLokalaTextBox.Text))
            {
                OznakaerrorProvider.Icon = Properties.Resources.err;
            OznakaerrorProvider.SetError(oznakaLokalaTextBox, "Unesite oznaku lokala");
                oznakaLokalaTextBox.Focus();
            }
            else
            {
                    OznakaerrorProvider.Icon = Properties.Resources.ok;
                OznakaerrorProvider.SetError(oznakaLokalaTextBox, "Odlično!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
               
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                alkoholCheckBox.Focus();
                //alkoholCheckBox.ForeColor = Color.Black;
                //alkoholCheckBox.BackColor = Color.Black;
                alkoholCheckBox.FlatStyle = FlatStyle.Flat;
                this.Refresh();
            }
        }

        

        private void OpisLokalatextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OpisLokalatextBox.Text))
            {
                OpisLokalaError.Icon = Properties.Resources.err;
                OpisLokalaError.SetError(OpisLokalatextBox, "Unesite opis lokala");
                OpisLokalatextBox.Focus();
            }
            else
            {
                OpisLokalaError.Icon = Properties.Resources.ok;
                OpisLokalaError.SetError(OpisLokalatextBox, "Odlično!");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                kapacitetError.Icon = Properties.Resources.err;
                kapacitetError.SetError(textBox1, "Unesite kapacitet lokala");
                textBox1.Focus();
            }
            else
            {
                kapacitetError.Icon = Properties.Resources.ok;
                kapacitetError.SetError(textBox1, "Odlično!");
            }
        }

        private void informacijeLokalButton_Click(object sender, EventArgs e)
        {
            //getKaficInfo.Kafic kafanica = new getKaficInfo.Kafic();
            String imeKafica = ImeLokalaTextBox.Text;
            String tipKafica = tipComboBox.Text;
            String oznakaLokala = oznakaLokalaTextBox.Text;
            String opisLokala = OpisLokalatextBox.Text;
            int kapacitet = int.Parse(textBox1.Text);
            
            String statusAlkohola;
            if (alkoholCheckBox.Checked == true)
            {
                statusAlkohola = AlkoholcomboBox.Text;
            }
            else
            {
                statusAlkohola = "Ne toči alkohol.";
            }

            String statusPusenja;
            if (pusenjeCheckBox.Checked == true)
            {
               statusPusenja = pusenjeKomboBox.Text;
            }
            else
            {
                statusPusenja = "Nije dozvoljeno pušenje.";
            }

            int rezervacije;
            if (rezervacijeCheckBox.Checked == true)
            {
                rezervacije = 1;
            }
            else
            {
                rezervacije = 0;
            }

            
            int hendikep;
            if (HendikepCheckBox.Checked == true)
            {
               hendikep = 1;
            }
            else
            {
               hendikep = 0;
            }

            String cene  = ceneComboBox.Text;

            int[] wop = new int[etiketeListBox.SelectedItems.Count];
            String etikete = "";
            if(etiketeListBox.SelectedItems.Count > 0){
                for (int i = 0; i < etiketeListBox.SelectedItems.Count; i++) {
                    wop[i] = etiketeListBox.SelectedIndices[i];
                }
            }

            for (int i = 0; i < wop.Length; i++) {
                etikete += etiketeListBox.Items[wop[i]]+", ";
            }

            
            String datum = dateTimePicker1.Value.ToString();

            SQLiteDatabase lokali = new SQLiteDatabase("", "baza.s3db");
            
            lokali.ExecuteNonQuery("CREATE TABLE IF NOT EXISTS `Lokal`" +
                                        "(`id`	INTEGER DEFAULT 0 PRIMARY KEY AUTOINCREMENT," +
                                        "`ime`	TEXT UNIQUE," +
                                        "`tip`	TEXT," +
                                        "`oznaka`	TEXT UNIQUE," +
                                        "`opis`	TEXT," +
                                        "`kapacitet`	INTEGER," +
                                        "`etikete`	TEXT," +
                                        "`alkohol`	TEXT," +
                                        "`pusenje`	TEXT," +
                                        "`rezervacije`	INTEGER," +
                                        "`hendikep`	INTEGER," +
                                        "`kat_cena`	TEXT," +
                                        "`ikona`	TEXT," +
                                        "`datum`	TEXT ," +
                                        "`na_tabeli`	INTEGER, " +
                                        "`x`	INTEGER, " +
                                        "`y`	INTEGER " +
                                        ");");


            

            Dictionary<String, String> za_tabelu = new Dictionary<string, string>();
            za_tabelu.Add("ime", imeKafica);
            za_tabelu.Add("tip", tipKafica);
            za_tabelu.Add("oznaka", oznakaLokala);
            za_tabelu.Add("opis", opisLokala);
            za_tabelu.Add("kapacitet", kapacitet.ToString());
            za_tabelu.Add("etikete", etikete);
            za_tabelu.Add("alkohol", statusAlkohola);
            za_tabelu.Add("pusenje", statusPusenja);
            za_tabelu.Add("rezervacije", rezervacije.ToString());
            za_tabelu.Add("hendikep", hendikep.ToString());
            za_tabelu.Add("kat_cena", cene);
            za_tabelu.Add("ikona", icoPath);
            za_tabelu.Add("datum", datum);
            za_tabelu.Add("na_tabeli", "0");
            za_tabelu.Add("x","-1");
            za_tabelu.Add("y", "-1");
            lokali.Insert("lokal", za_tabelu);


            
            this.Close();
            
            



        }





        public Pocetna p { get; set; }

        private void DodavanjeKafica_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Pocetna p = new Pocetna();
            //p.Show();
          /*  Pocetna p = (Pocetna)Application.OpenForms[0];
            p.clearTable();
            p.readTable();
            p.refreshList();
            p.Refresh();*/
        }

        private void tipComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tipComboBox.Text))
            {
                tipLokalaError.Icon = Properties.Resources.err;
                tipLokalaError.SetError(tipComboBox, "Izaberite tip lokala");
                tipComboBox.Focus();
            }
            else
            {
                tipLokalaError.Icon = Properties.Resources.ok;
                tipLokalaError.SetError(tipComboBox, "Odlično!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void etiketeListBox_Leave(object sender, EventArgs e)
        {
            if (etiketeListBox.SelectedIndex == -1)
            {
                etiketeErrorProvider.Icon = Properties.Resources.err;
                etiketeErrorProvider.SetError(etiketeListBox, "Izaberite makar jednu stvar sa liste");
                etiketeListBox.Focus();
            }
            else
            {
                etiketeErrorProvider.Icon = Properties.Resources.ok;
                etiketeErrorProvider.SetError(etiketeListBox, "Odlično!");
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now.Date)
            {
                datumErrorProvider.Icon = Properties.Resources.err;
                datumErrorProvider.SetError(dateTimePicker1, "Nemoguće otvoriti kafic u prošlosti.");
                dateTimePicker1.Focus();
            }
            else
            {
                datumErrorProvider.Icon = Properties.Resources.ok;
                datumErrorProvider.SetError(dateTimePicker1, "Odlično!");
            }
        }

        private void ceneComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ceneComboBox.Text))
            {
                kategorijaCenaError.Icon = Properties.Resources.err;
                kategorijaCenaError.SetError(ceneComboBox, "Izaberite kategoriju cena.");
                ceneComboBox.Focus();
            }
            else
            {
                kategorijaCenaError.Icon = Properties.Resources.ok;
                kategorijaCenaError.SetError(ceneComboBox, "Odlično!");
                izaberiIkonuButton.Enabled = true;
                izaberiIkonuButton.Focus();
            }
        }

        private void izaberiIkonuButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            //op.FileName = "*.ico"
            op.Filter = " Icon Files|*.ico";
            op.ShowDialog();

            icoPath = op.FileName;
            
        }
    }
}
namespace getKaficInfo {

    public class Kafic {
        
        

        public Kafic() { 
       
        }


        public String kapacitet
        {
            get;
            set;
        }
        
        public String imeKafica
        {
            get;
            set;
        }
        public String tipKafica
        {
            get;
            set;
        }

        public String oznakaLokala
        {
            get;
            set;
        }

        public String opisLokala
        {
            get;
            set;
        }

        public String statusAlkohola
        {
            get;
            set;
        }

        public String statusPusenja
        {
            get;
            set;
        }

        public bool rezervacije
        {
            get;
            set;
        }
        public bool hendikep
        {
            get;
            set;

        }
        public String cene
        {
            get;
            set;
        }

    }
}

