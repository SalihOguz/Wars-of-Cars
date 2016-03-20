namespace warsofcars
{
    partial class Form3
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
            this.oYUNCUADIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUANDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIRADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zORLUKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABLOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vt1DataSet2 = new warsofcars.vt1DataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.oYUNCUADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zORLUKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABLOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vt1DataSet1 = new warsofcars.vt1DataSet1();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tABLOTableAdapter = new warsofcars.vt1DataSet1TableAdapters.TABLOTableAdapter();
            this.tABLOTableAdapter1 = new warsofcars.vt1DataSet2TableAdapters.TABLOTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt1DataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oYUNCUADIDataGridViewTextBoxColumn1,
            this.pUANDataGridViewTextBoxColumn1,
            this.sIRADataGridViewTextBoxColumn1,
            this.zORLUKDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.tABLOBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(554, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // oYUNCUADIDataGridViewTextBoxColumn1
            // 
            this.oYUNCUADIDataGridViewTextBoxColumn1.DataPropertyName = "OYUNCU_ADI";
            this.oYUNCUADIDataGridViewTextBoxColumn1.HeaderText = "OYUNCU_ADI";
            this.oYUNCUADIDataGridViewTextBoxColumn1.Name = "oYUNCUADIDataGridViewTextBoxColumn1";
            // 
            // pUANDataGridViewTextBoxColumn1
            // 
            this.pUANDataGridViewTextBoxColumn1.DataPropertyName = "PUAN";
            this.pUANDataGridViewTextBoxColumn1.HeaderText = "PUAN";
            this.pUANDataGridViewTextBoxColumn1.Name = "pUANDataGridViewTextBoxColumn1";
            // 
            // sIRADataGridViewTextBoxColumn1
            // 
            this.sIRADataGridViewTextBoxColumn1.DataPropertyName = "SIRA";
            this.sIRADataGridViewTextBoxColumn1.HeaderText = "SIRA";
            this.sIRADataGridViewTextBoxColumn1.Name = "sIRADataGridViewTextBoxColumn1";
            // 
            // zORLUKDataGridViewTextBoxColumn1
            // 
            this.zORLUKDataGridViewTextBoxColumn1.DataPropertyName = "ZORLUK";
            this.zORLUKDataGridViewTextBoxColumn1.HeaderText = "ZORLUK";
            this.zORLUKDataGridViewTextBoxColumn1.Name = "zORLUKDataGridViewTextBoxColumn1";
            // 
            // tABLOBindingSource1
            // 
            this.tABLOBindingSource1.DataMember = "TABLO";
            this.tABLOBindingSource1.DataSource = this.vt1DataSet2;
            // 
            // vt1DataSet2
            // 
            this.vt1DataSet2.DataSetName = "vt1DataSet2";
            this.vt1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oYUNCUADIDataGridViewTextBoxColumn,
            this.pUANDataGridViewTextBoxColumn,
            this.sIRADataGridViewTextBoxColumn,
            this.zORLUKDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tABLOBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(29, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 305);
            this.dataGridView2.TabIndex = 0;
            // 
            // oYUNCUADIDataGridViewTextBoxColumn
            // 
            this.oYUNCUADIDataGridViewTextBoxColumn.DataPropertyName = "OYUNCU_ADI";
            this.oYUNCUADIDataGridViewTextBoxColumn.HeaderText = "OYUNCU_ADI";
            this.oYUNCUADIDataGridViewTextBoxColumn.Name = "oYUNCUADIDataGridViewTextBoxColumn";
            // 
            // pUANDataGridViewTextBoxColumn
            // 
            this.pUANDataGridViewTextBoxColumn.DataPropertyName = "PUAN";
            this.pUANDataGridViewTextBoxColumn.HeaderText = "PUAN";
            this.pUANDataGridViewTextBoxColumn.Name = "pUANDataGridViewTextBoxColumn";
            // 
            // sIRADataGridViewTextBoxColumn
            // 
            this.sIRADataGridViewTextBoxColumn.DataPropertyName = "SIRA";
            this.sIRADataGridViewTextBoxColumn.HeaderText = "SIRA";
            this.sIRADataGridViewTextBoxColumn.Name = "sIRADataGridViewTextBoxColumn";
            // 
            // zORLUKDataGridViewTextBoxColumn
            // 
            this.zORLUKDataGridViewTextBoxColumn.DataPropertyName = "ZORLUK";
            this.zORLUKDataGridViewTextBoxColumn.HeaderText = "ZORLUK";
            this.zORLUKDataGridViewTextBoxColumn.Name = "zORLUKDataGridViewTextBoxColumn";
            // 
            // tABLOBindingSource
            // 
            this.tABLOBindingSource.DataMember = "TABLO";
            this.tABLOBindingSource.DataSource = this.vt1DataSet1;
            // 
            // vt1DataSet1
            // 
            this.vt1DataSet1.DataSetName = "vt1DataSet1";
            this.vt1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1041, 517);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 521;
            this.lineShape1.X2 = 521;
            this.lineShape1.Y1 = 16;
            this.lineShape1.Y2 = 413;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "En İyi Skor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(666, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "En Kötü Skor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(83, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu Adı Ara";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(307, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyuncu ve Skor Sil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tABLOTableAdapter
            // 
            this.tABLOTableAdapter.ClearBeforeFill = true;
            // 
            // tABLOTableAdapter1
            // 
            this.tABLOTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(615, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 85);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oyuncu Adı Güncelle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Puan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kayıt Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1041, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form3";
            this.Text = "Sıralama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt1DataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private vt1DataSet1 vt1DataSet1;
        private System.Windows.Forms.BindingSource tABLOBindingSource;
        private vt1DataSet1TableAdapters.TABLOTableAdapter tABLOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oYUNCUADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zORLUKDataGridViewTextBoxColumn;
        private vt1DataSet2 vt1DataSet2;
        private System.Windows.Forms.BindingSource tABLOBindingSource1;
        private vt1DataSet2TableAdapters.TABLOTableAdapter tABLOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oYUNCUADIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUANDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIRADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zORLUKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}