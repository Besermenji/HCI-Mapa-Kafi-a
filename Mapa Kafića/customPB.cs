using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mapa_Kafića
{
    public partial class customPB : PictureBox
    {

        ToolTip tt;
        private string name;
        public customPB(String name, String color, String ico, Point p)
        {
            InitializeComponent();
            Width = 32;
            Height = 32;
            BackColor = Color.FromName(color);
            ImageLocation = ico;
            Left = p.X - 16;
            Top = p.Y - 16;


            this.name = name;
            tt = new ToolTip();
            //The below are optional, of course,

            //tt.ToolTipIcon = ToolTipIcon.Info;
            
            tt.SetToolTip(this, name);


        }

        protected override void OnMouseHover(EventArgs e)
        {
            tt.Show(name,this);
            base.OnMouseHover(e);
        }
        
        
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            DodavanjeKafica k = new DodavanjeKafica();
            k.ShowDialog();
            base.OnMouseDoubleClick(e);
        }

        private DataTable getLokalInfo(String name) { return null; }
    }
}
