namespace Mapa_Kafića
{
    partial class EtiketaPrikaz
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
            this.enterEntery = new System.Windows.Forms.Button();
            this.deleteEntery = new System.Windows.Forms.Button();
            this.tipTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tipTable)).BeginInit();
            this.SuspendLayout();
            // 
            // enterEntery
            // 
            this.enterEntery.Location = new System.Drawing.Point(197, 226);
            this.enterEntery.Name = "enterEntery";
            this.enterEntery.Size = new System.Drawing.Size(75, 23);
            this.enterEntery.TabIndex = 5;
            this.enterEntery.Text = "Dodaj";
            this.enterEntery.UseVisualStyleBackColor = true;
            this.enterEntery.Click += new System.EventHandler(this.enterEntery_Click);
            // 
            // deleteEntery
            // 
            this.deleteEntery.Location = new System.Drawing.Point(12, 226);
            this.deleteEntery.Name = "deleteEntery";
            this.deleteEntery.Size = new System.Drawing.Size(75, 23);
            this.deleteEntery.TabIndex = 4;
            this.deleteEntery.Text = "Obriši";
            this.deleteEntery.UseVisualStyleBackColor = true;
            this.deleteEntery.Click += new System.EventHandler(this.deleteEntery_Click);
            // 
            // tipTable
            // 
            this.tipTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipTable.Location = new System.Drawing.Point(12, 12);
            this.tipTable.Name = "tipTable";
            this.tipTable.Size = new System.Drawing.Size(260, 150);
            this.tipTable.TabIndex = 3;
            // 
            // EtiketaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.enterEntery);
            this.Controls.Add(this.deleteEntery);
            this.Controls.Add(this.tipTable);
            this.Name = "EtiketaPrikaz";
            this.Text = "Prikaz Etiketa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EtiketaPrikaz_FormClosed);
            this.Load += new System.EventHandler(this.EtiketaPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterEntery;
        private System.Windows.Forms.Button deleteEntery;
        private System.Windows.Forms.DataGridView tipTable;
    }
}