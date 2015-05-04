namespace Mapa_Kafića
{
    partial class PrikazTabelarno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.OznakaKafica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeKafica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipKafica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisKafica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KapacitetLokala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAlkohola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPusenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervacije = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hendikepirani = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AccessibleName = "tejbl";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OznakaKafica,
            this.ImeKafica,
            this.TipKafica,
            this.OpisKafica,
            this.KapacitetLokala,
            this.StatusAlkohola,
            this.StatusPusenje,
            this.Rezervacije,
            this.Hendikepirani,
            this.Cena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabela.Location = new System.Drawing.Point(12, 12);
            this.tabela.Name = "tabela";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabela.Size = new System.Drawing.Size(710, 158);
            this.tabela.TabIndex = 0;
            this.tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OznakaKafica
            // 
            this.OznakaKafica.HeaderText = "Oznaka";
            this.OznakaKafica.Name = "OznakaKafica";
            this.OznakaKafica.ReadOnly = true;
            // 
            // ImeKafica
            // 
            this.ImeKafica.HeaderText = "Ime";
            this.ImeKafica.Name = "ImeKafica";
            this.ImeKafica.ReadOnly = true;
            // 
            // TipKafica
            // 
            this.TipKafica.HeaderText = "Tip";
            this.TipKafica.Name = "TipKafica";
            this.TipKafica.ReadOnly = true;
            // 
            // OpisKafica
            // 
            this.OpisKafica.HeaderText = "Opis";
            this.OpisKafica.Name = "OpisKafica";
            this.OpisKafica.ReadOnly = true;
            // 
            // KapacitetLokala
            // 
            this.KapacitetLokala.HeaderText = "Kapacitet";
            this.KapacitetLokala.Name = "KapacitetLokala";
            this.KapacitetLokala.ReadOnly = true;
            // 
            // StatusAlkohola
            // 
            this.StatusAlkohola.HeaderText = "StatusAlkohola";
            this.StatusAlkohola.Name = "StatusAlkohola";
            this.StatusAlkohola.ReadOnly = true;
            // 
            // StatusPusenje
            // 
            this.StatusPusenje.HeaderText = "StatusPusenja";
            this.StatusPusenje.Name = "StatusPusenje";
            this.StatusPusenje.ReadOnly = true;
            // 
            // Rezervacije
            // 
            this.Rezervacije.HeaderText = "Rezervacije?";
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.ReadOnly = true;
            this.Rezervacije.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rezervacije.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Hendikepirani
            // 
            this.Hendikepirani.HeaderText = "Hendikepirani?";
            this.Hendikepirani.Name = "Hendikepirani";
            this.Hendikepirani.ReadOnly = true;
            this.Hendikepirani.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hendikepirani.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 391);
            this.Controls.Add(this.tabela);
            this.Name = "Form2";
            this.Text = "Dodaj u mapu";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn OznakaKafica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeKafica;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipKafica;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisKafica;
        private System.Windows.Forms.DataGridViewTextBoxColumn KapacitetLokala;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAlkohola;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPusenje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rezervacije;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hendikepirani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;

    }
}