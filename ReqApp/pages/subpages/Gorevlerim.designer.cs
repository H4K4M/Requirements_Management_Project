
namespace ReqApp.pages.subpages
{
    partial class Gorevlerim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeslimEtButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedGorevGereksinimlerList = new System.Windows.Forms.ListBox();
            this.selectedGorevAciklamasiTextBox = new System.Windows.Forms.TextBox();
            this.gorevLinkTextBox = new System.Windows.Forms.TextBox();
            this.selectedGoreAdiText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gorevlerimListView = new System.Windows.Forms.DataGridView();
            this.GorevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GorevAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerimListView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.selectedGoreAdiText);
            this.panel1.Controls.Add(this.gorevLinkTextBox);
            this.panel1.Controls.Add(this.selectedGorevAciklamasiTextBox);
            this.panel1.Controls.Add(this.selectedGorevGereksinimlerList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TeslimEtButonu);
            this.panel1.Location = new System.Drawing.Point(677, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 751);
            this.panel1.TabIndex = 3;
            // 
            // TeslimEtButonu
            // 
            this.TeslimEtButonu.BackColor = System.Drawing.Color.DodgerBlue;
            this.TeslimEtButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeslimEtButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeslimEtButonu.ForeColor = System.Drawing.Color.White;
            this.TeslimEtButonu.Location = new System.Drawing.Point(49, 677);
            this.TeslimEtButonu.Name = "TeslimEtButonu";
            this.TeslimEtButonu.Size = new System.Drawing.Size(495, 58);
            this.TeslimEtButonu.TabIndex = 0;
            this.TeslimEtButonu.Text = "Teslim Et";
            this.TeslimEtButonu.UseVisualStyleBackColor = false;
            this.TeslimEtButonu.Click += new System.EventHandler(this.TeslimEtButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(672, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görev Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(41, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Görevlerim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Görev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Görev Açıklamasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gereksinimler";
            // 
            // selectedGorevGereksinimlerList
            // 
            this.selectedGorevGereksinimlerList.BackColor = System.Drawing.Color.White;
            this.selectedGorevGereksinimlerList.Enabled = false;
            this.selectedGorevGereksinimlerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGorevGereksinimlerList.ForeColor = System.Drawing.Color.Black;
            this.selectedGorevGereksinimlerList.FormattingEnabled = true;
            this.selectedGorevGereksinimlerList.ItemHeight = 22;
            this.selectedGorevGereksinimlerList.Location = new System.Drawing.Point(52, 376);
            this.selectedGorevGereksinimlerList.Name = "selectedGorevGereksinimlerList";
            this.selectedGorevGereksinimlerList.ScrollAlwaysVisible = true;
            this.selectedGorevGereksinimlerList.Size = new System.Drawing.Size(485, 180);
            this.selectedGorevGereksinimlerList.TabIndex = 8;
            // 
            // selectedGorevAciklamasiTextBox
            // 
            this.selectedGorevAciklamasiTextBox.BackColor = System.Drawing.Color.White;
            this.selectedGorevAciklamasiTextBox.Enabled = false;
            this.selectedGorevAciklamasiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGorevAciklamasiTextBox.ForeColor = System.Drawing.Color.Black;
            this.selectedGorevAciklamasiTextBox.Location = new System.Drawing.Point(52, 173);
            this.selectedGorevAciklamasiTextBox.Multiline = true;
            this.selectedGorevAciklamasiTextBox.Name = "selectedGorevAciklamasiTextBox";
            this.selectedGorevAciklamasiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectedGorevAciklamasiTextBox.Size = new System.Drawing.Size(485, 101);
            this.selectedGorevAciklamasiTextBox.TabIndex = 9;
            // 
            // gorevLinkTextBox
            // 
            this.gorevLinkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gorevLinkTextBox.Location = new System.Drawing.Point(52, 624);
            this.gorevLinkTextBox.Name = "gorevLinkTextBox";
            this.gorevLinkTextBox.Size = new System.Drawing.Size(485, 28);
            this.gorevLinkTextBox.TabIndex = 10;
            // 
            // selectedGoreAdiText
            // 
            this.selectedGoreAdiText.BackColor = System.Drawing.Color.White;
            this.selectedGoreAdiText.Enabled = false;
            this.selectedGoreAdiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGoreAdiText.ForeColor = System.Drawing.Color.Black;
            this.selectedGoreAdiText.Location = new System.Drawing.Point(52, 60);
            this.selectedGoreAdiText.Multiline = true;
            this.selectedGoreAdiText.Name = "selectedGoreAdiText";
            this.selectedGoreAdiText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectedGoreAdiText.Size = new System.Drawing.Size(485, 40);
            this.selectedGoreAdiText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aşağıda yaptığın görevin linkini koyun";
            // 
            // gorevlerimListView
            // 
            this.gorevlerimListView.AllowUserToAddRows = false;
            this.gorevlerimListView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gorevlerimListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gorevlerimListView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gorevlerimListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gorevlerimListView.ColumnHeadersHeight = 50;
            this.gorevlerimListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GorevId,
            this.GorevAdi});
            this.gorevlerimListView.Location = new System.Drawing.Point(46, 72);
            this.gorevlerimListView.Name = "gorevlerimListView";
            this.gorevlerimListView.ReadOnly = true;
            this.gorevlerimListView.RowHeadersWidth = 51;
            this.gorevlerimListView.RowTemplate.Height = 24;
            this.gorevlerimListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gorevlerimListView.Size = new System.Drawing.Size(605, 735);
            this.gorevlerimListView.TabIndex = 5;
            this.gorevlerimListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gorevlerimListView_CellContentClick);
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
            // Gorevlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 948);
            this.Controls.Add(this.gorevlerimListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Gorevlerim";
            this.Text = "Gorevlerim";
            this.Load += new System.EventHandler(this.Gorevlerim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerimListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selectedGoreAdiText;
        private System.Windows.Forms.TextBox gorevLinkTextBox;
        private System.Windows.Forms.TextBox selectedGorevAciklamasiTextBox;
        private System.Windows.Forms.ListBox selectedGorevGereksinimlerList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TeslimEtButonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gorevlerimListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevAdi;
    }
}