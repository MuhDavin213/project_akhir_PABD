namespace project_akhir
{
    partial class JadwalPraktek
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
            this.idjadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jammulaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamselesaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalpraktekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puskesmasDataSet = new project_akhir.PuskesmasDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.jadwal_praktekTableAdapter = new project_akhir.PuskesmasDataSetTableAdapters.jadwal_praktekTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.puskesmasDataSet3 = new project_akhir.PuskesmasDataSet3();
            this.jadwalpraktekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jadwal_praktekTableAdapter1 = new project_akhir.PuskesmasDataSet3TableAdapters.jadwal_praktekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalpraktekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalpraktekBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjadwalDataGridViewTextBoxColumn,
            this.hariDataGridViewTextBoxColumn,
            this.jammulaiDataGridViewTextBoxColumn,
            this.jamselesaiDataGridViewTextBoxColumn,
            this.iddokterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jadwalpraktekBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(562, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(639, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // idjadwalDataGridViewTextBoxColumn
            // 
            this.idjadwalDataGridViewTextBoxColumn.DataPropertyName = "id_jadwal";
            this.idjadwalDataGridViewTextBoxColumn.HeaderText = "id_jadwal";
            this.idjadwalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idjadwalDataGridViewTextBoxColumn.Name = "idjadwalDataGridViewTextBoxColumn";
            this.idjadwalDataGridViewTextBoxColumn.Width = 150;
            // 
            // hariDataGridViewTextBoxColumn
            // 
            this.hariDataGridViewTextBoxColumn.DataPropertyName = "hari";
            this.hariDataGridViewTextBoxColumn.HeaderText = "hari";
            this.hariDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hariDataGridViewTextBoxColumn.Name = "hariDataGridViewTextBoxColumn";
            this.hariDataGridViewTextBoxColumn.Width = 150;
            // 
            // jammulaiDataGridViewTextBoxColumn
            // 
            this.jammulaiDataGridViewTextBoxColumn.DataPropertyName = "jam_mulai";
            this.jammulaiDataGridViewTextBoxColumn.HeaderText = "jam_mulai";
            this.jammulaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jammulaiDataGridViewTextBoxColumn.Name = "jammulaiDataGridViewTextBoxColumn";
            this.jammulaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // jamselesaiDataGridViewTextBoxColumn
            // 
            this.jamselesaiDataGridViewTextBoxColumn.DataPropertyName = "jam_selesai";
            this.jamselesaiDataGridViewTextBoxColumn.HeaderText = "jam_selesai";
            this.jamselesaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jamselesaiDataGridViewTextBoxColumn.Name = "jamselesaiDataGridViewTextBoxColumn";
            this.jamselesaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // iddokterDataGridViewTextBoxColumn
            // 
            this.iddokterDataGridViewTextBoxColumn.DataPropertyName = "id_dokter";
            this.iddokterDataGridViewTextBoxColumn.HeaderText = "id_dokter";
            this.iddokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iddokterDataGridViewTextBoxColumn.Name = "iddokterDataGridViewTextBoxColumn";
            this.iddokterDataGridViewTextBoxColumn.Width = 150;
            // 
            // jadwalpraktekBindingSource
            // 
            this.jadwalpraktekBindingSource.DataMember = "jadwal_praktek";
            this.jadwalpraktekBindingSource.DataSource = this.puskesmasDataSet;
            // 
            // puskesmasDataSet
            // 
            this.puskesmasDataSet.DataSetName = "PuskesmasDataSet";
            this.puskesmasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(938, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1107, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(34, 590);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Kembali";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Jadwal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Dokter";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jam Mulai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jam Selesai";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jadwalpraktekBindingSource1, "id_jadwal", true));
            this.textBox1.Location = new System.Drawing.Point(202, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jadwalpraktekBindingSource1, "hari", true));
            this.textBox2.Location = new System.Drawing.Point(202, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 26);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jadwalpraktekBindingSource1, "jam_mulai", true));
            this.textBox3.Location = new System.Drawing.Point(202, 219);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 26);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jadwalpraktekBindingSource1, "jam_selesai", true));
            this.textBox4.Location = new System.Drawing.Point(202, 281);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 26);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jadwalpraktekBindingSource1, "id_dokter", true));
            this.textBox5.Location = new System.Drawing.Point(202, 340);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(285, 26);
            this.textBox5.TabIndex = 15;
            // 
            // jadwal_praktekTableAdapter
            // 
            this.jadwal_praktekTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(590, 542);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 41);
            this.button6.TabIndex = 16;
            this.button6.Text = "Simpan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // puskesmasDataSet3
            // 
            this.puskesmasDataSet3.DataSetName = "PuskesmasDataSet3";
            this.puskesmasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalpraktekBindingSource1
            // 
            this.jadwalpraktekBindingSource1.DataMember = "jadwal_praktek";
            this.jadwalpraktekBindingSource1.DataSource = this.puskesmasDataSet3;
            // 
            // jadwal_praktekTableAdapter1
            // 
            this.jadwal_praktekTableAdapter1.ClearBeforeFill = true;
            // 
            // JadwalPraktek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_akhir.Properties.Resources.jadwal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 653);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JadwalPraktek";
            this.Text = "Jadwal Praktek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalpraktekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalpraktekBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private PuskesmasDataSet puskesmasDataSet;
        private System.Windows.Forms.BindingSource jadwalpraktekBindingSource;
        private PuskesmasDataSetTableAdapters.jadwal_praktekTableAdapter jadwal_praktekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jammulaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamselesaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private PuskesmasDataSet3 puskesmasDataSet3;
        private System.Windows.Forms.BindingSource jadwalpraktekBindingSource1;
        private PuskesmasDataSet3TableAdapters.jadwal_praktekTableAdapter jadwal_praktekTableAdapter1;
    }
}