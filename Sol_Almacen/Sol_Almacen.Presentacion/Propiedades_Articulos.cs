using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Almacen.Presentacion
{
    public class Propiedades_Articulos
    {
        public int codigo_articulo { get; set; }
        public string descripcion_articulo { get; set; }
        public string marca_articulo { get; set; }
        public int codigo_unidad_medida { get; set; }
        public int codigo_categoria { get; set; }
        public decimal stock { get; set; }
        public string fecha_creacion { get; set; }
        public string fecha_modificacion { get; set; }
    }
}
