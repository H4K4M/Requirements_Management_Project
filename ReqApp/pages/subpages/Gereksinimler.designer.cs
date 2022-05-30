
namespace ReqApp.pages.subpages
{
    partial class Gereksinimler
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
            this.label1 = new System.Windows.Forms.Label();
            this.GereksinimAdiTextBox = new System.Windows.Forms.TextBox();
            this.GereksinimKoduTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AciklamaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YeniGereksinimButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gereksinimListView = new System.Windows.Forms.DataGridView();
            this.GereksinimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GereksinimAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GereksinimKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EklemeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Guncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gereksinimListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gereksinim Adı";
            // 
            // GereksinimAdiTextBox
            // 
            this.GereksinimAdiTextBox.Location = new System.Drawing.Point(49, 105);
            this.GereksinimAdiTextBox.Name = "GereksinimAdiTextBox";
            this.GereksinimAdiTextBox.Size = new System.Drawing.Size(318, 34);
            this.GereksinimAdiTextBox.TabIndex = 1;
            // 
            // GereksinimKoduTextBox
            // 
            this.GereksinimKoduTextBox.Location = new System.Drawing.Point(440, 105);
            this.GereksinimKoduTextBox.Name = "GereksinimKoduTextBox";
            this.GereksinimKoduTextBox.Size = new System.Drawing.Size(318, 34);
            this.GereksinimKoduTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gereksinim Kodu";
            // 
            // AciklamaTextBox
            // 
            this.AciklamaTextBox.Location = new System.Drawing.Point(49, 204);
            this.AciklamaTextBox.Multiline = true;
            this.AciklamaTextBox.Name = "AciklamaTextBox";
            this.AciklamaTextBox.Size = new System.Drawing.Size(318, 167);
            this.AciklamaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // YeniGereksinimButton
            // 
            this.YeniGereksinimButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.YeniGereksinimButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YeniGereksinimButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YeniGereksinimButton.Location = new System.Drawing.Point(440, 204);
            this.YeniGereksinimButton.Name = "YeniGereksinimButton";
            this.YeniGereksinimButton.Size = new System.Drawing.Size(318, 57);
            this.YeniGereksinimButton.TabIndex = 6;
            this.YeniGereksinimButton.Text = "Ekle";
            this.YeniGereksinimButton.UseVisualStyleBackColor = false;
            this.YeniGereksinimButton.Click += new System.EventHandler(this.YeniGereksinimButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(44, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gereksinim Listesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(43, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gereksinim Formu";
            // 
            // gereksinimListView
            // 
            this.gereksinimListView.AllowUserToAddRows = false;
            this.gereksinimListView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gereksinimListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gereksinimListView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gereksinimListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gereksinimListView.ColumnHeadersHeight = 30;
            this.gereksinimListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gereksinimListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GereksinimId,
            this.GereksinimAdi,
            this.GereksinimKodu,
            this.Aciklama,
            this.EklemeTarihi,
            this.Sil,
            this.Guncelle});
            this.gereksinimListView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gereksinimListView.Location = new System.Drawing.Point(49, 439);
            this.gereksinimListView.Margin = new System.Windows.Forms.Padding(5);
            this.gereksinimListView.Name = "gereksinimListView";
            this.gereksinimListView.RowHeadersVisible = false;
            this.gereksinimListView.RowHeadersWidth = 51;
            this.gereksinimListView.RowTemplate.Height = 24;
            this.gereksinimListView.Size = new System.Drawing.Size(1091, 454);
            this.gereksinimListView.TabIndex = 16;
            this.gereksinimListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gereksinimListView_CellContentClick);
            // 
            // GereksinimId
            // 
            this.GereksinimId.HeaderText = "Gereksinim Id";
            this.GereksinimId.MinimumWidth = 6;
            this.GereksinimId.Name = "GereksinimId";
            this.GereksinimId.Visible = false;
            this.GereksinimId.Width = 25;
            // 
            // GereksinimAdi
            // 
            this.GereksinimAdi.HeaderText = "Gereksinim Adi";
            this.GereksinimAdi.MinimumWidth = 6;
            this.GereksinimAdi.Name = "GereksinimAdi";
            this.GereksinimAdi.Width = 200;
            // 
            // GereksinimKodu
            // 
            this.GereksinimKodu.HeaderText = "Gereksinim Kodu";
            this.GereksinimKodu.MinimumWidth = 6;
            this.GereksinimKodu.Name = "GereksinimKodu";
            this.GereksinimKodu.Width = 210;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.MinimumWidth = 6;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Width = 200;
            // 
            // EklemeTarihi
            // 
            this.EklemeTarihi.HeaderText = "Ekleme Tarihi";
            this.EklemeTarihi.MinimumWidth = 6;
            this.EklemeTarihi.Name = "EklemeTarihi";
            this.EklemeTarihi.Width = 170;
            // 
            // Sil
            // 
            this.Sil.HeaderText = "Sil";
            this.Sil.MinimumWidth = 6;
            this.Sil.Name = "Sil";
            this.Sil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sil.Text = "Sil";
            this.Sil.UseColumnTextForButtonValue = true;
            this.Sil.Width = 150;
            // 
            // Guncelle
            // 
            this.Guncelle.HeaderText = "Güncelle";
            this.Guncelle.MinimumWidth = 6;
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Guncelle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseColumnTextForButtonValue = true;
            this.Guncelle.Width = 161;
            // 
            // Gereksinimler
            // 
            this.ClientSize = new System.Drawing.Size(1487, 933);
            this.Controls.Add(this.gereksinimListView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YeniGereksinimButton);
            this.Controls.Add(this.AciklamaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GereksinimKoduTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GereksinimAdiTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Gereksinimler";
            this.Load += new System.EventHandler(this.Gereksinimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gereksinimListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GereksinimAdiTextBox;
        private System.Windows.Forms.TextBox GereksinimKoduTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AciklamaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button YeniGereksinimButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gereksinimListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GereksinimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GereksinimAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GereksinimKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn EklemeTarihi;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        private System.Windows.Forms.DataGridViewButtonColumn Guncelle;
    }
}