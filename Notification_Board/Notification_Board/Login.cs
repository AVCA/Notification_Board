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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Autenticar_Click(object sender, EventArgs e)
        {
            try
            {
                String pass = this.txtb_Password.Text;
                //Crea una conexion con la base de datos
                MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=escuela; Uid=root; pwd="+pass+";");
                Conexion.Open();
                Conexion.Close();
                GUI_Pc form = new GUI_Pc();
                form.Show();
                this.Hide();
            }
            catch (MySqlException)
            {
                this.txtb_Password.BackColor = Color.Red;   
            }
        }

        private void txtb_Password_TextChanged(object sender, EventArgs e)
        {
            this.txtb_Password.BackColor = Color.White;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // 2) Creamos las acciones para los botones
        // correspondientes a la barra superior de la Interfaz
        // Boton: Cerrar
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 4)  Elementos que permiten trasladar la interfaz 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Accion: Mover la interfaz
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtb_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    String pass = this.txtb_Password.Text;
                    //Crea una conexion con la base de datos
                    MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=escuela; Uid=root; pwd=" + pass + ";");
                    Conexion.Open();
                    Conexion.Close();
                    GUI_Pc form = new GUI_Pc();
                    form.Show();
                    this.Hide();
                }
                catch (MySqlException)
                {
                    this.txtb_Password.BackColor = Color.Red;
                }
            }
        }
    }
}
