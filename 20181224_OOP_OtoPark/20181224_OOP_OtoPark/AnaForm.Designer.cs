namespace _20181224_OOP_OtoPark
{
    partial class AnaForm
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
            this.grpAracInfo1 = new System.Windows.Forms.GroupBox();
            this.chkAbone = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRapor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAracInfo = new System.Windows.Forms.GroupBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAbone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAracInfo1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grpAracInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAracInfo1
            // 
            this.grpAracInfo1.Controls.Add(this.chkAbone);
            this.grpAracInfo1.Controls.Add(this.btnGiris);
            this.grpAracInfo1.Controls.Add(this.cmbSinif);
            this.grpAracInfo1.Controls.Add(this.cmbmarka);
            this.grpAracInfo1.Controls.Add(this.label3);
            this.grpAracInfo1.Controls.Add(this.txtPlaka);
            this.grpAracInfo1.Controls.Add(this.label2);
            this.grpAracInfo1.Controls.Add(this.label1);
            this.grpAracInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAracInfo1.Location = new System.Drawing.Point(12, 12);
            this.grpAracInfo1.Name = "grpAracInfo1";
            this.grpAracInfo1.Size = new System.Drawing.Size(245, 266);
            this.grpAracInfo1.TabIndex = 0;
            this.grpAracInfo1.TabStop = false;
            this.grpAracInfo1.Text = "Araç Girişi";
            // 
            // chkAbone
            // 
            this.chkAbone.AutoSize = true;
            this.chkAbone.Location = new System.Drawing.Point(17, 204);
            this.chkAbone.Name = "chkAbone";
            this.chkAbone.Size = new System.Drawing.Size(86, 28);
            this.chkAbone.TabIndex = 3;
            this.chkAbone.Text = "Abone";
            this.chkAbone.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(109, 198);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(110, 39);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Araç Girişi";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(86, 146);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(133, 32);
            this.cmbSinif.TabIndex = 2;
            // 
            // cmbmarka
            // 
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(86, 92);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(133, 32);
            this.cmbmarka.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sınıfı";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(86, 44);
            this.txtPlaka.Mask = "00 LL 0000";
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(133, 29);
            this.txtPlaka.TabIndex = 0;
            this.txtPlaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaka_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // lstAraclar
            // 
            this.lstAraclar.ContextMenuStrip = this.contextMenuStrip1;
            this.lstAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.ItemHeight = 24;
            this.lstAraclar.Location = new System.Drawing.Point(272, 23);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(481, 340);
            this.lstAraclar.TabIndex = 1;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Location = new System.Drawing.Point(272, 369);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(481, 48);
            this.btnRapor.TabIndex = 0;
            this.btnRapor.Text = "RAPOR";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(308, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 64);
            this.label4.TabIndex = 3;
            this.label4.Text = "DEYNEKÇİ PARKING";
            // 
            // grpAracInfo
            // 
            this.grpAracInfo.BackColor = System.Drawing.Color.Yellow;
            this.grpAracInfo.Controls.Add(this.lblUcret);
            this.grpAracInfo.Controls.Add(this.lblSure);
            this.grpAracInfo.Controls.Add(this.label9);
            this.grpAracInfo.Controls.Add(this.lblAbone);
            this.grpAracInfo.Controls.Add(this.label8);
            this.grpAracInfo.Controls.Add(this.lblMarka);
            this.grpAracInfo.Controls.Add(this.label7);
            this.grpAracInfo.Controls.Add(this.lblPlaka);
            this.grpAracInfo.Controls.Add(this.label6);
            this.grpAracInfo.Controls.Add(this.label5);
            this.grpAracInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAracInfo.Location = new System.Drawing.Point(12, 284);
            this.grpAracInfo.Name = "grpAracInfo";
            this.grpAracInfo.Size = new System.Drawing.Size(245, 217);
            this.grpAracInfo.TabIndex = 4;
            this.grpAracInfo.TabStop = false;
            this.grpAracInfo.Text = "Araç Bilgileri";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(93, 181);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(36, 24);
            this.lblUcret.TabIndex = 0;
            this.lblUcret.Text = "0 ₺";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(94, 143);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(61, 24);
            this.lblSure.TabIndex = 0;
            this.lblSure.Text = "0 Saat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ücret";
            // 
            // lblAbone
            // 
            this.lblAbone.AutoSize = true;
            this.lblAbone.Location = new System.Drawing.Point(93, 107);
            this.lblAbone.Name = "lblAbone";
            this.lblAbone.Size = new System.Drawing.Size(67, 24);
            this.lblAbone.TabIndex = 0;
            this.lblAbone.Text = "Abone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Süre";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(94, 68);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(61, 24);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Abone";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(93, 31);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(108, 24);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "00 XX 0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Plaka";
            // 
            // AnaForm
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 513);
            this.Controls.Add(this.grpAracInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.lstAraclar);
            this.Controls.Add(this.grpAracInfo1);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAracInfo1.ResumeLayout(false);
            this.grpAracInfo1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpAracInfo.ResumeLayout(false);
            this.grpAracInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAracInfo1;
        private System.Windows.Forms.CheckBox chkAbone;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpAracInfo;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAbone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}

