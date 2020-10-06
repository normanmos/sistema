namespace LatamDS.formularios.cliente
{
    partial class ConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCliente));
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgcliente = new System.Windows.Forms.DataGridView();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnrefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.BackgroundImage")));
            this.btnrefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Location = new System.Drawing.Point(250, 56);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(24, 25);
            this.btnrefrescar.TabIndex = 11;
            this.btnrefrescar.UseVisualStyleBackColor = false;
            this.btnrefrescar.Click += new System.EventHandler(this.Btnrefrescar_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfiltro.Location = new System.Drawing.Point(80, 59);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(165, 20);
            this.txtfiltro.TabIndex = 14;
            this.txtfiltro.TextChanged += new System.EventHandler(this.Txtfiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clientes";
            // 
            // dgcliente
            // 
            this.dgcliente.AllowUserToAddRows = false;
            this.dgcliente.AllowUserToOrderColumns = true;
            this.dgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcliente.Location = new System.Drawing.Point(12, 87);
            this.dgcliente.MultiSelect = false;
            this.dgcliente.Name = "dgcliente";
            this.dgcliente.ReadOnly = true;
            this.dgcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcliente.Size = new System.Drawing.Size(973, 324);
            this.dgcliente.TabIndex = 12;
            this.dgcliente.DoubleClick += new System.EventHandler(this.Dgcliente_DoubleClick);
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(766, 420);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(69, 23);
            this.btncrear.TabIndex = 15;
            this.btncrear.Text = "&Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.Btncrear_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(841, 420);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(69, 23);
            this.btnmodificar.TabIndex = 16;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(916, 420);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(69, 23);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 455);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgcliente);
            this.Name = "ConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgcliente;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
    }
}