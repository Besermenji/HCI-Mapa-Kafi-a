namespace Mapa_Kafića
{
    partial class TipPrikaz
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
            this.tipTable = new System.Windows.Forms.DataGridView();
            this.deleteEntery = new System.Windows.Forms.Button();
            this.enterEntery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tipTable
            // 
            this.tipTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipTable.Location = new System.Drawing.Point(12, 12);
            this.tipTable.Name = "tipTable";
            this.tipTable.Size = new System.Drawing.Size(260, 150);
            this.tipTable.TabIndex = 0;
            this.tipTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deleteEntery
            // 
            this.deleteEntery.Location = new System.Drawing.Point(12, 226);
            this.deleteEntery.Name = "deleteEntery";
            this.deleteEntery.Size = new System.Drawing.Size(75, 23);
            this.deleteEntery.TabIndex = 1;
            this.deleteEntery.Text = "Obriši";
            this.deleteEntery.UseVisualStyleBackColor = true;
            this.deleteEntery.Click += new System.EventHandler(this.deleteEntery_Click);
            // 
            // enterEntery
            // 
            this.enterEntery.Location = new System.Drawing.Point(197, 226);
            this.enterEntery.Name = "enterEntery";
            this.enterEntery.Size = new System.Drawing.Size(75, 23);
            this.enterEntery.TabIndex = 2;
            this.enterEntery.Text = "Dodaj";
            this.enterEntery.UseVisualStyleBackColor = true;
            this.enterEntery.Click += new System.EventHandler(this.enterEntery_Click);
            // 
            // TipPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.enterEntery);
            this.Controls.Add(this.deleteEntery);
            this.Controls.Add(this.tipTable);
            this.Name = "TipPrikaz";
            this.Text = "Prikaz Tipova";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TipPrikaz_FormClosed);
            this.Load += new System.EventHandler(this.TipPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tipTable;
        private System.Windows.Forms.Button deleteEntery;
        private System.Windows.Forms.Button enterEntery;

    }
}