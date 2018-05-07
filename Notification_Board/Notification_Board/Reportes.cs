using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification_Board
{
    public partial class Reportes : Form
    {
        //Atributos de la clase
        public DataTable tabla; //Tabla para almacenar consulta
        private String titulo;
        public Reportes(String t)
        {
            this.titulo = t;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            //Crea una conexion con la base de datos
            MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=escuela; Uid=root; pwd=root;");
            Conexion.Open();//Abre la conexion
            MySqlCommand comando = new MySqlCommand();//Objeto que ejecuta comandos de MySQL
            comando.Connection = Conexion;
            tabla = new DataTable();

            if (this.titulo.Equals("Salones"))
            {
                this.lbl_Titulo.Text = "Salones Libres";
                DateTime ahora = DateTime.Now;
                int dia = (int)ahora.DayOfWeek;
                int hora = ahora.Hour;
                comando.CommandText = "call VerSalonesLibres(" + dia + "," + hora + ")";//Asigna el comando
                MySqlDataReader leer = comando.ExecuteReader();//Ejecuta el comando                
                tabla.Load(leer);//Guarda el resultado en el DataTable global                                  
                this.dgv_cosulta.DataSource = tabla;
            }else{
                this.lbl_Titulo.Text = "Asistencias";
                DateTime ahora = DateTime.Now;
                int dia = (int)ahora.DayOfWeek;
                int hora = ahora.Hour;
                comando.CommandText = "call VerAsistencia()";//Asigna el comando
                MySqlDataReader leer = comando.ExecuteReader();//Ejecuta el comando                
                tabla.Load(leer);//Guarda el resultado en el DataTable global                                  
                this.dgv_cosulta.DataSource = tabla;
            }

        }
    }
}
