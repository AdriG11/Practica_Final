namespace Practica_Final
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvLibros = new DataGridView();
            btnGuarLib = new Button();
            btnLimpLib = new Button();
            btnMostLib = new Button();
            txtCostLib = new TextBox();
            txtFecLib = new TextBox();
            txtAuLib = new TextBox();
            txtTitLib = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            txtCant = new TextBox();
            txtAutor = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnLinq = new Button();
            cmbPeriodicidad = new ComboBox();
            txtCostRev = new TextBox();
            dgvRevista = new DataGridView();
            btnGuarRev = new Button();
            btnLimpRev = new Button();
            btnMostRev = new Button();
            txtTitRev = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtLinq = new Button();
            label10 = new Label();
            label11 = new Label();
            txtAut = new TextBox();
            txtCan = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevista).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(994, 553);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtCan);
            tabPage1.Controls.Add(txtAut);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtLinq);
            tabPage1.Controls.Add(dgvLibros);
            tabPage1.Controls.Add(btnGuarLib);
            tabPage1.Controls.Add(btnLimpLib);
            tabPage1.Controls.Add(btnMostLib);
            tabPage1.Controls.Add(txtCostLib);
            tabPage1.Controls.Add(txtFecLib);
            tabPage1.Controls.Add(txtAuLib);
            tabPage1.Controls.Add(txtTitLib);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(986, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro Libro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(23, 130);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.RowTemplate.Height = 29;
            dgvLibros.Size = new Size(643, 299);
            dgvLibros.TabIndex = 11;
            // 
            // btnGuarLib
            // 
            btnGuarLib.Location = new Point(779, 361);
            btnGuarLib.Name = "btnGuarLib";
            btnGuarLib.Size = new Size(140, 49);
            btnGuarLib.TabIndex = 10;
            btnGuarLib.Text = "GUARDAR";
            btnGuarLib.UseVisualStyleBackColor = true;
            btnGuarLib.Click += btnGuarLib_Click;
            // 
            // btnLimpLib
            // 
            btnLimpLib.Location = new Point(779, 242);
            btnLimpLib.Name = "btnLimpLib";
            btnLimpLib.Size = new Size(140, 49);
            btnLimpLib.TabIndex = 9;
            btnLimpLib.Text = "LIMPIAR";
            btnLimpLib.UseVisualStyleBackColor = true;
            btnLimpLib.Click += btnLimpLib_Click;
            // 
            // btnMostLib
            // 
            btnMostLib.Location = new Point(779, 130);
            btnMostLib.Name = "btnMostLib";
            btnMostLib.Size = new Size(140, 49);
            btnMostLib.TabIndex = 8;
            btnMostLib.Text = "MOSTRAR";
            btnMostLib.UseVisualStyleBackColor = true;
            btnMostLib.Click += btnMostLib_Click;
            // 
            // txtCostLib
            // 
            txtCostLib.Location = new Point(464, 87);
            txtCostLib.Name = "txtCostLib";
            txtCostLib.Size = new Size(160, 27);
            txtCostLib.TabIndex = 7;
            // 
            // txtFecLib
            // 
            txtFecLib.Location = new Point(464, 28);
            txtFecLib.Name = "txtFecLib";
            txtFecLib.Size = new Size(160, 27);
            txtFecLib.TabIndex = 6;
            // 
            // txtAuLib
            // 
            txtAuLib.Location = new Point(89, 87);
            txtAuLib.Name = "txtAuLib";
            txtAuLib.Size = new Size(160, 27);
            txtAuLib.TabIndex = 5;
            // 
            // txtTitLib
            // 
            txtTitLib.Location = new Point(89, 35);
            txtTitLib.Name = "txtTitLib";
            txtTitLib.Size = new Size(160, 27);
            txtTitLib.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 87);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Costo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 35);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Publicacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtCant);
            tabPage2.Controls.Add(txtAutor);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(btnLinq);
            tabPage2.Controls.Add(cmbPeriodicidad);
            tabPage2.Controls.Add(txtCostRev);
            tabPage2.Controls.Add(dgvRevista);
            tabPage2.Controls.Add(btnGuarRev);
            tabPage2.Controls.Add(btnLimpRev);
            tabPage2.Controls.Add(btnMostRev);
            tabPage2.Controls.Add(txtTitRev);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(986, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registro Revista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(230, 478);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(194, 27);
            txtCant.TabIndex = 16;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(211, 437);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(194, 27);
            txtAutor.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(90, 485);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 14;
            label9.Text = "Cantidad de Libros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 444);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 13;
            label8.Text = "Autor Mayor";
            // 
            // btnLinq
            // 
            btnLinq.Location = new Point(789, 444);
            btnLinq.Name = "btnLinq";
            btnLinq.Size = new Size(129, 49);
            btnLinq.TabIndex = 12;
            btnLinq.Text = "LINQ";
            btnLinq.UseVisualStyleBackColor = true;
            btnLinq.Click += btnLinq_Click;
            // 
            // cmbPeriodicidad
            // 
            cmbPeriodicidad.FormattingEnabled = true;
            cmbPeriodicidad.Items.AddRange(new object[] { "Mensual", "Quincenal", "Semanal" });
            cmbPeriodicidad.Location = new Point(153, 98);
            cmbPeriodicidad.Name = "cmbPeriodicidad";
            cmbPeriodicidad.Size = new Size(188, 28);
            cmbPeriodicidad.TabIndex = 11;
            // 
            // txtCostRev
            // 
            txtCostRev.Location = new Point(473, 35);
            txtCostRev.Name = "txtCostRev";
            txtCostRev.Size = new Size(185, 27);
            txtCostRev.TabIndex = 10;
            // 
            // dgvRevista
            // 
            dgvRevista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevista.Location = new Point(34, 169);
            dgvRevista.Name = "dgvRevista";
            dgvRevista.RowHeadersWidth = 51;
            dgvRevista.RowTemplate.Height = 29;
            dgvRevista.Size = new Size(568, 229);
            dgvRevista.TabIndex = 9;
            // 
            // btnGuarRev
            // 
            btnGuarRev.Location = new Point(789, 349);
            btnGuarRev.Name = "btnGuarRev";
            btnGuarRev.Size = new Size(129, 49);
            btnGuarRev.TabIndex = 8;
            btnGuarRev.Text = "GUARDAR";
            btnGuarRev.UseVisualStyleBackColor = true;
            btnGuarRev.Click += btnGuarRev_Click;
            // 
            // btnLimpRev
            // 
            btnLimpRev.Location = new Point(789, 227);
            btnLimpRev.Name = "btnLimpRev";
            btnLimpRev.Size = new Size(129, 49);
            btnLimpRev.TabIndex = 7;
            btnLimpRev.Text = "LIMPIAR";
            btnLimpRev.UseVisualStyleBackColor = true;
            btnLimpRev.Click += btnLimpRev_Click;
            // 
            // btnMostRev
            // 
            btnMostRev.Location = new Point(789, 129);
            btnMostRev.Name = "btnMostRev";
            btnMostRev.Size = new Size(129, 49);
            btnMostRev.TabIndex = 6;
            btnMostRev.Text = "MOSTRAR";
            btnMostRev.UseVisualStyleBackColor = true;
            btnMostRev.Click += btnMostRev_Click;
            // 
            // txtTitRev
            // 
            txtTitRev.Location = new Point(121, 33);
            txtTitRev.Name = "txtTitRev";
            txtTitRev.Size = new Size(183, 27);
            txtTitRev.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 36);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 2;
            label7.Text = "Costo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 101);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 1;
            label6.Text = "Periodicidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 36);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 0;
            label5.Text = "Titulo";
            // 
            // txtLinq
            // 
            txtLinq.Location = new Point(779, 443);
            txtLinq.Name = "txtLinq";
            txtLinq.Size = new Size(129, 49);
            txtLinq.TabIndex = 13;
            txtLinq.Text = "LINQ";
            txtLinq.UseVisualStyleBackColor = true;
            txtLinq.Click += txtLinq_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 443);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 14;
            label10.Text = "Autor Mayor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 483);
            label11.Name = "label11";
            label11.Size = new Size(134, 20);
            label11.TabIndex = 15;
            label11.Text = "Cantidad de Libros";
            // 
            // txtAut
            // 
            txtAut.Location = new Point(187, 436);
            txtAut.Name = "txtAut";
            txtAut.Size = new Size(194, 27);
            txtAut.TabIndex = 16;
            // 
            // txtCan
            // 
            txtCan.Location = new Point(187, 483);
            txtCan.Name = "txtCan";
            txtCan.Size = new Size(194, 27);
            txtCan.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 589);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvLibros;
        private Button btnGuarLib;
        private Button btnLimpLib;
        private Button btnMostLib;
        private TextBox txtCostLib;
        private TextBox txtFecLib;
        private TextBox txtAuLib;
        private TextBox txtTitLib;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dgvRevista;
        private Button btnGuarRev;
        private Button btnLimpRev;
        private Button btnMostRev;
        private TextBox txtTitRev;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cmbPeriodicidad;
        private TextBox txtCostRev;
        private Button btnLinq;
        private TextBox txtCant;
        private TextBox txtAutor;
        private Label label9;
        private Label label8;
        private TextBox txtCan;
        private TextBox txtAut;
        private Label label11;
        private Label label10;
        private Button txtLinq;
    }
}