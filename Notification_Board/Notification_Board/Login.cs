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
    }
}
