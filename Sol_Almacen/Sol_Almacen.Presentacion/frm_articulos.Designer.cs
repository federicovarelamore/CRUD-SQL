namespace Sol_Almacen.Presentacion
{
    partial class frm_articulos
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
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLupaCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLupaUnidadMedida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.AllowUserToAddRows = false;
            this.dgv_articulos.AllowUserToDeleteRows = false;
            this.dgv_articulos.AllowUserToOrderColumns = true;
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Location = new System.Drawing.Point(6, 47);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.ReadOnly = true;
            this.dgv_articulos.Size = new System.Drawing.Size(800, 320);
            this.dgv_articulos.TabIndex = 0;
            this.dgv_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_articulos_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Info;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(6, 408);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 86);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Info;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(157, 408);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 86);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(309, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 86);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.Info;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(468, 408);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 86);
            this.btnReporte.TabIndex = 19;
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(616, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 86);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1071, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(916, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 38);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(855, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "STOCK:";
            // 
            // btnLupaCategoria
            // 
            this.btnLupaCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLupaCategoria.Enabled = false;
            this.btnLupaCategoria.Location = new System.Drawing.Point(1177, 87);
            this.btnLupaCategoria.Name = "btnLupaCategoria";
            this.btnLupaCategoria.Size = new System.Drawing.Size(38, 24);
            this.btnLupaCategoria.TabIndex = 30;
            this.btnLupaCategoria.Text = ":::";
            this.btnLupaCategoria.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(822, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "CATEGORÍA:";
            // 
            // btnLupaUnidadMedida
            // 
            this.btnLupaUnidadMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLupaUnidadMedida.Enabled = false;
            this.btnLupaUnidadMedida.Location = new System.Drawing.Point(1177, 127);
            this.btnLupaUnidadMedida.Name = "btnLupaUnidadMedida";
            this.btnLupaUnidadMedida.Size = new System.Drawing.Size(38, 24);
            this.btnLupaUnidadMedida.TabIndex = 27;
            this.btnLupaUnidadMedida.Text = ":::";
            this.btnLupaUnidadMedida.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(848, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "MEDIDA:";
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(916, 90);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.ReadOnly = true;
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(255, 20);
            this.txtDescripcionCategoria.TabIndex = 24;
            this.txtDescripcionCategoria.TextChanged += new System.EventHandler(this.txtMarcaArticulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(852, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "MARCA:";
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(916, 50);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.ReadOnly = true;
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(255, 20);
            this.txtDescripcionArticulo.TabIndex = 22;
            this.txtDescripcionArticulo.TextChanged += new System.EventHandler(this.txtDescripcionArticulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(833, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "ARTÍCULO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(916, 206);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(255, 20);
            this.txtStock.TabIndex = 35;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(916, 168);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(255, 20);
            this.txtMarca.TabIndex = 36;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(916, 130);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.ReadOnly = true;
            this.txtUnidadMedida.Size = new System.Drawing.Size(255, 20);
            this.txtUnidadMedida.TabIndex = 37;
            this.txtUnidadMedida.TextChanged += new System.EventHandler(this.txtUnidadMedida_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(340, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 24);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "BUSCAR:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(79, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(255, 20);
            this.txtBuscar.TabIndex = 38;
            // 
            // frm_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 506);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLupaCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLupaUnidadMedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgv_articulos);
            this.MaximizeBox = false;
            this.Name = "frm_articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_articulos";
            this.Load += new System.EventHandler(this.frm_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLupaCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLupaUnidadMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}