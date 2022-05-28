
namespace ReqApp.pages.subpages
{
    partial class Calisanlar
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
            this.AdLabel = new System.Windows.Forms.Label();
            this.SoyAdlabel = new System.Windows.Forms.Label();
            this.Dogumlabel = new System.Windows.Forms.Label();
            this.Maaslabel = new System.Windows.Forms.Label();
            this.EkleButton = new System.Windows.Forms.Button();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.DogumTextBox = new System.Windows.Forms.TextBox();
            this.MaasTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CalisanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Guncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IptalButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTexBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdLabel.Location = new System.Drawing.Point(43, 58);
            this.AdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(41, 25);
            this.AdLabel.TabIndex = 7;
            this.AdLabel.Text = "Adı";
            // 
            // SoyAdlabel
            // 
            this.SoyAdlabel.AutoSize = true;
            this.SoyAdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoyAdlabel.Location = new System.Drawing.Point(43, 161);
            this.SoyAdlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoyAdlabel.Name = "SoyAdlabel";
            this.SoyAdlabel.Size = new System.Drawing.Size(69, 25);
            this.SoyAdlabel.TabIndex = 8;
            this.SoyAdlabel.Text = "Soyad";
            // 
            // Dogumlabel
            // 
            this.Dogumlabel.AutoSize = true;
            this.Dogumlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dogumlabel.Location = new System.Drawing.Point(453, 58);
            this.Dogumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dogumlabel.Name = "Dogumlabel";
            this.Dogumlabel.Size = new System.Drawing.Size(121, 25);
            this.Dogumlabel.TabIndex = 9;
            this.Dogumlabel.Text = "Doğum tarihi";
            // 
            // Maaslabel
            // 
            this.Maaslabel.AutoSize = true;
            this.Maaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maaslabel.Location = new System.Drawing.Point(453, 161);
            this.Maaslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Maaslabel.Name = "Maaslabel";
            this.Maaslabel.Size = new System.Drawing.Size(61, 25);
            this.Maaslabel.TabIndex = 10;
            this.Maaslabel.Text = "Maaş";
            // 
            // EkleButton
            // 
            this.EkleButton.BackColor = System.Drawing.Color.MediumPurple;
            this.EkleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EkleButton.Location = new System.Drawing.Point(48, 364);
            this.EkleButton.Margin = new System.Windows.Forms.Padding(4);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(474, 53);
            this.EkleButton.TabIndex = 11;
            this.EkleButton.Text = "Ekle";
            this.EkleButton.UseVisualStyleBackColor = false;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // AdTextBox
            // 
            this.AdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdTextBox.Location = new System.Drawing.Point(48, 97);
            this.AdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(309, 34);
            this.AdTextBox.TabIndex = 12;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoyadTextBox.Location = new System.Drawing.Point(46, 195);
            this.SoyadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(309, 34);
            this.SoyadTextBox.TabIndex = 13;
            // 
            // DogumTextBox
            // 
            this.DogumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogumTextBox.Location = new System.Drawing.Point(451, 97);
            this.DogumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DogumTextBox.Name = "DogumTextBox";
            this.DogumTextBox.Size = new System.Drawing.Size(297, 34);
            this.DogumTextBox.TabIndex = 14;
            // 
            // MaasTextBox
            // 
            this.MaasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaasTextBox.Location = new System.Drawing.Point(453, 195);
            this.MaasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaasTextBox.Name = "MaasTextBox";
            this.MaasTextBox.Size = new System.Drawing.Size(288, 34);
            this.MaasTextBox.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalisanId,
            this.Adi,
            this.Soyad,
            this.KullaniciAdi,
            this.Eposta,
            this.Dogum,
            this.Maas,
            this.Sil,
            this.Guncelle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Thistle;
            this.dataGridView1.Location = new System.Drawing.Point(48, 461);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1664, 554);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CalisanId
            // 
            this.CalisanId.HeaderText = "Id";
            this.CalisanId.MinimumWidth = 6;
            this.CalisanId.Name = "CalisanId";
            this.CalisanId.Visible = false;
            this.CalisanId.Width = 125;
            // 
            // Adi
            // 
            this.Adi.HeaderText = "Adı";
            this.Adi.MinimumWidth = 6;
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            this.Adi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Adi.Width = 150;
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Soyad.Width = 150;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.KullaniciAdi.MinimumWidth = 6;
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.ReadOnly = true;
            this.KullaniciAdi.Width = 150;
            // 
            // Eposta
            // 
            this.Eposta.HeaderText = "Eposta";
            this.Eposta.MinimumWidth = 6;
            this.Eposta.Name = "Eposta";
            this.Eposta.ReadOnly = true;
            this.Eposta.Width = 150;
            // 
            // Dogum
            // 
            this.Dogum.HeaderText = "Doğum tarihi";
            this.Dogum.MinimumWidth = 6;
            this.Dogum.Name = "Dogum";
            this.Dogum.ReadOnly = true;
            this.Dogum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dogum.Width = 150;
            // 
            // Maas
            // 
            this.Maas.HeaderText = "Maaş";
            this.Maas.MinimumWidth = 6;
            this.Maas.Name = "Maas";
            this.Maas.ReadOnly = true;
            this.Maas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Maas.Width = 125;
            // 
            // Sil
            // 
            this.Sil.HeaderText = "Sil";
            this.Sil.MinimumWidth = 6;
            this.Sil.Name = "Sil";
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
            this.Guncelle.Width = 150;
            // 
            // IptalButton
            // 
            this.IptalButton.BackColor = System.Drawing.Color.Red;
            this.IptalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IptalButton.Location = new System.Drawing.Point(530, 364);
            this.IptalButton.Margin = new System.Windows.Forms.Padding(4);
            this.IptalButton.Name = "IptalButton";
            this.IptalButton.Size = new System.Drawing.Size(219, 53);
            this.IptalButton.TabIndex = 17;
            this.IptalButton.Text = "İptal";
            this.IptalButton.UseVisualStyleBackColor = false;
            this.IptalButton.Click += new System.EventHandler(this.IptalButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(836, 97);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(289, 34);
            this.usernameTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(834, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(834, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Eposta";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(833, 195);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(292, 34);
            this.emailTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre";
            // 
            // passwordTexBox
            // 
            this.passwordTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTexBox.Location = new System.Drawing.Point(48, 292);
            this.passwordTexBox.Name = "passwordTexBox";
            this.passwordTexBox.PasswordChar = '*';
            this.passwordTexBox.Size = new System.Drawing.Size(285, 34);
            this.passwordTexBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(37, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Çalışanlar Formu";
            // 
            // Calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1905, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTexBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.IptalButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MaasTextBox);
            this.Controls.Add(this.DogumTextBox);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.EkleButton);
            this.Controls.Add(this.Maaslabel);
            this.Controls.Add(this.Dogumlabel);
            this.Controls.Add(this.SoyAdlabel);
            this.Controls.Add(this.AdLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calisanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calisanlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label SoyAdlabel;
        private System.Windows.Forms.Label Dogumlabel;
        private System.Windows.Forms.Label Maaslabel;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox DogumTextBox;
        private System.Windows.Forms.TextBox MaasTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button IptalButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTexBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalisanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maas;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        private System.Windows.Forms.DataGridViewButtonColumn Guncelle;
    }
}