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
    public partial class PrikazTabelarno : Form
    {
        public PrikazTabelarno()
        {
            InitializeComponent();
             
        }
        public void addToTable(getKaficInfo.Kafic kafana) {
            bool checkRez = false;
            if (kafana.rezervacije)
            {
                checkRez = true;
            }

            bool checkHend = false;
            if (kafana.hendikep)
            {
                checkHend = true;
            }
            tabela.Rows.Add(new object[]{kafana.oznakaLokala,kafana.imeKafica,kafana.tipKafica
            ,kafana.opisLokala,kafana.kapacitet,kafana.statusAlkohola,kafana.statusPusenja, kafana.rezervacije,
            kafana.hendikep,kafana.cene});
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
