
namespace fase1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnEscanear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelT_Dinamica = new System.Windows.Forms.Panel();
            this.dataGVConstantes = new System.Windows.Forms.DataGridView();
            this.dataGVIdentificadores = new System.Windows.Forms.DataGridView();
            this.panelT_Lexica = new System.Windows.Forms.Panel();
            this.dataGVLexica = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTablaLexica = new System.Windows.Forms.Button();
            this.btnTablaDinamica = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelT_Dinamica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVConstantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVIdentificadores)).BeginInit();
            this.panelT_Lexica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLexica)).BeginInit();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(635, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 206);
            this.panel1.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(1010, 206);
            this.lblError.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEntrada);
            this.panel2.Controls.Add(this.btnEscanear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 482);
            this.panel2.TabIndex = 1;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEntrada.Location = new System.Drawing.Point(0, 40);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(427, 442);
            this.txtEntrada.TabIndex = 2;
            // 
            // btnEscanear
            // 
            this.btnEscanear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEscanear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEscanear.Location = new System.Drawing.Point(0, 0);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(427, 40);
            this.btnEscanear.TabIndex = 0;
            this.btnEscanear.Text = "Escanear";
            this.btnEscanear.UseVisualStyleBackColor = true;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelT_Dinamica);
            this.panel3.Controls.Add(this.panelT_Lexica);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(433, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 482);
            this.panel3.TabIndex = 2;
            // 
            // panelT_Dinamica
            // 
            this.panelT_Dinamica.Controls.Add(this.dataGVConstantes);
            this.panelT_Dinamica.Controls.Add(this.dataGVIdentificadores);
            this.panelT_Dinamica.Location = new System.Drawing.Point(2, 41);
            this.panelT_Dinamica.Name = "panelT_Dinamica";
            this.panelT_Dinamica.Size = new System.Drawing.Size(563, 435);
            this.panelT_Dinamica.TabIndex = 2;
            this.panelT_Dinamica.Visible = false;
            // 
            // dataGVConstantes
            // 
            this.dataGVConstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVConstantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGVConstantes.Location = new System.Drawing.Point(0, 251);
            this.dataGVConstantes.Name = "dataGVConstantes";
            this.dataGVConstantes.RowTemplate.Height = 25;
            this.dataGVConstantes.Size = new System.Drawing.Size(563, 184);
            this.dataGVConstantes.TabIndex = 1;
            // 
            // dataGVIdentificadores
            // 
            this.dataGVIdentificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVIdentificadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVIdentificadores.Location = new System.Drawing.Point(0, 0);
            this.dataGVIdentificadores.Name = "dataGVIdentificadores";
            this.dataGVIdentificadores.RowTemplate.Height = 25;
            this.dataGVIdentificadores.Size = new System.Drawing.Size(563, 245);
            this.dataGVIdentificadores.TabIndex = 0;
            // 
            // panelT_Lexica
            // 
            this.panelT_Lexica.Controls.Add(this.dataGVLexica);
            this.panelT_Lexica.Location = new System.Drawing.Point(0, 40);
            this.panelT_Lexica.Name = "panelT_Lexica";
            this.panelT_Lexica.Size = new System.Drawing.Size(565, 436);
            this.panelT_Lexica.TabIndex = 1;
            // 
            // dataGVLexica
            // 
            this.dataGVLexica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVLexica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVLexica.Location = new System.Drawing.Point(0, 0);
            this.dataGVLexica.Name = "dataGVLexica";
            this.dataGVLexica.RowTemplate.Height = 25;
            this.dataGVLexica.Size = new System.Drawing.Size(565, 436);
            this.dataGVLexica.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 40);
            this.panel4.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTablaLexica);
            this.flowLayoutPanel1.Controls.Add(this.btnTablaDinamica);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(577, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTablaLexica
            // 
            this.btnTablaLexica.Location = new System.Drawing.Point(3, 3);
            this.btnTablaLexica.Name = "btnTablaLexica";
            this.btnTablaLexica.Size = new System.Drawing.Size(96, 31);
            this.btnTablaLexica.TabIndex = 0;
            this.btnTablaLexica.Text = "Tabla Lexica";
            this.btnTablaLexica.UseVisualStyleBackColor = true;
            this.btnTablaLexica.Click += new System.EventHandler(this.btnTablaLexica_Click);
            // 
            // btnTablaDinamica
            // 
            this.btnTablaDinamica.Location = new System.Drawing.Point(105, 3);
            this.btnTablaDinamica.Name = "btnTablaDinamica";
            this.btnTablaDinamica.Size = new System.Drawing.Size(96, 31);
            this.btnTablaDinamica.TabIndex = 1;
            this.btnTablaDinamica.Text = "Tabla Dinamica";
            this.btnTablaDinamica.UseVisualStyleBackColor = true;
            this.btnTablaDinamica.Click += new System.EventHandler(this.btnTablaDinamica_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelT_Dinamica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVConstantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVIdentificadores)).EndInit();
            this.panelT_Lexica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLexica)).EndInit();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelT_Dinamica;
        private System.Windows.Forms.Panel panelT_Lexica;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTablaLexica;
        private System.Windows.Forms.Button btnTablaDinamica;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.DataGridView dataGVLexica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGVConstantes;
        private System.Windows.Forms.DataGridView dataGVIdentificadores;
        private System.Windows.Forms.Label lblError;
    }
}

