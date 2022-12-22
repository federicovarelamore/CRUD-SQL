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

        #region "mis variables"

        int nCodigoArticulo = 0; 
        int nEstadoGuarda = 0; // 1 = inserta 2 = actualiza

        #endregion

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

        private void Estado_botones_procesos(bool estado) 
        {
            txtDescripcionArticulo.ReadOnly = estado;
            txtDescripcionCategoria.ReadOnly = estado;
            txtMarca.ReadOnly = estado;
            txtUnidadMedida.ReadOnly = estado;
            txtStock.ReadOnly = estado;

            btnGuardar.Enabled = !estado;
            btnCancelar.Enabled = !estado;
            btnLupaCategoria.Enabled = !estado;
            btnLupaUnidadMedida.Enabled = !estado;

            btnGuardar.Visible = !estado;
            btnCancelar.Visible = !estado;

            txtBuscar.ReadOnly = !estado;
            btnBuscar.Enabled = estado;
        }

        private void Limpia_texto()
        {
            txtDescripcionArticulo.Text = "";
            txtMarca.Text = "";
            txtStock.Text = "";
            txtUnidadMedida.Text = "";
            txtDescripcionCategoria.Text = "";

        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_articulo"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigoArticulo = Convert.ToInt32(dgv_articulos.CurrentRow.Cells["codigo_articulo"].Value);
                txtDescripcionArticulo.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["descripcion_articulo"].Value);
                txtMarca.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["marca_articulo"].Value);
                txtUnidadMedida.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_unidad_medida"].Value);
                txtDescripcionCategoria.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_categoria"].Value);
                txtStock.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["stock"].Value);
            }
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
            Estado_botones_procesos(false);

            txtDescripcionArticulo.Focus();

           

            dgv_articulos.Enabled = false;

            this.Estado_botones_principales(false);
            this.Limpia_texto();

            nEstadoGuarda = 1; // nuevo registro

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.listado_articulos("%"+txtBuscar.Text.Trim()+"%");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Estado_botones_procesos(true);

            dgv_articulos.Enabled = true;

            txtBuscar.Focus();

            this.Estado_botones_principales(true);
            this.Limpia_texto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2; // actualiza registro
            Estado_botones_procesos(false);
            txtDescripcionArticulo.Focus();
            dgv_articulos.Enabled = false;
            this.Estado_botones_principales(false);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            Propiedades_Articulos oArticulos = new Propiedades_Articulos();
            oArticulos.codigo_articulo = nCodigoArticulo;
            oArticulos.descripcion_articulo = txtDescripcionArticulo.Text.Trim();
            oArticulos.marca_articulo = txtMarca.Text.Trim();
            oArticulos.codigo_unidad_medida = 1;
            oArticulos.codigo_categoria = 1;
            oArticulos.stock = Convert.ToInt32(txtStock.Text);
            oArticulos.fecha_creacion = DateTime.Now.ToString("yyyy-MM-dd");
            oArticulos.fecha_modificacion = DateTime.Now.ToString("yyyy-MM-dd");
            nCodigoArticulo = 0;

            Datos_Articulos Datos = new Datos_Articulos();
            rpta = Datos.guardar_articulos(nEstadoGuarda, oArticulos);

            if (rpta.Equals("OK"))
            {
                this.Limpia_texto();
                this.Estado_botones_procesos(false);
                this.Estado_botones_principales(true);
                this.listado_articulos("%");
                MessageBox.Show("El registro se ha insertado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }
    }
}
