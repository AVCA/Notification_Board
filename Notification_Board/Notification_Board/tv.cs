using CapaOperaciones;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification_Board
{
    public partial class tv : Form
    {   //Atributos de la clase
        public DataTable tabla; //Tabla para almacenar consulta
        public bool flag=true; //Bandera de control
        public int numRows;    //Almacena el numero de filas
        public int count = 0;  //Contador para iteracion

        public tv()
        {   //Atributos del form
            this.StartPosition = FormStartPosition.Manual;                
            this.showOnScreen(1); //Manda form a segunda pantalla            
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        //Metodo para mostran el form en la segunda pantalla
        void showOnScreen(int screenNumber)
        {   //Guarda un arreglo de pantallas disponibles
            Screen[] screens = Screen.AllScreens;
            //Si la pantalla solicitada existe
            if (screenNumber >= 0 && screenNumber < screens.Length)
            {
                bool maximised = false;
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    maximised = true;
                }//Posiciona el form en la pantalla solicitada
                Location = screens[screenNumber].WorkingArea.Location;
                if (maximised)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }
        //Clase magica que hace efectitos :v
        public static class Util
        {
            public enum Effect { Roll, Slide, Center, Blend }

            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];

                if (ctl.Visible)
                {
                    flags |= 0x10000; angle += 180;
                }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == Effect.Blend) throw new ArgumentException();
                }

                flags |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Animation failed");
                ctl.Visible = !ctl.Visible;
            }

            private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
            private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

            [DllImport("user32.dll")]
            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
        }

        private void tv_Load(object sender, EventArgs e)
        {   //Crea una conexion con la base de datos
            MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=escuela; Uid=root; pwd=1219975;");
            Conexion.Open();//Abre la conexion
            MySqlCommand comando = new MySqlCommand();//Objeto que ejecuta comandos de MySQL
            comando.Connection = Conexion;
            comando.CommandText = "call VerArchivos";//Asigna el comando
            MySqlDataReader leer = comando.ExecuteReader();//Ejecuta el comando
            tabla = new DataTable();
            tabla.Load(leer);//Guarda el resultado en el DataTable global            
            Conexion.Close();
            numRows=tabla.Rows.Count;            
            dataGridView1.DataSource = tabla;            
            this.ImageTimer.Interval = 100;
            this.ImageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            DataRow row;count = (count+1) % numRows;
            row = tabla.Rows[count];
            this.ImageTimer.Stop();
            this.ImageTimer.Interval = int.Parse(row["duracion"].ToString()) * 1000;
            this.ImageTimer.Start();
            String dir = "C:\\Program Files\\NotificationBoard\\img\\" + row["nombre"];
            if (flag == true)
            {               
                flag = false;     
                this.pbxImagen1.Image = Image.FromFile(dir);
                this.pbxImagen1.BringToFront();
                Util.Animate(this.pbxImagen1, Util.Effect.Roll, 250, 360);
            }
            else
            {              
                flag=true;  
                this.pbxImagen2.Image = Image.FromFile(dir);
                Util.Animate(this.pbxImagen1, Util.Effect.Roll, 250, 360);
                //this.pbxImagen2.BringToFront(); 
            }
        }
    }
}
