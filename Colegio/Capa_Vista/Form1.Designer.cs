
namespace Capa_Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpape = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsape = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttele = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcelu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1168, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtpnom
            // 
            this.txtpnom.Location = new System.Drawing.Point(108, 16);
            this.txtpnom.Name = "txtpnom";
            this.txtpnom.Size = new System.Drawing.Size(120, 20);
            this.txtpnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primer Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Segundo Nombre:";
            // 
            // txtsnom
            // 
            this.txtsnom.Location = new System.Drawing.Point(347, 19);
            this.txtsnom.Name = "txtsnom";
            this.txtsnom.Size = new System.Drawing.Size(120, 20);
            this.txtsnom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Primer Apellido:";
            // 
            // txtpape
            // 
            this.txtpape.Location = new System.Drawing.Point(561, 19);
            this.txtpape.Name = "txtpape";
            this.txtpape.Size = new System.Drawing.Size(120, 20);
            this.txtpape.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Segundo Apellido:";
            // 
            // txtsape
            // 
            this.txtsape.Location = new System.Drawing.Point(802, 23);
            this.txtsape.Name = "txtsape";
            this.txtsape.Size = new System.Drawing.Size(120, 20);
            this.txtsape.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono:";
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(108, 58);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(120, 20);
            this.txttele.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Celular:";
            // 
            // txtcelu
            // 
            this.txtcelu.Location = new System.Drawing.Point(347, 61);
            this.txtcelu.Name = "txtcelu";
            this.txtcelu.Size = new System.Drawing.Size(120, 20);
            this.txtcelu.TabIndex = 11;
            this.txtcelu.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Direccion:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(561, 64);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(120, 20);
            this.txtdir.TabIndex = 13;
            this.txtdir.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(802, 64);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(120, 20);
            this.txtemail.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(29, 128);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(120, 20);
            this.txtfecha.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Observacion:";
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(256, 128);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(120, 20);
            this.txtobs.TabIndex = 19;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(491, 174);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(122, 33);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(644, 174);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(122, 33);
            this.btneditar.TabIndex = 22;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(800, 174);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(122, 33);
            this.btneliminar.TabIndex = 23;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.Location = new System.Drawing.Point(959, 174);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(122, 33);
            this.btnreporte.TabIndex = 24;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcelu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsape);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpnom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpape;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcelu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnreporte;
    }
}

