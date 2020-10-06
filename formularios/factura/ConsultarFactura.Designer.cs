namespace LatamDS.formularios.factura
{
    partial class ConsultarFactura
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgfactura = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnimprimirdet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgfactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Location = new System.Drawing.Point(850, 55);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(25, 25);
            this.btnbuscar.TabIndex = 36;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hasta:";
            // 
            // dtphasta
            // 
            this.dtphasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtphasta.CustomFormat = "";
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(644, 59);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtphasta.Size = new System.Drawing.Size(200, 20);
            this.dtphasta.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Desde:";
            // 
            // dtpdesde
            // 
            this.dtpdesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpdesde.CustomFormat = "";
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(378, 59);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpdesde.Size = new System.Drawing.Size(200, 20);
            this.dtpdesde.TabIndex = 32;
            this.dtpdesde.Value = new System.DateTime(2019, 7, 15, 0, 0, 0, 0);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnrefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Location = new System.Drawing.Point(282, 56);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(24, 25);
            this.btnrefrescar.TabIndex = 29;
            this.btnrefrescar.UseVisualStyleBackColor = false;
            this.btnrefrescar.Click += new System.EventHandler(this.Btnrefrescar_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfiltro.Location = new System.Drawing.Point(112, 59);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(165, 20);
            this.txtfiltro.TabIndex = 31;
            this.txtfiltro.TextChanged += new System.EventHandler(this.Txtfiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "Facturas";
            // 
            // dgfactura
            // 
            this.dgfactura.AllowUserToAddRows = false;
            this.dgfactura.AllowUserToOrderColumns = true;
            this.dgfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfactura.Location = new System.Drawing.Point(15, 86);
            this.dgfactura.MultiSelect = false;
            this.dgfactura.Name = "dgfactura";
            this.dgfactura.ReadOnly = true;
            this.dgfactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgfactura.Size = new System.Drawing.Size(921, 324);
            this.dgfactura.TabIndex = 28;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(867, 416);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(69, 23);
            this.btneliminar.TabIndex = 39;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(792, 416);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(69, 23);
            this.btncrear.TabIndex = 37;
            this.btncrear.Text = "&Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.Btncrear_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnimprimir.BackgroundImage = global::LatamDS.Properties.Resources.imprimir;
            this.btnimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Location = new System.Drawing.Point(881, 55);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(28, 26);
            this.btnimprimir.TabIndex = 40;
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnimprimirdet
            // 
            this.btnimprimirdet.Location = new System.Drawing.Point(15, 416);
            this.btnimprimirdet.Name = "btnimprimirdet";
            this.btnimprimirdet.Size = new System.Drawing.Size(69, 23);
            this.btnimprimirdet.TabIndex = 41;
            this.btnimprimirdet.Text = "&Detalle";
            this.btnimprimirdet.UseVisualStyleBackColor = true;
            this.btnimprimirdet.Click += new System.EventHandler(this.btnimprimirdet_Click);
            // 
            // ConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 445);
            this.Controls.Add(this.btnimprimirdet);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgfactura);
            this.Name = "ConsultarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgfactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgfactura;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnimprimirdet;
    }
}