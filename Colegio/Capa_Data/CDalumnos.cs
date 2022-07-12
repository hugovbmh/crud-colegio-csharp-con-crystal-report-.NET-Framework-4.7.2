using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Data
{
    public class CDalumnos
    {
        private CDconexion conexion = new CDconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            
            comando.Connection = conexion.AbrirConexion(); 
            comando.CommandText = "MostrarAlumnos"; //procedimientoalmacenado
            comando.CommandType = CommandType.StoredProcedure; 
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar(string pnom, string snom, string pape, 
            string sape,int tele, int celu, string dir, string email, 
            DateTime fecha, string observ)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@p_nombre", pnom);
            comando.Parameters.AddWithValue("@s_nombre", snom);
            comando.Parameters.AddWithValue("@p_apellido", pape);
            comando.Parameters.AddWithValue("@s_apellido", sape);
            comando.Parameters.AddWithValue("@telefono", tele);
            comando.Parameters.AddWithValue("@celular", celu);
            comando.Parameters.AddWithValue("@direccion", dir);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@fec_nac", fecha);
            comando.Parameters.AddWithValue("@observ", observ);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();//limpiar los parametros cada vez que termine de hacer una consulta
            
        }

        public void Editar(string pnom, string snom, string pape,
            string sape, int tele, int celu, string dir, string email,
            DateTime fecha, string observ, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@p_nombre", pnom);
            comando.Parameters.AddWithValue("@s_nombre", snom);
            comando.Parameters.AddWithValue("@p_apellido", pape);
            comando.Parameters.AddWithValue("@s_apellido", sape);
            comando.Parameters.AddWithValue("@telefono", tele);
            comando.Parameters.AddWithValue("@celular", celu);
            comando.Parameters.AddWithValue("@direccion", dir);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@fec_nac", fecha);
            comando.Parameters.AddWithValue("@observ", observ);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();//limpiar los parametros cada vez que termine de hacer una consulta

        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idalumno",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
