namespace LatamDS.formularios.factura
{
    partial class AdministrarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarFactura));
            this.btnguardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfruc = new System.Windows.Forms.TextBox();
            this.btndisminuir = new System.Windows.Forms.Button();
            this.btnincrementar = new System.Windows.Forms.Button();
            this.txtfviva = new System.Windows.Forms.TextBox();
            this.txtfnombre = new System.Windows.Forms.TextBox();
            this.txtfvrenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfnumfact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfsubt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfiva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtpiva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(265, 12);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(54, 23);
            this.btnguardar.TabIndex = 26;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.dtpicker);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtfruc);
            this.groupBox1.Controls.Add(this.btndisminuir);
            this.groupBox1.Controls.Add(this.btnincrementar);
            this.groupBox1.Controls.Add(this.txtfviva);
            this.groupBox1.Controls.Add(this.txtfnombre);
            this.groupBox1.Controls.Add(this.txtfvrenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtfnumfact);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfsubt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfiva);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 224);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Location = new System.Drawing.Point(251, 59);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(25, 17);
            this.btnbuscar.TabIndex = 25;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // dtpicker
            // 
            this.dtpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Location = new System.Drawing.Point(83, 30);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(193, 20);
            this.dtpicker.TabIndex = 22;
            this.dtpicker.Value = new System.DateTime(2019, 7, 15, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "V. IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "V. Renta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "RUC:";
            // 
            // txtfruc
            // 
            this.txtfruc.Enabled = false;
            this.txtfruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfruc.Location = new System.Drawing.Point(83, 82);
            this.txtfruc.Name = "txtfruc";
            this.txtfruc.ReadOnly = true;
            this.txtfruc.Size = new System.Drawing.Size(193, 20);
            this.txtfruc.TabIndex = 16;
            // 
            // btndisminuir
            // 
            this.btndisminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisminuir.Location = new System.Drawing.Point(225, 106);
            this.btndisminuir.Name = "btndisminuir";
            this.btndisminuir.Size = new System.Drawing.Size(23, 23);
            this.btndisminuir.TabIndex = 15;
            this.btndisminuir.Text = "-";
            this.btndisminuir.UseVisualStyleBackColor = true;
            this.btndisminuir.Click += new System.EventHandler(this.Btndisminuir_Click);
            // 
            // btnincrementar
            // 
            this.btnincrementar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincrementar.Location = new System.Drawing.Point(251, 106);
            this.btnincrementar.Name = "btnincrementar";
            this.btnincrementar.Size = new System.Drawing.Size(25, 23);
            this.btnincrementar.TabIndex = 14;
            this.btnincrementar.Text = "+";
            this.btnincrementar.UseVisualStyleBackColor = true;
            this.btnincrementar.Click += new System.EventHandler(this.Btnincrementar_Click);
            // 
            // txtfviva
            // 
            this.txtfviva.Enabled = false;
            this.txtfviva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfviva.Location = new System.Drawing.Point(199, 190);
            this.txtfviva.Name = "txtfviva";
            this.txtfviva.ReadOnly = true;
            this.txtfviva.Size = new System.Drawing.Size(77, 20);
            this.txtfviva.TabIndex = 9;
            // 
            // txtfnombre
            // 
            this.txtfnombre.Enabled = false;
            this.txtfnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfnombre.Location = new System.Drawing.Point(83, 56);
            this.txtfnombre.Name = "txtfnombre";
            this.txtfnombre.ReadOnly = true;
            this.txtfnombre.Size = new System.Drawing.Size(162, 20);
            this.txtfnombre.TabIndex = 12;
            // 
            // txtfvrenta
            // 
            this.txtfvrenta.Enabled = false;
            this.txtfvrenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfvrenta.Location = new System.Drawing.Point(83, 190);
            this.txtfvrenta.Name = "txtfvrenta";
            this.txtfvrenta.ReadOnly = true;
            this.txtfvrenta.Size = new System.Drawing.Size(66, 20);
            this.txtfvrenta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // txtfnumfact
            // 
            this.txtfnumfact.Enabled = false;
            this.txtfnumfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfnumfact.Location = new System.Drawing.Point(83, 108);
            this.txtfnumfact.Name = "txtfnumfact";
            this.txtfnumfact.ReadOnly = true;
            this.txtfnumfact.Size = new System.Drawing.Size(136, 20);
            this.txtfnumfact.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número:";
            // 
            // txtfsubt
            // 
            this.txtfsubt.Enabled = false;
            this.txtfsubt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfsubt.Location = new System.Drawing.Point(83, 137);
            this.txtfsubt.Name = "txtfsubt";
            this.txtfsubt.Size = new System.Drawing.Size(136, 20);
            this.txtfsubt.TabIndex = 7;
            this.txtfsubt.TextChanged += new System.EventHandler(this.Txtfsubt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subtotal:";
            // 
            // txtfiva
            // 
            this.txtfiva.Enabled = false;
            this.txtfiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiva.Location = new System.Drawing.Point(83, 164);
            this.txtfiva.Name = "txtfiva";
            this.txtfiva.ReadOnly = true;
            this.txtfiva.Size = new System.Drawing.Size(193, 20);
            this.txtfiva.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IVA:";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(222, 135);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(54, 23);
            this.btncalcular.TabIndex = 18;
            this.btncalcular.Text = "&Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Visible = false;
            // 
            // txtpiva
            // 
            this.txtpiva.Enabled = false;
            this.txtpiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpiva.Location = new System.Drawing.Point(375, 43);
            this.txtpiva.Name = "txtpiva";
            this.txtpiva.ReadOnly = true;
            this.txtpiva.Size = new System.Drawing.Size(77, 20);
            this.txtpiva.TabIndex = 29;
            this.txtpiva.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "% Renta:";
            this.label6.Visible = false;
            // 
            // txtprenta
            // 
            this.txtprenta.Enabled = false;
            this.txtprenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprenta.Location = new System.Drawing.Point(386, 69);
            this.txtprenta.Name = "txtprenta";
            this.txtprenta.ReadOnly = true;
            this.txtprenta.Size = new System.Drawing.Size(66, 20);
            this.txtprenta.TabIndex = 30;
            this.txtprenta.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "% IVA:";
            this.label5.Visible = false;
            // 
            // AdministrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 271);
            this.Controls.Add(this.txtpiva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdministrarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdministrarFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfruc;
        private System.Windows.Forms.Button btndisminuir;
        private System.Windows.Forms.Button btnincrementar;
        private System.Windows.Forms.TextBox txtfviva;
        private System.Windows.Forms.TextBox txtfnombre;
        private System.Windows.Forms.TextBox txtfvrenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfnumfact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfsubt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfiva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpiva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprenta;
        private System.Windows.Forms.Label label5;
    }
}