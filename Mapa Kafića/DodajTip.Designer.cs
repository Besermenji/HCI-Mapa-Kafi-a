namespace Mapa_Kafića
{
    partial class Tip
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
            this.components = new System.ComponentModel.Container();
            this.dodajTipButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoviTextBox = new System.Windows.Forms.TextBox();
            this.tipToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dodajTipButton
            // 
            this.dodajTipButton.Location = new System.Drawing.Point(197, 226);
            this.dodajTipButton.Name = "dodajTipButton";
            this.dodajTipButton.Size = new System.Drawing.Size(75, 23);
            this.dodajTipButton.TabIndex = 0;
            this.dodajTipButton.Text = "Dodaj";
            this.dodajTipButton.UseVisualStyleBackColor = true;
            this.dodajTipButton.Click += new System.EventHandler(this.dodajTipButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(267, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj tip(ove) lokala. Ukoliko se dodaje više tipova odvajanje vršiti zarezom.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tipoviTextBox
            // 
            this.tipoviTextBox.Location = new System.Drawing.Point(15, 57);
            this.tipoviTextBox.Multiline = true;
            this.tipoviTextBox.Name = "tipoviTextBox";
            this.tipoviTextBox.Size = new System.Drawing.Size(249, 149);
            this.tipoviTextBox.TabIndex = 2;
            this.tipoviTextBox.TextChanged += new System.EventHandler(this.tipoviTextBox_TextChanged);
            // 
            // tipToolTip
            // 
            this.tipToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.tipToolTip_Popup);
            // 
            // Tip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tipoviTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajTipButton);
            this.Name = "Tip";
            this.Text = "Dodaj tip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tip_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajTipButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipoviTextBox;
        private System.Windows.Forms.ToolTip tipToolTip;
    }
}