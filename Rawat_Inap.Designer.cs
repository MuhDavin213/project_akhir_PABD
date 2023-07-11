namespace project_akhir
{
    partial class Rawat_Inap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.puskesmas_superDataSet = new project_akhir.Puskesmas_superDataSet();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamarTableAdapter = new project_akhir.Puskesmas_superDataSetTableAdapters.KamarTableAdapter();
            this.idkamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nokamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.puskesmas_superDataSet1 = new project_akhir.Puskesmas_superDataSet1();
            this.jadwalPengurusKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwal_Pengurus_KamarTableAdapter = new project_akhir.Puskesmas_superDataSet1TableAdapters.Jadwal_Pengurus_KamarTableAdapter();
            this.idjadwalpenguruskamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idperawatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkamarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.puskesmas_superDataSet2 = new project_akhir.Puskesmas_superDataSet2();
            this.perawatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perawatTableAdapter = new project_akhir.Puskesmas_superDataSet2TableAdapters.PerawatTableAdapter();
            this.idperawatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaperawatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.puskesmas_superDataSet3 = new project_akhir.Puskesmas_superDataSet3();
            this.jadwalPerawatPasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwal_Perawat_PasienTableAdapter = new project_akhir.Puskesmas_superDataSet3TableAdapters.Jadwal_Perawat_PasienTableAdapter();
            this.idjadwalperawatpasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hariDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jammulaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamselesaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idperawatDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPengurusKamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPerawatPasienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 157);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kamar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(437, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 196);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daftar Perawat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jadwal Pengurus Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jadwal Pengurus Kamar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(9, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 172);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Controls.Add(this.dataGridView4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(443, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 172);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkamarDataGridViewTextBoxColumn,
            this.nokamarDataGridViewTextBoxColumn,
            this.tipeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kamarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 74);
            this.dataGridView1.TabIndex = 1;
            // 
            // puskesmas_superDataSet
            // 
            this.puskesmas_superDataSet.DataSetName = "Puskesmas_superDataSet";
            this.puskesmas_superDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "Kamar";
            this.kamarBindingSource.DataSource = this.puskesmas_superDataSet;
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
            // 
            // idkamarDataGridViewTextBoxColumn
            // 
            this.idkamarDataGridViewTextBoxColumn.DataPropertyName = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn.HeaderText = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkamarDataGridViewTextBoxColumn.Name = "idkamarDataGridViewTextBoxColumn";
            this.idkamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // nokamarDataGridViewTextBoxColumn
            // 
            this.nokamarDataGridViewTextBoxColumn.DataPropertyName = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.HeaderText = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nokamarDataGridViewTextBoxColumn.Name = "nokamarDataGridViewTextBoxColumn";
            this.nokamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipeDataGridViewTextBoxColumn
            // 
            this.tipeDataGridViewTextBoxColumn.DataPropertyName = "tipe";
            this.tipeDataGridViewTextBoxColumn.HeaderText = "tipe";
            this.tipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipeDataGridViewTextBoxColumn.Name = "tipeDataGridViewTextBoxColumn";
            this.tipeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjadwalpenguruskamarDataGridViewTextBoxColumn,
            this.hariDataGridViewTextBoxColumn,
            this.idperawatDataGridViewTextBoxColumn,
            this.idkamarDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.jadwalPengurusKamarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(398, 101);
            this.dataGridView2.TabIndex = 3;
            // 
            // puskesmas_superDataSet1
            // 
            this.puskesmas_superDataSet1.DataSetName = "Puskesmas_superDataSet1";
            this.puskesmas_superDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalPengurusKamarBindingSource
            // 
            this.jadwalPengurusKamarBindingSource.DataMember = "Jadwal_Pengurus_Kamar";
            this.jadwalPengurusKamarBindingSource.DataSource = this.puskesmas_superDataSet1;
            // 
            // jadwal_Pengurus_KamarTableAdapter
            // 
            this.jadwal_Pengurus_KamarTableAdapter.ClearBeforeFill = true;
            // 
            // idjadwalpenguruskamarDataGridViewTextBoxColumn
            // 
            this.idjadwalpenguruskamarDataGridViewTextBoxColumn.DataPropertyName = "id_jadwal_pengurus_kamar";
            this.idjadwalpenguruskamarDataGridViewTextBoxColumn.HeaderText = "id_jadwal_pengurus_kamar";
            this.idjadwalpenguruskamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idjadwalpenguruskamarDataGridViewTextBoxColumn.Name = "idjadwalpenguruskamarDataGridViewTextBoxColumn";
            this.idjadwalpenguruskamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // hariDataGridViewTextBoxColumn
            // 
            this.hariDataGridViewTextBoxColumn.DataPropertyName = "hari";
            this.hariDataGridViewTextBoxColumn.HeaderText = "hari";
            this.hariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hariDataGridViewTextBoxColumn.Name = "hariDataGridViewTextBoxColumn";
            this.hariDataGridViewTextBoxColumn.Width = 125;
            // 
            // idperawatDataGridViewTextBoxColumn
            // 
            this.idperawatDataGridViewTextBoxColumn.DataPropertyName = "id_perawat";
            this.idperawatDataGridViewTextBoxColumn.HeaderText = "id_perawat";
            this.idperawatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idperawatDataGridViewTextBoxColumn.Name = "idperawatDataGridViewTextBoxColumn";
            this.idperawatDataGridViewTextBoxColumn.Width = 125;
            // 
            // idkamarDataGridViewTextBoxColumn1
            // 
            this.idkamarDataGridViewTextBoxColumn1.DataPropertyName = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn1.HeaderText = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idkamarDataGridViewTextBoxColumn1.Name = "idkamarDataGridViewTextBoxColumn1";
            this.idkamarDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idperawatDataGridViewTextBoxColumn1,
            this.namaperawatDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noteleponDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.perawatBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(20, 43);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(303, 102);
            this.dataGridView3.TabIndex = 2;
            // 
            // puskesmas_superDataSet2
            // 
            this.puskesmas_superDataSet2.DataSetName = "Puskesmas_superDataSet2";
            this.puskesmas_superDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perawatBindingSource
            // 
            this.perawatBindingSource.DataMember = "Perawat";
            this.perawatBindingSource.DataSource = this.puskesmas_superDataSet2;
            // 
            // perawatTableAdapter
            // 
            this.perawatTableAdapter.ClearBeforeFill = true;
            // 
            // idperawatDataGridViewTextBoxColumn1
            // 
            this.idperawatDataGridViewTextBoxColumn1.DataPropertyName = "id_perawat";
            this.idperawatDataGridViewTextBoxColumn1.HeaderText = "id_perawat";
            this.idperawatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idperawatDataGridViewTextBoxColumn1.Name = "idperawatDataGridViewTextBoxColumn1";
            this.idperawatDataGridViewTextBoxColumn1.Width = 125;
            // 
            // namaperawatDataGridViewTextBoxColumn
            // 
            this.namaperawatDataGridViewTextBoxColumn.DataPropertyName = "nama_perawat";
            this.namaperawatDataGridViewTextBoxColumn.HeaderText = "nama_perawat";
            this.namaperawatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaperawatDataGridViewTextBoxColumn.Name = "namaperawatDataGridViewTextBoxColumn";
            this.namaperawatDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // noteleponDataGridViewTextBoxColumn
            // 
            this.noteleponDataGridViewTextBoxColumn.DataPropertyName = "no_telepon";
            this.noteleponDataGridViewTextBoxColumn.HeaderText = "no_telepon";
            this.noteleponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteleponDataGridViewTextBoxColumn.Name = "noteleponDataGridViewTextBoxColumn";
            this.noteleponDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjadwalperawatpasienDataGridViewTextBoxColumn,
            this.hariDataGridViewTextBoxColumn1,
            this.jammulaiDataGridViewTextBoxColumn,
            this.jamselesaiDataGridViewTextBoxColumn,
            this.idperawatDataGridViewTextBoxColumn2,
            this.idpasienDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.jadwalPerawatPasienBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(14, 43);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(328, 101);
            this.dataGridView4.TabIndex = 4;
            // 
            // puskesmas_superDataSet3
            // 
            this.puskesmas_superDataSet3.DataSetName = "Puskesmas_superDataSet3";
            this.puskesmas_superDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalPerawatPasienBindingSource
            // 
            this.jadwalPerawatPasienBindingSource.DataMember = "Jadwal_Perawat_Pasien";
            this.jadwalPerawatPasienBindingSource.DataSource = this.puskesmas_superDataSet3;
            // 
            // jadwal_Perawat_PasienTableAdapter
            // 
            this.jadwal_Perawat_PasienTableAdapter.ClearBeforeFill = true;
            // 
            // idjadwalperawatpasienDataGridViewTextBoxColumn
            // 
            this.idjadwalperawatpasienDataGridViewTextBoxColumn.DataPropertyName = "id_jadwal_perawat_pasien";
            this.idjadwalperawatpasienDataGridViewTextBoxColumn.HeaderText = "id_jadwal_perawat_pasien";
            this.idjadwalperawatpasienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idjadwalperawatpasienDataGridViewTextBoxColumn.Name = "idjadwalperawatpasienDataGridViewTextBoxColumn";
            this.idjadwalperawatpasienDataGridViewTextBoxColumn.Width = 125;
            // 
            // hariDataGridViewTextBoxColumn1
            // 
            this.hariDataGridViewTextBoxColumn1.DataPropertyName = "hari";
            this.hariDataGridViewTextBoxColumn1.HeaderText = "hari";
            this.hariDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hariDataGridViewTextBoxColumn1.Name = "hariDataGridViewTextBoxColumn1";
            this.hariDataGridViewTextBoxColumn1.Width = 125;
            // 
            // jammulaiDataGridViewTextBoxColumn
            // 
            this.jammulaiDataGridViewTextBoxColumn.DataPropertyName = "jam_mulai";
            this.jammulaiDataGridViewTextBoxColumn.HeaderText = "jam_mulai";
            this.jammulaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jammulaiDataGridViewTextBoxColumn.Name = "jammulaiDataGridViewTextBoxColumn";
            this.jammulaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // jamselesaiDataGridViewTextBoxColumn
            // 
            this.jamselesaiDataGridViewTextBoxColumn.DataPropertyName = "jam_selesai";
            this.jamselesaiDataGridViewTextBoxColumn.HeaderText = "jam_selesai";
            this.jamselesaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jamselesaiDataGridViewTextBoxColumn.Name = "jamselesaiDataGridViewTextBoxColumn";
            this.jamselesaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idperawatDataGridViewTextBoxColumn2
            // 
            this.idperawatDataGridViewTextBoxColumn2.DataPropertyName = "id_perawat";
            this.idperawatDataGridViewTextBoxColumn2.HeaderText = "id_perawat";
            this.idperawatDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idperawatDataGridViewTextBoxColumn2.Name = "idperawatDataGridViewTextBoxColumn2";
            this.idperawatDataGridViewTextBoxColumn2.Width = 125;
            // 
            // idpasienDataGridViewTextBoxColumn
            // 
            this.idpasienDataGridViewTextBoxColumn.DataPropertyName = "id_pasien";
            this.idpasienDataGridViewTextBoxColumn.HeaderText = "id_pasien";
            this.idpasienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpasienDataGridViewTextBoxColumn.Name = "idpasienDataGridViewTextBoxColumn";
            this.idpasienDataGridViewTextBoxColumn.Width = 125;
            // 
            // Rawat_Inap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Rawat_Inap";
            this.Text = "Rawat Inap";
            this.Load += new System.EventHandler(this.Piket_Harian_Dokter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPengurusKamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPerawatPasienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Puskesmas_superDataSet puskesmas_superDataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private Puskesmas_superDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Puskesmas_superDataSet1 puskesmas_superDataSet1;
        private System.Windows.Forms.BindingSource jadwalPengurusKamarBindingSource;
        private Puskesmas_superDataSet1TableAdapters.Jadwal_Pengurus_KamarTableAdapter jadwal_Pengurus_KamarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjadwalpenguruskamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idperawatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkamarDataGridViewTextBoxColumn1;
        private Puskesmas_superDataSet2 puskesmas_superDataSet2;
        private System.Windows.Forms.BindingSource perawatBindingSource;
        private Puskesmas_superDataSet2TableAdapters.PerawatTableAdapter perawatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idperawatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaperawatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Puskesmas_superDataSet3 puskesmas_superDataSet3;
        private System.Windows.Forms.BindingSource jadwalPerawatPasienBindingSource;
        private Puskesmas_superDataSet3TableAdapters.Jadwal_Perawat_PasienTableAdapter jadwal_Perawat_PasienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjadwalperawatpasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jammulaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamselesaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idperawatDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpasienDataGridViewTextBoxColumn;
    }
}