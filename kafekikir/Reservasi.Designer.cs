namespace kafekikir
{
    partial class Reservasi
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
            dgvTabel = new DataGridView();
            groupBox1 = new GroupBox();
            btnTambah = new Button();
            cmbWaktu = new ComboBox();
            cmbMeja = new ComboBox();
            txtNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCari = new Button();
            txtCari = new TextBox();
            cmbCariKategori = new ComboBox();
            groupBox3 = new GroupBox();
            btnHapus = new Button();
            button3 = new Button();
            buttonSimpan = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTabel).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTabel
            // 
            dgvTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabel.Location = new Point(293, 12);
            dgvTabel.Name = "dgvTabel";
            dgvTabel.Size = new Size(486, 426);
            dgvTabel.TabIndex = 0;
            dgvTabel.CellClick += dgvTabel_CellContentClick;
            dgvTabel.CellContentClick += dgvTabel_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Controls.Add(cmbWaktu);
            groupBox1.Controls.Add(cmbMeja);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 164);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(73, 133);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(79, 23);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click_1;
            // 
            // cmbWaktu
            // 
            cmbWaktu.FormattingEnabled = true;
            cmbWaktu.Items.AddRange(new object[] { "09 : 00 - 11 : 00", "12 : 00 - 14 : 00", "15 : 00 - 17 : 00", "18 : 00 - 20 : 00", "21 : 00 - 23 : 00" });
            cmbWaktu.Location = new Point(57, 104);
            cmbWaktu.Name = "cmbWaktu";
            cmbWaktu.Size = new Size(169, 23);
            cmbWaktu.TabIndex = 5;
            // 
            // cmbMeja
            // 
            cmbMeja.FormattingEnabled = true;
            cmbMeja.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbMeja.Location = new Point(57, 68);
            cmbMeja.Name = "cmbMeja";
            cmbMeja.Size = new Size(169, 23);
            cmbMeja.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(57, 29);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(169, 23);
            txtNama.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Waktu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Meja :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama :";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCari);
            groupBox2.Controls.Add(txtCari);
            groupBox2.Controls.Add(cmbCariKategori);
            groupBox2.Location = new Point(12, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 120);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // btnCari
            // 
            btnCari.Location = new Point(6, 87);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(220, 23);
            btnCari.TabIndex = 7;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(99, 43);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(127, 23);
            txtCari.TabIndex = 6;
            // 
            // cmbCariKategori
            // 
            cmbCariKategori.FormattingEnabled = true;
            cmbCariKategori.Items.AddRange(new object[] { "Nama", "Meja", "Waktu" });
            cmbCariKategori.Location = new Point(6, 42);
            cmbCariKategori.Name = "cmbCariKategori";
            cmbCariKategori.Size = new Size(87, 23);
            cmbCariKategori.TabIndex = 0;
            cmbCariKategori.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHapus);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(buttonSimpan);
            groupBox3.Controls.Add(buttonEdit);
            groupBox3.Location = new Point(12, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(243, 122);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit";
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(-1, 43);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(79, 23);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // button3
            // 
            button3.Location = new Point(170, 43);
            button3.Name = "button3";
            button3.Size = new Size(67, 23);
            button3.TabIndex = 4;
            button3.Text = "Reload";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(6, 83);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(231, 23);
            buttonSimpan.TabIndex = 3;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(84, 43);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(79, 23);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Reservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvTabel);
            Name = "Reservasi";
            Text = "/";
            Load += Reservasi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabel).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTabel;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox cmbWaktu;
        private ComboBox cmbMeja;
        private TextBox txtNama;
        private GroupBox groupBox2;
        private Button btnCari;
        private TextBox txtCari;
        private ComboBox cmbCariKategori;
        private GroupBox groupBox3;
        private Button buttonSimpan;
        private Button buttonEdit;
        private Button btnTambah;
        private Button button3;
        private Button buttonHapus;
        private Button btnHapus;
    }
}