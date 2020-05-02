namespace ApplicationWinforms
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rDVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cabinetdentaireDataSet2 = new ApplicationWinforms.cabinetdentaireDataSet2();
            this.button2 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtrech = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsupp = new System.Windows.Forms.TextBox();
            this.cabinetdentaireDataSet1 = new ApplicationWinforms.cabinetdentaireDataSet1();
            this.cabinetdentaireDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cabinetdentaireDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cabinetdentaireDataSet = new ApplicationWinforms.cabinetdentaireDataSet();
            this.rDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDVTableAdapter = new ApplicationWinforms.cabinetdentaireDataSetTableAdapters.RDVTableAdapter();
            this.btnaffich = new System.Windows.Forms.Button();
            this.rDVTableAdapter1 = new ApplicationWinforms.cabinetdentaireDataSet2TableAdapters.RDVTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout d\'un rendez-vous";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(97, 176);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(78, 27);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID du patient";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(150, 137);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(129, 24);
            this.txtnom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date RDV";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(150, 106);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(129, 24);
            this.txtdate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero RDV";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(150, 73);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(129, 24);
            this.txtnum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veuillez saisir les détails du rendez-vous...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(332, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des RDV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rDVBindingSource1
            // 
            this.rDVBindingSource1.DataMember = "RDV";
            this.rDVBindingSource1.DataSource = this.cabinetdentaireDataSet2;
            // 
            // cabinetdentaireDataSet2
            // 
            this.cabinetdentaireDataSet2.DataSetName = "cabinetdentaireDataSet2";
            this.cabinetdentaireDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(614, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(120, 92);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(83, 23);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtrech
            // 
            this.txtrech.Location = new System.Drawing.Point(18, 52);
            this.txtrech.Name = "txtrech";
            this.txtrech.Size = new System.Drawing.Size(177, 24);
            this.txtrech.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(9, 92);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(92, 23);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Recherche";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cherchez un RDV...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnok);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtrech);
            this.groupBox3.Controls.Add(this.txtsupp);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 141);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche,Modification,Suppression d\'un rendez-vous";
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(342, 92);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 11;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Modifiez la date du rdv";
            // 
            // txtsupp
            // 
            this.txtsupp.Location = new System.Drawing.Point(292, 52);
            this.txtsupp.Name = "txtsupp";
            this.txtsupp.Size = new System.Drawing.Size(171, 24);
            this.txtsupp.TabIndex = 6;
            this.txtsupp.TextChanged += new System.EventHandler(this.txtsupp_TextChanged);
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
            // cabinetdentaireDataSet1BindingSource1
            // 
            this.cabinetdentaireDataSet1BindingSource1.DataSource = this.cabinetdentaireDataSet1;
            this.cabinetdentaireDataSet1BindingSource1.Position = 0;
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
            // btnaffich
            // 
            this.btnaffich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaffich.Location = new System.Drawing.Point(549, 252);
            this.btnaffich.Name = "btnaffich";
            this.btnaffich.Size = new System.Drawing.Size(82, 33);
            this.btnaffich.TabIndex = 12;
            this.btnaffich.Text = "Afficher";
            this.btnaffich.UseVisualStyleBackColor = true;
            this.btnaffich.Click += new System.EventHandler(this.btnaffich_Click);
            // 
            // rDVTableAdapter1
            // 
            this.rDVTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 417);
            this.Controls.Add(this.btnaffich);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Gestion des RDV";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetdentaireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtrech;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsupp;
        private System.Windows.Forms.BindingSource cabinetdentaireDataSet1BindingSource1;
        private cabinetdentaireDataSet1 cabinetdentaireDataSet1;
        private System.Windows.Forms.BindingSource cabinetdentaireDataSet1BindingSource;
        private cabinetdentaireDataSet cabinetdentaireDataSet;
        private System.Windows.Forms.BindingSource rDVBindingSource;
        private cabinetdentaireDataSetTableAdapters.RDVTableAdapter rDVTableAdapter;
        private System.Windows.Forms.Button btnaffich;
        private cabinetdentaireDataSet2 cabinetdentaireDataSet2;
        private System.Windows.Forms.BindingSource rDVBindingSource1;
        private cabinetdentaireDataSet2TableAdapters.RDVTableAdapter rDVTableAdapter1;
        private System.Windows.Forms.Button btnok;
    }
}