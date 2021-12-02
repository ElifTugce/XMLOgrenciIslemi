
namespace Ornek1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLileDisariAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLileiceriVeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.listBoxASinifi = new System.Windows.Forms.ListBox();
            this.listBoxBSinifi = new System.Windows.Forms.ListBox();
            this.btnSagaGönder = new System.Windows.Forms.Button();
            this.btnHepsiniSagaGönder = new System.Windows.Forms.Button();
            this.btnSolaGönder = new System.Windows.Forms.Button();
            this.btnHepsiniSolaGonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSecmeliDers = new System.Windows.Forms.CheckBox();
            this.groupBoxSecmeliDers = new System.Windows.Forms.GroupBox();
            this.checkedListBoxSecmeliDers = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSecmeliDers.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLileDisariAktarToolStripMenuItem,
            this.xMLileiceriVeriAlToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // xMLileDisariAktarToolStripMenuItem
            // 
            this.xMLileDisariAktarToolStripMenuItem.Name = "xMLileDisariAktarToolStripMenuItem";
            this.xMLileDisariAktarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLileDisariAktarToolStripMenuItem.Text = "XML ile dışarı aktar";
            this.xMLileDisariAktarToolStripMenuItem.Click += new System.EventHandler(this.xMLileDisariAktarToolStripMenuItem_Click);
            // 
            // xMLileiceriVeriAlToolStripMenuItem
            // 
            this.xMLileiceriVeriAlToolStripMenuItem.Name = "xMLileiceriVeriAlToolStripMenuItem";
            this.xMLileiceriVeriAlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLileiceriVeriAlToolStripMenuItem.Text = "XML ile içeri veri al";
            this.xMLileiceriVeriAlToolStripMenuItem.Click += new System.EventHandler(this.xMLileiceriVeriAlToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(32, 33);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 20);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(32, 85);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(53, 20);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(32, 134);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(61, 20);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "D.Tarihi:";
            this.lblTarih.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(32, 182);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(89, 20);
            this.lblSinif.TabIndex = 5;
            this.lblSinif.Text = "Sınıf Seçimi:";
            this.lblSinif.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(127, 78);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(161, 27);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(127, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(161, 27);
            this.txtAd.TabIndex = 0;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(396, 96);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(94, 68);
            this.btnOgrenciEkle.TabIndex = 9;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(127, 174);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(161, 28);
            this.comboBoxSinif.TabIndex = 10;
            this.comboBoxSinif.Text = "Sınıfınızı Seçiniz...";
            this.comboBoxSinif.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxASinifi
            // 
            this.listBoxASinifi.FormattingEnabled = true;
            this.listBoxASinifi.ItemHeight = 20;
            this.listBoxASinifi.Location = new System.Drawing.Point(12, 329);
            this.listBoxASinifi.Name = "listBoxASinifi";
            this.listBoxASinifi.Size = new System.Drawing.Size(309, 164);
            this.listBoxASinifi.TabIndex = 11;
            // 
            // listBoxBSinifi
            // 
            this.listBoxBSinifi.FormattingEnabled = true;
            this.listBoxBSinifi.ItemHeight = 20;
            this.listBoxBSinifi.Location = new System.Drawing.Point(459, 329);
            this.listBoxBSinifi.Name = "listBoxBSinifi";
            this.listBoxBSinifi.Size = new System.Drawing.Size(304, 164);
            this.listBoxBSinifi.TabIndex = 12;
            // 
            // btnSagaGönder
            // 
            this.btnSagaGönder.Location = new System.Drawing.Point(343, 338);
            this.btnSagaGönder.Name = "btnSagaGönder";
            this.btnSagaGönder.Size = new System.Drawing.Size(94, 29);
            this.btnSagaGönder.TabIndex = 13;
            this.btnSagaGönder.Text = ">";
            this.btnSagaGönder.UseVisualStyleBackColor = true;
            this.btnSagaGönder.Click += new System.EventHandler(this.btnSagaGönder_Click);
            // 
            // btnHepsiniSagaGönder
            // 
            this.btnHepsiniSagaGönder.Location = new System.Drawing.Point(343, 373);
            this.btnHepsiniSagaGönder.Name = "btnHepsiniSagaGönder";
            this.btnHepsiniSagaGönder.Size = new System.Drawing.Size(94, 29);
            this.btnHepsiniSagaGönder.TabIndex = 14;
            this.btnHepsiniSagaGönder.Text = ">>";
            this.btnHepsiniSagaGönder.UseVisualStyleBackColor = true;
            this.btnHepsiniSagaGönder.Click += new System.EventHandler(this.btnHepsiniSagaGönder_Click);
            // 
            // btnSolaGönder
            // 
            this.btnSolaGönder.Location = new System.Drawing.Point(343, 408);
            this.btnSolaGönder.Name = "btnSolaGönder";
            this.btnSolaGönder.Size = new System.Drawing.Size(94, 29);
            this.btnSolaGönder.TabIndex = 15;
            this.btnSolaGönder.Text = "<";
            this.btnSolaGönder.UseVisualStyleBackColor = true;
            this.btnSolaGönder.Click += new System.EventHandler(this.btnSolaGönder_Click);
            // 
            // btnHepsiniSolaGonder
            // 
            this.btnHepsiniSolaGonder.Location = new System.Drawing.Point(343, 443);
            this.btnHepsiniSolaGonder.Name = "btnHepsiniSolaGonder";
            this.btnHepsiniSolaGonder.Size = new System.Drawing.Size(94, 29);
            this.btnHepsiniSolaGonder.TabIndex = 16;
            this.btnHepsiniSolaGonder.Text = "<<";
            this.btnHepsiniSolaGonder.UseVisualStyleBackColor = true;
            this.btnHepsiniSolaGonder.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSecmeliDers);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.lblSinif);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxSinif);
            this.groupBox1.Controls.Add(this.btnOgrenciEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 281);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxSecmeliDers
            // 
            this.checkBoxSecmeliDers.AutoSize = true;
            this.checkBoxSecmeliDers.Location = new System.Drawing.Point(127, 235);
            this.checkBoxSecmeliDers.Name = "checkBoxSecmeliDers";
            this.checkBoxSecmeliDers.Size = new System.Drawing.Size(272, 24);
            this.checkBoxSecmeliDers.TabIndex = 11;
            this.checkBoxSecmeliDers.Text = "Seçmeli ders almak istiyor musunuz?";
            this.checkBoxSecmeliDers.UseVisualStyleBackColor = true;
            this.checkBoxSecmeliDers.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxSecmeliDers
            // 
            this.groupBoxSecmeliDers.Controls.Add(this.checkedListBoxSecmeliDers);
            this.groupBoxSecmeliDers.Location = new System.Drawing.Point(570, 31);
            this.groupBoxSecmeliDers.Name = "groupBoxSecmeliDers";
            this.groupBoxSecmeliDers.Size = new System.Drawing.Size(187, 281);
            this.groupBoxSecmeliDers.TabIndex = 18;
            this.groupBoxSecmeliDers.TabStop = false;
            this.groupBoxSecmeliDers.Text = "Seçmeli Dersler";
            this.groupBoxSecmeliDers.Enter += new System.EventHandler(this.SecmeliDers_Enter);
            // 
            // checkedListBoxSecmeliDers
            // 
            this.checkedListBoxSecmeliDers.FormattingEnabled = true;
            this.checkedListBoxSecmeliDers.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Toplum Hizmetleri",
            "İtalyanca",
            "Halk Sağlığı",
            "Evrim Teorisi"});
            this.checkedListBoxSecmeliDers.Location = new System.Drawing.Point(15, 26);
            this.checkedListBoxSecmeliDers.Name = "checkedListBoxSecmeliDers";
            this.checkedListBoxSecmeliDers.Size = new System.Drawing.Size(150, 246);
            this.checkedListBoxSecmeliDers.TabIndex = 0;
            this.checkedListBoxSecmeliDers.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 522);
            this.Controls.Add(this.groupBoxSecmeliDers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHepsiniSolaGonder);
            this.Controls.Add(this.btnSolaGönder);
            this.Controls.Add(this.btnHepsiniSagaGönder);
            this.Controls.Add(this.btnSagaGönder);
            this.Controls.Add(this.listBoxBSinifi);
            this.Controls.Add(this.listBoxASinifi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Öğrenci Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSecmeliDers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.ListBox listBoxASinifi;
        private System.Windows.Forms.ListBox listBoxBSinifi;
        private System.Windows.Forms.Button btnSagaGönder;
        private System.Windows.Forms.Button btnHepsiniSagaGönder;
        private System.Windows.Forms.Button btnSolaGönder;
        private System.Windows.Forms.Button btnHepsiniSolaGonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSecmeliDers;
        private System.Windows.Forms.GroupBox groupBoxSecmeliDers;
        private System.Windows.Forms.CheckedListBox checkedListBoxSecmeliDers;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLileDisariAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLileiceriVeriAlToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

