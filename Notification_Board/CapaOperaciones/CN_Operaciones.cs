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
        public String respuesta;
        private CD_Operaciones objetoCD = new CD_Operaciones();

        public DataTable Mostrar_DGV(string titulo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar_DGV(titulo);
            return tabla;
        }
        public DataTable Mostrar_CB(string titulo, string sub_titulo, String v1, String v2, String v3, String v4, String v5, String v6)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar_CB(titulo, sub_titulo,v1,v2,v3,v4,v5,v6);
            return tabla;
        }
        public String Operaciones(string tabla,string Operaciones, string v1, string v2, string v3, string v4, string v5)
        {
            respuesta=objetoCD.Operaciones(tabla,Operaciones,v1,v2,v3,v4,v5);
            return respuesta;
        }

    }
}
