using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Sol_Almacen.Presentacion
{
    public class Datos_Articulos
    {
        public DataTable listado_articulos(string cTexto)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlConexion = new MySqlConnection();
            try
            {
                sqlConexion = Conexion.getInstancia().crearConexion();
                string sqlTarea = "select a.codigo_articulo," +
                                   " a.descripcion_articulo," +
                                   " a.marca_articulo," +
                                   " a.stock," +
                                   " a.codigo_unidad_medida," +
                                   " a.codigo_categoria," +
                                   " c.descripcion_unidad_medida" +
                                   " from tb_articulos a " +
                                   " inner join tb_categorias b on a.codigo_categoria=b.codigo_categoria " +
                                   " inner join tb_unidades_medidas c on a.codigo_unidad_medida=c.codigo_unidad_medida"+
                                   " where a.descripcion_articulo like '"+cTexto+"' "+
                                   " order by a.codigo_articulo";
                MySqlCommand comando = new MySqlCommand(sqlTarea,sqlConexion);
                comando.CommandTimeout= 60;
                sqlConexion.Open();
                resultado=comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }
    }
}
