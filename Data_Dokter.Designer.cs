﻿namespace project_akhir
{
    partial class DataDokter
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namadokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spesialisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notlpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puskesmasDataSet1 = new project_akhir.PuskesmasDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.puskesmasDataSet = new project_akhir.PuskesmasDataSet();
            this.puskesmasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokterTableAdapter = new project_akhir.PuskesmasDataSet1TableAdapters.DokterTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokterDataGridViewTextBoxColumn,
            this.namadokterDataGridViewTextBoxColumn,
            this.spesialisDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.notlpDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dokterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(468, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(595, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iddokterDataGridViewTextBoxColumn
            // 
            this.iddokterDataGridViewTextBoxColumn.DataPropertyName = "id_dokter";
            this.iddokterDataGridViewTextBoxColumn.HeaderText = "id_dokter";
            this.iddokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iddokterDataGridViewTextBoxColumn.Name = "iddokterDataGridViewTextBoxColumn";
            this.iddokterDataGridViewTextBoxColumn.Width = 150;
            // 
            // namadokterDataGridViewTextBoxColumn
            // 
            this.namadokterDataGridViewTextBoxColumn.DataPropertyName = "nama_dokter";
            this.namadokterDataGridViewTextBoxColumn.HeaderText = "nama_dokter";
            this.namadokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namadokterDataGridViewTextBoxColumn.Name = "namadokterDataGridViewTextBoxColumn";
            this.namadokterDataGridViewTextBoxColumn.Width = 150;
            // 
            // spesialisDataGridViewTextBoxColumn
            // 
            this.spesialisDataGridViewTextBoxColumn.DataPropertyName = "spesialis";
            this.spesialisDataGridViewTextBoxColumn.HeaderText = "spesialis";
            this.spesialisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.spesialisDataGridViewTextBoxColumn.Name = "spesialisDataGridViewTextBoxColumn";
            this.spesialisDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 150;
            // 
            // notlpDataGridViewTextBoxColumn
            // 
            this.notlpDataGridViewTextBoxColumn.DataPropertyName = "no_tlp";
            this.notlpDataGridViewTextBoxColumn.HeaderText = "no_tlp";
            this.notlpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.notlpDataGridViewTextBoxColumn.Name = "notlpDataGridViewTextBoxColumn";
            this.notlpDataGridViewTextBoxColumn.Width = 150;
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            this.jeniskelaminDataGridViewTextBoxColumn.Width = 150;
            // 
            // dokterBindingSource
            // 
            this.dokterBindingSource.DataMember = "Dokter";
            this.dokterBindingSource.DataSource = this.puskesmasDataSet1;
            // 
            // puskesmasDataSet1
            // 
            this.puskesmasDataSet1.DataSetName = "PuskesmasDataSet1";
            this.puskesmasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(532, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(690, 437);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(833, 437);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(980, 437);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Open";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "id Dokter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Dokter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spesialis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "No Telpon";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "id_dokter", true));
            this.textBox1.Location = new System.Drawing.Point(193, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "nama_dokter", true));
            this.textBox2.Location = new System.Drawing.Point(193, 121);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "spesialis", true));
            this.textBox3.Location = new System.Drawing.Point(193, 156);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "alamat", true));
            this.textBox4.Location = new System.Drawing.Point(193, 205);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Silver;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "no_tlp", true));
            this.textBox5.Location = new System.Drawing.Point(193, 245);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(238, 22);
            this.textBox5.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.Location = new System.Drawing.Point(26, 473);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 17;
            this.button5.Text = "Kembali";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 287);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Aqua;
            this.button6.Location = new System.Drawing.Point(424, 437);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 35);
            this.button6.TabIndex = 19;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // puskesmasDataSet
            // 
            this.puskesmasDataSet.DataSetName = "PuskesmasDataSet";
            this.puskesmasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puskesmasDataSetBindingSource
            // 
            this.puskesmasDataSetBindingSource.DataSource = this.puskesmasDataSet;
            this.puskesmasDataSetBindingSource.Position = 0;
            // 
            // dokterTableAdapter
            // 
            this.dokterTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Aqua;
            this.button7.Location = new System.Drawing.Point(282, 437);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 35);
            this.button7.TabIndex = 20;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // DataDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::project_akhir.Properties.Resources.dokter;
            this.ClientSize = new System.Drawing.Size(1095, 534);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataDokter";
            this.Text = "Data Dokter";
            this.Load += new System.EventHandler(this.DataDokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource puskesmasDataSetBindingSource;
        private PuskesmasDataSet puskesmasDataSet;
        private PuskesmasDataSet1 puskesmasDataSet1;
        private System.Windows.Forms.BindingSource dokterBindingSource;
        private PuskesmasDataSet1TableAdapters.DokterTableAdapter dokterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namadokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spesialisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notlpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
    }
}