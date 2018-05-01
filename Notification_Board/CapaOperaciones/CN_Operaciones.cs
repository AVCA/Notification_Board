using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaOperaciones
{
    public class CN_Operaciones
    {
        private CD_Operaciones objetoCD = new CD_Operaciones();

        public DataTable Mostrar(string titulo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(titulo);
            return tabla;
        }
        public void Operaciones(string tabla,string ope, string v1, string v2, string v3, string v4, string v5)
        {
            objetoCD.Operaciones(tabla,ope,v1,v2,v3,v4,v5);
        }
    }
}
