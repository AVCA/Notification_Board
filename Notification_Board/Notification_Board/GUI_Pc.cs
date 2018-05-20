using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Notification_Board
{
    public partial class GUI_Pc : Form
    {
        // VARIABLES:
        Boolean proyeccion=false;
        GUI_Tv form;

        // ============================================================
        //                     I N T E R F A Z
        // ============================================================
        // 1) Creacion del Form padre. Interfaz base.
        public GUI_Pc()
        {
            InitializeComponent();
            // Creacion del Form Tv. Aunque este creado aun no es visible.
            form = new GUI_Tv();
            // Creacion del Form hijo. Subinterfaz dentro de la Interfaz base.
            // La subinterfaz inicial sera la interfaz de Inicio.
            sub_GUI(new Inicio());

        }
        // 2) Creamos las acciones para los botones
        // correspondientes a la barra superior de la Interfaz
        // Boton: Cerrar
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Boton: Maximizar
        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }
        // Boton: Restaurar
        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 650);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }
        // Boton: Minimizar
        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // 3) Se carga la Interfaz creada
        private void GUI_Pc_Load(object sender, EventArgs e)
        {

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

        // ============================================================
        //                     S U B I N T E R F A Z
        // ============================================================
        // Metodo que permite mostrar la seccion seleccionada
        private void sub_GUI(object subForm)
        {
            if (this.panel_Subinterfaz.Controls.Count > 0)
                this.panel_Subinterfaz.Controls.RemoveAt(0);
            Form fh = subForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Subinterfaz.Controls.Add(fh);
            this.panel_Subinterfaz.Tag = fh;
            fh.Show();
        }
        // Creamos las acciones para los botones
        // correspondientes al menu lateral de la Interfaz
        // Boton: Iniciar proyeccion
        private void btn_GUI_Tv_Click(object sender, EventArgs e)
        { 
            if (proyeccion==false)
            {
                proyeccion = true;
                btn_Iniciar_Proyeccion.Text = "Finalizar proyección";
                btn_Iniciar_Proyeccion.Font = new Font(btn_Iniciar_Proyeccion.Font.FontFamily, 9);
                form.Show();
                sub_GUI(new GUI_Tv());
            }
            else
            {
                proyeccion = false;
                btn_Iniciar_Proyeccion.Font = new Font(btn_Iniciar_Proyeccion.Font.FontFamily, 11);
                btn_Iniciar_Proyeccion.Text = "Iniciar proyección";
                form.Hide();
            }
        }
        // Boton: Inicio
        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            sub_GUI(new Inicio());
        }
        // Boton: Horarios
        private void btn_Horarios_Click(object sender, EventArgs e)
        {
            sub_GUI(new Tablas("Horarios"));
        }
        // Boton: Profesor
        private void btn_Profesor_Click(object sender, EventArgs e)
        {
            sub_GUI(new Tablas("Profesor"));
        }
        // Boton: Materias
        private void btn_Materias_Click(object sender, EventArgs e)
        {
            sub_GUI(new Tablas("Materias"));
        }
        // Boton: Imparte
        private void btn_Imparte_Click(object sender, EventArgs e)
        {
            sub_GUI(new Tablas("Impartido"));
        }
        // Boton: Ayuda
        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            sub_GUI(new Ayuda());
        }
        // Boton: Avisos
        private void btn_Avisos_Click(object sender, EventArgs e)
        {
            sub_GUI(new Tablas("Archivo"));
        }
        // Boton: Consultar salones disponibles
        private void btn_Salones_Click(object sender, EventArgs e)
        {
            sub_GUI(new Tablas("Salones"));
        }
        // Boton: Asistencias
        private void btn_Asistencia_Click(object sender, EventArgs e)
        {
            sub_GUI(new Tablas("Asistencias"));
        }
    }
}
