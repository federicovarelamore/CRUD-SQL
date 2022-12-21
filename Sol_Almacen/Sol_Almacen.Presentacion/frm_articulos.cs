using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion
{
    public partial class frm_articulos : Form
    {
        public frm_articulos()
        {
            InitializeComponent();
        }
        #region "mis métodos"
        private void formato_articulos()
        {
            dgv_articulos.Columns[0].Width = 80;
            dgv_articulos.Columns[0].HeaderText = "CÓDIGO";
            dgv_articulos.Columns[1].Width = 250;
            dgv_articulos.Columns[1].HeaderText = "ARTÍCULO";
            dgv_articulos.Columns[2].Width = 150;
            dgv_articulos.Columns[2].HeaderText = "MARCA";
            dgv_articulos.Columns[3].Width = 100;
            dgv_articulos.Columns[3].HeaderText = "STOCK";
            dgv_articulos.Columns[4].Visible = false;
            dgv_articulos.Columns[5].Visible = false;
            dgv_articulos.Columns[6].HeaderText = "DESCRIPCIÓN";
            dgv_articulos.Columns[6].Width = 175;
        }
        private void listado_articulos(string cTexto)
        {
            Datos_Articulos datos = new Datos_Articulos();
            dgv_articulos.DataSource = datos.listado_articulos(cTexto);
            this.formato_articulos();
        }

        private void Estado_botones_principales(bool estado)
        {
            btnNuevo.Enabled = estado;
            btnEliminar.Enabled = estado;
            btnActualizar.Enabled = estado;
            btnReporte.Enabled = estado;
            btnSalir.Enabled = estado;
        }
        #endregion
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_articulos_Load(object sender, EventArgs e)
        {
            this.listado_articulos("%");
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarcaArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnidadMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcionArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcionArticulo.ReadOnly = false;
            txtDescripcionCategoria.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtUnidadMedida.ReadOnly = false;
            txtStock.ReadOnly = false;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLupaCategoria.Enabled = true;
            btnLupaUnidadMedida.Enabled= true;

            btnGuardar.Visible= true;
            btnCancelar.Visible= true;

            txtDescripcionArticulo.Focus();

            txtBuscar.ReadOnly = true;
            btnBuscar.Enabled = false;

            dgv_articulos.Enabled = false;

            this.Estado_botones_principales(false);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.listado_articulos("%"+txtBuscar.Text.Trim()+"%");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcionArticulo.ReadOnly = true;
            txtDescripcionCategoria.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtUnidadMedida.ReadOnly = true;
            txtStock.ReadOnly = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLupaCategoria.Enabled = false;
            btnLupaUnidadMedida.Enabled = false;

            btnGuardar.Visible = false;
            btnCancelar.Visible = false;

            txtBuscar.ReadOnly = false;
            btnBuscar.Enabled = true;

            dgv_articulos.Enabled = true;

            txtBuscar.Focus();

            this.Estado_botones_principales(true);
        }
    }
}
