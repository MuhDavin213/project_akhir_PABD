namespace project_akhir
{
    partial class DataKamar
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.puskesmas_superDataSet4 = new project_akhir.Puskesmas_superDataSet4();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamarTableAdapter = new project_akhir.Puskesmas_superDataSet4TableAdapters.KamarTableAdapter();
            this.idkamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nokamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(490, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(409, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(848, 341);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Open";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(700, 341);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(557, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(425, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 427);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "Kembali";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 180);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 133);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "No Kamar";
            // 
            // puskesmas_superDataSet4
            // 
            this.puskesmas_superDataSet4.DataSetName = "Puskesmas_superDataSet4";
            this.puskesmas_superDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "Kamar";
            this.kamarBindingSource.DataSource = this.puskesmas_superDataSet4;
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
            // DataKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_akhir.Properties.Resources.kamar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 467);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataKamar";
            this.Text = "Data Kamar";
            this.Load += new System.EventHandler(this.DataKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmas_superDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Puskesmas_superDataSet4 puskesmas_superDataSet4;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private Puskesmas_superDataSet4TableAdapters.KamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn;
    }
}