using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
//using Finisar.SQLite;

namespace Mapa_Kafića
{
    public partial class Pocetna : Form
    {
        String imageLocation;
        //ListViewItem item;
        String itemName;
        String itemColor;
        
        public Pocetna()
        {
            InitializeComponent();
            readTable();
            this.imageLocation = "";
          //  this.item = new ListViewItem();
            //this.itemName = "";
          //  this.itemColor = "";
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
            DataTable t = tip.GetDataTable("SELECT ime,etikete,tip,ikona FROM Lokal; ");
            //lokaliList.DataSource = t;
            //ovde smestamo listu ikona;
            ImageList ikone = new ImageList();

            //pravimo i string za boju i ujedno je trazimo kada trazimo tip
            String[] boje = new String[t.Rows.Count];
            int i = 0;
            foreach (DataRow r in t.Rows) {
               //ako ikona ne postoji stavljamo ikonu tipa
                if (r["ikona"].Equals("")) {
                    DataTable tipTabela = tip.GetDataTable("SELECT ikona FROM tip where tip='" + r["tip"] + "';");
                    DataRow tr = tipTabela.Rows[0];
                    ikone.Images.Add(r["ime"].ToString(), Image.FromFile(tr["ikona"].ToString()));
                }
                else
                {

                    //TODO 1: ukoliko postoji ikona
                }
                //svakako iz ove tabele vucemo boju
                DataTable etiketaTabela = tip.GetDataTable("SELECT boja FROM etiketa WHERE etiketa = '" + r["etikete"].ToString().Split(',')[0] + "'");
                DataRow boj = etiketaTabela.Rows[0];
                String boja = boj["boja"].ToString();
                boje[i] = boja;
                i++;
                
            }
        
            //hocemo da povezemo ikone i text
            lokaliListView.LargeImageList = ikone;
            
            int j = 0;
            //sve povezemo zajedno
            foreach (DataRow r in t.Rows)
            {

                ListViewItem it = lokaliListView.Items.Add(r["ime"].ToString());
                it.ForeColor = Color.FromName(boje[j]);
                j++;
                it.ImageKey = r["ime"].ToString();


                

            }

        
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

        private void Pocetna_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= mapPicture.Location.X && x <= mapPicture.Location.X + mapPicture.Width && y >= mapPicture.Location.Y && y <= mapPicture.Location.Y + mapPicture.Height)
            //???
            {

                Point point = mapPicture.PointToClient(Cursor.Position);

                //PictureBox pb = new PictureBox();
                //ovde boja i sve
                //pb.BackColor = Color.FromName(itemColor);
                //pb.Width = 32;
                //pb.Height = 32;
                //pb.ImageLocation = "D:\\HCI\\HCI-Mapa-Kafi-a\\Mapa Kafića\\tipIcons\\8.png";
                //pb.Left = point.X;
                //pb.Top = point.Y;
                ////Size s = new Size(32,32);
                customPB pb = new customPB(itemName,itemColor,imageLocation,point);
                
                mapPicture.Controls.Add(pb);

            }
        }

        private void Pocetna_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lokaliListView_MouseDown(object sender, MouseEventArgs e)
        {
            //System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor; 
             button1.DoDragDrop(button1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        
        }

        private void lokaliListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lokaliListView.SelectedItems.Count == 1)
            {
                //if (item == null)
                ListViewItem item = lokaliListView.SelectedItems[0];
                itemName = item.Text;
                itemColor = getLokalColor(itemName);
                imageLocation = getLokalImage(itemName);
            }
        }

        private String getLokalColor(String name)
        {
            SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
            tip.TestConnection();
            DataTable t = tip.GetDataTable("SELECT ime, etikete, tip, ikona FROM Lokal WHERE ime ='"+name+"'; ");
            DataTable e = tip.GetDataTable("SELECT boja FROM etiketa WHERE etiketa ='" + t.Rows[0]["etikete"].ToString().Split(',')[0] + "'; ");


            return e.Rows[0]["boja"].ToString();
        }

        private String getLokalImage(string name) {

            SQLiteDatabase tip = new SQLiteDatabase("", "baza.s3db");
            tip.TestConnection();
  
            DataTable t = tip.GetDataTable("SELECT ime, etikete, tip, ikona FROM Lokal WHERE ime ='" + name + "'; ");

            if (t.Rows[0]["ikona"].Equals(""))
            {
                DataTable tipTabela = tip.GetDataTable("SELECT ikona FROM tip where tip='" + t.Rows[0]["tip"] + "';");
                return tipTabela.Rows[0]["ikona"].ToString();
            }
            else
            {
                return t.Rows[0]["ikona"].ToString();
            }
        }

        private void lokaliListView_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                e.UseDefaultCursors = false;
                Cursor.Current = Cursors.Hand;
            }
            else if (e.Effect == DragDropEffects.Copy)
            {
                e.UseDefaultCursors = false;
                Cursor.Current = Cursors.Cross;
            }
            else if (e.Effect == DragDropEffects.None)
            {
                e.UseDefaultCursors = false;
                Cursor.Current = Cursors.No;
            }
            else
            {
                e.UseDefaultCursors = true;
            }
        }

            }
}
