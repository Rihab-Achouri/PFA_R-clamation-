namespace ApplicationWinforms
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnok = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cabinetdentaireDataSet1 = new ApplicationWinforms.cabinetdentaireDataSet1();
            this.cabinetdentaireDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cabinetdentaireDataSet = new ApplicationWinforms.cabinetdentaireDataSet();
            this.rDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDVTableAdapter = new ApplicationWinforms.cabinetdentaireDataSetTableAdapters.RDVTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numrdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daterdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(233, 1);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(36, 20);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 334);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(212, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adulte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(212, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enfant";
            // 
            // cabinetdentaireDataSet1
            // 
            this.cabinetdentaireDataSet1.DataSetName = "cabinetdentaireDataSet1";
            this.cabinetdentaireDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cabinetdentaireDataSet1BindingSource
            // 
            this.cabinetdentaireDataSet1BindingSource.DataSource = this.cabinetdentaireDataSet1;
            this.cabinetdentaireDataSet1BindingSource.Position = 0;
            // 
            // cabinetdentaireDataSet
            // 
            this.cabinetdentaireDataSet.DataSetName = "cabinetdentaireDataSet";
            this.cabinetdentaireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDVBindingSource
            // 
            this.rDVBindingSource.DataMember = "RDV";
            this.rDVBindingSource.DataSource = this.cabinetdentaireDataSet;
            // 
            // rDVTableAdapter
            // 
            this.rDVTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numrdvDataGridViewTextBoxColumn,
            this.daterdvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rDVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(334, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 178);
            this.dataGridView1.TabIndex = 4;
            // 
            // numrdvDataGridViewTextBoxColumn
            // 
            this.numrdvDataGridViewTextBoxColumn.DataPropertyName = "Numrdv";
            this.numrdvDataGridViewTextBoxColumn.HeaderText = "Numrdv";
            this.numrdvDataGridViewTextBoxColumn.Name = "numrdvDataGridViewTextBoxColumn";
            // 
            // daterdvDataGridViewTextBoxColumn
            // 
            this.daterdvDataGridViewTextBoxColumn.DataPropertyName = "Daterdv";
            this.daterdvDataGridViewTextBoxColumn.HeaderText = "Daterdv";
            this.daterdvDataGridViewTextBoxColumn.Name = "daterdvDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 32);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(417, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(136, 31);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRENOM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnok);
            this.Name = "Form4";
            this.Text = "Gestion des fiches";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource cabinetdentaireDataSet1BindingSource;
        private cabinetdentaireDataSet1 cabinetdentaireDataSet1;
        private cabinetdentaireDataSet cabinetdentaireDataSet;
        private System.Windows.Forms.BindingSource rDVBindingSource;
        private cabinetdentaireDataSetTableAdapters.RDVTableAdapter rDVTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numrdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daterdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}