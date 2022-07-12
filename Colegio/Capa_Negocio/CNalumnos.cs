using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Data;
namespace Capa_Negocio
{
    public class CNalumnos
    {
        private CDalumnos obj = new CDalumnos();

        public DataTable MostrarAlumnos()
        {
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar();
            return tabla;
        }
        public void InsertarAlumno(string pnom, string snom, string pape,
            string sape, string tele, string celu, string dir, string email,
            string fecha, string observ)
        {
            obj.Insertar(pnom,snom,pape,sape, Convert.ToInt32(tele),Convert.ToInt32(celu),dir,email,Convert.ToDateTime(fecha),observ); 
        }

        public void EditarAlumno(string pnom, string snom, string pape,
            string sape, string tele, string celu, string dir, string email,
            string fecha, string observ,string id)
        {
            obj.Editar(pnom, snom, pape, sape, Convert.ToInt32(tele), Convert.ToInt32(celu), dir, email, Convert.ToDateTime(fecha), observ, Convert.ToInt32(id));
        }

        public void EliminarAlumno(string id)
        {
            obj.Eliminar(Convert.ToInt32(id));
        }
    }
}
