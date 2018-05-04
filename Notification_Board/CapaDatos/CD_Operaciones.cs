﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Operaciones
    {
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable Mostrar(string titulo)
        {
            comando.Connection = conexion.AbrirConexion();
            switch(titulo)
            {
                case "Profesor":
                    comando.CommandText = "call VerProfesor";
                    break;
                case "Materias":
                    comando.CommandText = "call VerMateria";
                    break;
                case "Horarios":
                    comando.CommandText = "call VerMateria";
                    break;
                case "Archivo":
                    comando.CommandText = "call VerArchivos";
                    break;
            }
            
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        // select InsertarProfesor(02,'Maestro 2');

        public void Operaciones(string tabla,string operacion, string v1, string v2, string v3, string v4, string v5)
        {
            comando.Connection = conexion.AbrirConexion();
            switch (tabla)
            {
                case "Profesor":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarProfesor('" + v1 + "','" + v2 + "')";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarProfesor('" + v1 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarProfesor('" + v1 + "','" +v2 + "','" + v3 + "')";
                            break;
                    }          
                    break;
                case "Materias":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarMateria('" + v1 + "','" + v2 + "')";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarMateria('" + v1 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarMateria('" + v1 + "','" + v2 + "','" + v3 + "')";
                            break;
                    }
                    break; 
                case "Horarios":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarMateria('" + v1 + "','" + v2 + "')";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarMateria('" + v1 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarMateria('" + v1 + "','" + v2 + "','" + v3 + "')";
                            break;
                    }
                    break;
                case "Archivo":
                    switch (operacion)
                    {
                        case "Insert":
                            comando.CommandText = "select InsertarArchivo('" + v1 + "','" + v2 + "','" + v3 + "')";
                            break;
                        case "Delete":
                            comando.CommandText = "call EliminarMateria('" + v1 + "')";
                            break;
                        case "Update":
                            comando.CommandText = "select ActualizarMateria('" + v1 + "','" + v2 + "','" + v3 + "')";
                            break;
                    }
                    break;
            }
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
