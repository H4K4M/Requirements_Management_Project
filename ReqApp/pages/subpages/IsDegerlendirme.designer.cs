
namespace ReqApp.pages.subpages
{
    partial class IsDegerlendirme
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
            this.teslimlerListView = new System.Windows.Forms.DataGridView();
            this.GorevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GorevAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalisanAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TamamlanmamisCheckBox = new System.Windows.Forms.CheckBox();
            this.TamamlanmisCheckBox = new System.Windows.Forms.CheckBox();
            this.iyiYapilmisCheckBox = new System.Windows.Forms.CheckBox();
            this.ReddetButonu = new System.Windows.Forms.Button();
            this.onaylaButton = new System.Windows.Forms.Button();
            this.GorevLinkKopylaButton = new System.Windows.Forms.Button();
            this.gorevLinki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calisanTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedGorevAdiText = new System.Windows.Forms.TextBox();
            this.selectedGorevAciklamasiTextBox = new System.Windows.Forms.TextBox();
            this.selectedGorevGereksinimlerList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teslimlerListView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teslim Edilen Görev Listesi";
            // 
            // teslimlerListView
            // 
            this.teslimlerListView.AllowUserToAddRows = false;
            this.teslimlerListView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.teslimlerListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teslimlerListView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.teslimlerListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.teslimlerListView.ColumnHeadersHeight = 50;
            this.teslimlerListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GorevId,
            this.GorevAdi,
            this.CalisanAdi,
            this.TeslimTarihi});
            this.teslimlerListView.Location = new System.Drawing.Point(21, 72);
            this.teslimlerListView.Name = "teslimlerListView";
            this.teslimlerListView.ReadOnly = true;
            this.teslimlerListView.RowHeadersWidth = 51;
            this.teslimlerListView.RowTemplate.Height = 24;
            this.teslimlerListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teslimlerListView.Size = new System.Drawing.Size(896, 735);
            this.teslimlerListView.TabIndex = 9;
            this.teslimlerListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teslimlerListView_CellContentClick);
            // 
            // GorevId
            // 
            this.GorevId.HeaderText = "GorevId";
            this.GorevId.MinimumWidth = 6;
            this.GorevId.Name = "GorevId";
            this.GorevId.ReadOnly = true;
            this.GorevId.Visible = false;
            this.GorevId.Width = 125;
            // 
            // GorevAdi
            // 
            this.GorevAdi.HeaderText = "Görev";
            this.GorevAdi.MinimumWidth = 6;
            this.GorevAdi.Name = "GorevAdi";
            this.GorevAdi.ReadOnly = true;
            this.GorevAdi.Width = 300;
            // 
            // CalisanAdi
            // 
            this.CalisanAdi.HeaderText = "Çalışan";
            this.CalisanAdi.MinimumWidth = 6;
            this.CalisanAdi.Name = "CalisanAdi";
            this.CalisanAdi.ReadOnly = true;
            this.CalisanAdi.Width = 200;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.HeaderText = "Teslim Tarihi";
            this.TeslimTarihi.MinimumWidth = 6;
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.ReadOnly = true;
            this.TeslimTarihi.Width = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(931, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "İş Değerlendirme Formu";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.TamamlanmamisCheckBox);
            this.panel1.Controls.Add(this.TamamlanmisCheckBox);
            this.panel1.Controls.Add(this.iyiYapilmisCheckBox);
            this.panel1.Controls.Add(this.ReddetButonu);
            this.panel1.Controls.Add(this.onaylaButton);
            this.panel1.Controls.Add(this.GorevLinkKopylaButton);
            this.panel1.Controls.Add(this.gorevLinki);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.calisanTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.selectedGorevAdiText);
            this.panel1.Controls.Add(this.selectedGorevAciklamasiTextBox);
            this.panel1.Controls.Add(this.selectedGorevGereksinimlerList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(936, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 751);
            this.panel1.TabIndex = 7;
            // 
            // TamamlanmamisCheckBox
            // 
            this.TamamlanmamisCheckBox.AutoSize = true;
            this.TamamlanmamisCheckBox.Location = new System.Drawing.Point(287, 627);
            this.TamamlanmamisCheckBox.Name = "TamamlanmamisCheckBox";
            this.TamamlanmamisCheckBox.Size = new System.Drawing.Size(136, 21);
            this.TamamlanmamisCheckBox.TabIndex = 21;
            this.TamamlanmamisCheckBox.Text = "Tamamlanmamış";
            this.TamamlanmamisCheckBox.UseVisualStyleBackColor = true;
            this.TamamlanmamisCheckBox.CheckedChanged += new System.EventHandler(this.Tamamlanmamis_CheckedChanged);
            // 
            // TamamlanmisCheckBox
            // 
            this.TamamlanmisCheckBox.AutoSize = true;
            this.TamamlanmisCheckBox.Location = new System.Drawing.Point(158, 627);
            this.TamamlanmisCheckBox.Name = "TamamlanmisCheckBox";
            this.TamamlanmisCheckBox.Size = new System.Drawing.Size(117, 21);
            this.TamamlanmisCheckBox.TabIndex = 20;
            this.TamamlanmisCheckBox.Text = "Tamamlanmış";
            this.TamamlanmisCheckBox.UseVisualStyleBackColor = true;
            this.TamamlanmisCheckBox.CheckedChanged += new System.EventHandler(this.TamamlanmisCheckBox_CheckedChanged);
            // 
            // iyiYapilmisCheckBox
            // 
            this.iyiYapilmisCheckBox.AutoSize = true;
            this.iyiYapilmisCheckBox.Location = new System.Drawing.Point(50, 627);
            this.iyiYapilmisCheckBox.Name = "iyiYapilmisCheckBox";
            this.iyiYapilmisCheckBox.Size = new System.Drawing.Size(99, 21);
            this.iyiYapilmisCheckBox.TabIndex = 19;
            this.iyiYapilmisCheckBox.Text = "İyi Yapılmış";
            this.iyiYapilmisCheckBox.UseVisualStyleBackColor = true;
            this.iyiYapilmisCheckBox.CheckedChanged += new System.EventHandler(this.iyiYapilmisCheckBox_CheckedChanged);
            // 
            // ReddetButonu
            // 
            this.ReddetButonu.BackColor = System.Drawing.Color.Red;
            this.ReddetButonu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReddetButonu.Location = new System.Drawing.Point(331, 677);
            this.ReddetButonu.Name = "ReddetButonu";
            this.ReddetButonu.Size = new System.Drawing.Size(204, 58);
            this.ReddetButonu.TabIndex = 18;
            this.ReddetButonu.Text = "Reddet";
            this.ReddetButonu.UseVisualStyleBackColor = false;
            this.ReddetButonu.Click += new System.EventHandler(this.ReddetButonu_Click);
            // 
            // onaylaButton
            // 
            this.onaylaButton.BackColor = System.Drawing.Color.Blue;
            this.onaylaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.onaylaButton.Location = new System.Drawing.Point(52, 677);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(241, 58);
            this.onaylaButton.TabIndex = 17;
            this.onaylaButton.Text = "Onayla";
            this.onaylaButton.UseVisualStyleBackColor = false;
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // GorevLinkKopylaButton
            // 
            this.GorevLinkKopylaButton.BackColor = System.Drawing.Color.Red;
            this.GorevLinkKopylaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GorevLinkKopylaButton.Location = new System.Drawing.Point(443, 557);
            this.GorevLinkKopylaButton.Name = "GorevLinkKopylaButton";
            this.GorevLinkKopylaButton.Size = new System.Drawing.Size(92, 40);
            this.GorevLinkKopylaButton.TabIndex = 16;
            this.GorevLinkKopylaButton.Text = "Kopyla";
            this.GorevLinkKopylaButton.UseVisualStyleBackColor = false;
            this.GorevLinkKopylaButton.Click += new System.EventHandler(this.GorevLinkKopylaButton_Click);
            // 
            // gorevLinki
            // 
            this.gorevLinki.BackColor = System.Drawing.Color.White;
            this.gorevLinki.Enabled = false;
            this.gorevLinki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gorevLinki.ForeColor = System.Drawing.Color.Black;
            this.gorevLinki.Location = new System.Drawing.Point(50, 557);
            this.gorevLinki.Multiline = true;
            this.gorevLinki.Name = "gorevLinki";
            this.gorevLinki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gorevLinki.Size = new System.Drawing.Size(387, 40);
            this.gorevLinki.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(48, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Görev Linki";
            // 
            // calisanTextBox
            // 
            this.calisanTextBox.BackColor = System.Drawing.Color.White;
            this.calisanTextBox.Enabled = false;
            this.calisanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisanTextBox.ForeColor = System.Drawing.Color.Black;
            this.calisanTextBox.Location = new System.Drawing.Point(52, 138);
            this.calisanTextBox.Multiline = true;
            this.calisanTextBox.Name = "calisanTextBox";
            this.calisanTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calisanTextBox.Size = new System.Drawing.Size(485, 40);
            this.calisanTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Çalışan";
            // 
            // selectedGorevAdiText
            // 
            this.selectedGorevAdiText.BackColor = System.Drawing.Color.White;
            this.selectedGorevAdiText.Enabled = false;
            this.selectedGorevAdiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGorevAdiText.ForeColor = System.Drawing.Color.Black;
            this.selectedGorevAdiText.Location = new System.Drawing.Point(52, 47);
            this.selectedGorevAdiText.Multiline = true;
            this.selectedGorevAdiText.Name = "selectedGorevAdiText";
            this.selectedGorevAdiText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectedGorevAdiText.Size = new System.Drawing.Size(485, 40);
            this.selectedGorevAdiText.TabIndex = 11;
            // 
            // selectedGorevAciklamasiTextBox
            // 
            this.selectedGorevAciklamasiTextBox.BackColor = System.Drawing.Color.White;
            this.selectedGorevAciklamasiTextBox.Enabled = false;
            this.selectedGorevAciklamasiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGorevAciklamasiTextBox.ForeColor = System.Drawing.Color.Black;
            this.selectedGorevAciklamasiTextBox.Location = new System.Drawing.Point(52, 232);
            this.selectedGorevAciklamasiTextBox.Multiline = true;
            this.selectedGorevAciklamasiTextBox.Name = "selectedGorevAciklamasiTextBox";
            this.selectedGorevAciklamasiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectedGorevAciklamasiTextBox.Size = new System.Drawing.Size(485, 71);
            this.selectedGorevAciklamasiTextBox.TabIndex = 9;
            // 
            // selectedGorevGereksinimlerList
            // 
            this.selectedGorevGereksinimlerList.BackColor = System.Drawing.Color.White;
            this.selectedGorevGereksinimlerList.Enabled = false;
            this.selectedGorevGereksinimlerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGorevGereksinimlerList.ForeColor = System.Drawing.Color.Black;
            this.selectedGorevGereksinimlerList.FormattingEnabled = true;
            this.selectedGorevGereksinimlerList.ItemHeight = 22;
            this.selectedGorevGereksinimlerList.Location = new System.Drawing.Point(52, 369);
            this.selectedGorevGereksinimlerList.Name = "selectedGorevGereksinimlerList";
            this.selectedGorevGereksinimlerList.ScrollAlwaysVisible = true;
            this.selectedGorevGereksinimlerList.Size = new System.Drawing.Size(485, 136);
            this.selectedGorevGereksinimlerList.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gereksinimler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Görev Açıklamasi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(50, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Görev";
            // 
            // IsDegerlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 1031);
            this.Controls.Add(this.teslimlerListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IsDegerlendirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IsDegerlendirme";
            ((System.ComponentModel.ISupportInitialize)(this.teslimlerListView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView teslimlerListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalisanAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeslimTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox selectedGorevAdiText;
        private System.Windows.Forms.TextBox selectedGorevAciklamasiTextBox;
        private System.Windows.Forms.ListBox selectedGorevGereksinimlerList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GorevLinkKopylaButton;
        private System.Windows.Forms.TextBox gorevLinki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox calisanTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReddetButonu;
        private System.Windows.Forms.Button onaylaButton;
        private System.Windows.Forms.CheckBox TamamlanmamisCheckBox;
        private System.Windows.Forms.CheckBox TamamlanmisCheckBox;
        private System.Windows.Forms.CheckBox iyiYapilmisCheckBox;
    }
}