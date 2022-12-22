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


        public string guardar_articulos(int nOpcion,Propiedades_Articulos oArticulo)
        {
            string Rpta = "";
            string sqlTarea = "";
            MySqlConnection sqlConexion = new MySqlConnection();
            try
            {
                sqlConexion = Conexion.getInstancia().crearConexion();
                if (nOpcion==1) //Nuevo registro
                {
                    sqlTarea = "insert into tb_articulos(descripcion_articulo," +
                                                         "marca_articulo," +
                                                         "codigo_unidad_medida, " +
                                                         "codigo_categoria, " +
                                                         "stock, " +
                                                         "fecha_creacion, " +
                                                         "fecha_modificacion) " +
                                                         "values('" + oArticulo.descripcion_articulo + "', " +
                                                                "'" + oArticulo.marca_articulo + "', " +
                                                                "'" + oArticulo.codigo_unidad_medida + "', " +
                                                                "'" + oArticulo.codigo_categoria+ "', " +
                                                                "'" + oArticulo.stock + "', " +
                                                                "'" + oArticulo.fecha_creacion + "', " +
                                                                "'" + oArticulo.fecha_modificacion + "')";
                                                            
                       
                }
                else // Actualizar registro
                {
                    sqlTarea = "update tb_articulos set descripcion_articulo = '" + oArticulo.descripcion_articulo + "', " +
                                                        "marca_articulo = '" + oArticulo.marca_articulo + "', " +
                                                        "codigo_unidad_medida = '" + oArticulo.codigo_unidad_medida + "', " +
                                                        "codigo_categoria = '" + oArticulo.stock + "', " +
                                                        "stock = '" + oArticulo.stock + "', " +
                                                        "fecha_creacion = '" + oArticulo.fecha_creacion + "'," +
                                                        "fecha_modificacion = '" + oArticulo.fecha_modificacion + "'" +
                                                        "where codigo_articulo='" + oArticulo.codigo_articulo + "'";
                }
                MySqlCommand Comando = new MySqlCommand(sqlTarea, sqlConexion);
                sqlConexion.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {

                Rpta= ex.Message;

            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
            return Rpta;
        }
    }
}
