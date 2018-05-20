using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace CapaDatos
{
    public class CD_Operaciones
    {
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();
        String respuesta = "";

        public DataTable Mostrar_DGV(string titulo)
        {
            comando.Connection = conexion.AbrirConexion();
            switch (titulo)
            {
                case "Profesor":
                    comando.CommandText = "call VerProfesor";
                    break;
                case "Materias":
                    comando.CommandText = "call VerMateria";
                    break;
                case "Horarios":
                    comando.CommandText = "call VerImparte";
                    break;
                case "Archivo":
                    comando.CommandText = "call VerArchivos";
                    break;
                case "Impartido":
                    comando.CommandText = "call VerImpartido";
                    break;
                case "Asistencias":
                    comando.CommandText = "call VerImparte";
                    break;
                case "Salones":
                    DateTime ahora = DateTime.Now;
                    int dia = (int)ahora.DayOfWeek;
                    int hora = ahora.Hour;
                    comando.CommandText = "call VerSalonesLibres(" + dia + "," + hora + ")";
                    break;
                case "Reporte de Asistencias":
                    comando.CommandText = "call VerAsistencia()";
                    break;
            }

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Mostrar_CB(string titulo, string sub_titulo, string v1)
        {
            comando.Connection = conexion.AbrirConexion();
            switch (sub_titulo)
            {
                case "Dia":
                    comando.CommandText = "call VerDia";
                    break;
                case "Hora":
                    comando.CommandText = "call VerHorario";
                    break;
                case "Salon":
                    comando.CommandText = "call VerSalon";
                    break;
                case "Profesor":
                    comando.CommandText = "call VerProfesor";
                    break;
                case "Profesor_Imparte":
                    comando.CommandText = "call VerMateria_Imparte_Profesor('" + v1 + "')";
                    break;
                case "Materia_Imparte":
                    comando.CommandText = "call VerMateria_Impartidas";
                    break;
                case "Materia":
                    comando.CommandText = "call VerMateria";
                    break;
            }
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public String Operaciones(string tabla, string operacion, string v1, string v2, string v3, string v4, string v5)
        {
            comando.Connection = conexion.AbrirConexion();
            switch (tabla)
            {
                case "Profesor":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarProfesor('" + v1 + "','" + v2 + "') as resp";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarProfesor('" + v1 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarProfesor('" + v1 + "','" + v2 + "','" + v3 + "') as resp";
                            break;
                    }
                    break;
                case "Materias":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarMateria('" + v1 + "','" + v2 + "') as resp";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarMateria('" + v1 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarMateria('" + v1 + "','" + v2 + "','" + v3 + "') as resp";
                            break;
                    }
                    break;
                case "Horarios":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarImparte('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "','" + v5 + "') as resp";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarImparte('" + v1 + "','" + v2 + "','" + v3 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarMateria('" + v1 + "','" + v2 + "','" + v3 + "') as resp";
                            break;
                    }
                    break;
                case "Archivo":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarArchivo('" + v1 + "','" + v2 + "','" + v3 + "') as resp";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarArchivo('" + v1 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarArchivo('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "') as resp";
                            break;
                    }
                    break;
                case "Impartido":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarImpartido('" + v1 + "','" + v2 + "') as resp";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarImpartido('" + v1 + "','" + v2 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarImpartido('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "') as resp";
                            break;
                    }
                    break;
                case "Asistencia":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarAsistencia('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "','" + v5 + "') as resp";
                            break;
                    }
                    break;
            }
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                respuesta = leer[0].ToString();
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            leer.Close();
            return respuesta;
        }
        public DataTable Asistencia(string v1, string v2)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "call VerPorHora(" + v1 + "," + v2 + ")";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
