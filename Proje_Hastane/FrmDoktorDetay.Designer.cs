﻿namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSıyad = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RcSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnDuyurlar = new System.Windows.Forms.Button();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.BtnInternet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSıyad);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // LblAdSıyad
            // 
            this.LblAdSıyad.AutoSize = true;
            this.LblAdSıyad.Location = new System.Drawing.Point(118, 98);
            this.LblAdSıyad.Name = "LblAdSıyad";
            this.LblAdSıyad.Size = new System.Drawing.Size(76, 23);
            this.LblAdSıyad.TabIndex = 6;
            this.LblAdSıyad.Text = "Null Null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(118, 50);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 7;
            this.LblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad Soyad:";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Location = new System.Drawing.Point(44, 50);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(68, 23);
            this.tc.TabIndex = 4;
            this.tc.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RcSikayet);
            this.groupBox2.Location = new System.Drawing.Point(26, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(353, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 427);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // RcSikayet
            // 
            this.RcSikayet.Location = new System.Drawing.Point(10, 30);
            this.RcSikayet.Name = "RcSikayet";
            this.RcSikayet.Size = new System.Drawing.Size(289, 96);
            this.RcSikayet.TabIndex = 9;
            this.RcSikayet.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnInternet);
            this.groupBox4.Controls.Add(this.BtnCıkıs);
            this.groupBox4.Controls.Add(this.BtnDuyurlar);
            this.groupBox4.Controls.Add(this.BtnGuncelle);
            this.groupBox4.Location = new System.Drawing.Point(26, 372);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 153);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(10, 30);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(134, 35);
            this.BtnGuncelle.TabIndex = 0;
            this.BtnGuncelle.Text = "Bilgi Düzenle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnDuyurlar
            // 
            this.BtnDuyurlar.Location = new System.Drawing.Point(150, 30);
            this.BtnDuyurlar.Name = "BtnDuyurlar";
            this.BtnDuyurlar.Size = new System.Drawing.Size(134, 35);
            this.BtnDuyurlar.TabIndex = 1;
            this.BtnDuyurlar.Text = "Duyurular";
            this.BtnDuyurlar.UseVisualStyleBackColor = true;
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.Location = new System.Drawing.Point(150, 80);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(134, 35);
            this.BtnCıkıs.TabIndex = 2;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = true;
            // 
            // BtnInternet
            // 
            this.BtnInternet.Location = new System.Drawing.Point(6, 80);
            this.BtnInternet.Name = "BtnInternet";
            this.BtnInternet.Size = new System.Drawing.Size(134, 35);
            this.BtnInternet.TabIndex = 3;
            this.BtnInternet.Text = "İnternet";
            this.BtnInternet.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 514);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSıyad;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox RcSikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnInternet;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.Button BtnDuyurlar;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}