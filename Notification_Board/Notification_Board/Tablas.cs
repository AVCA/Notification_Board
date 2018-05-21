using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaOperaciones;
using System.IO;

namespace Notification_Board
{
    public partial class Tablas : Form
    {
        // VARIABLES:
        CN_Operaciones ObjetoCN = new CN_Operaciones();
        DataTable tDia = new DataTable();
        DataTable tSalon = new DataTable();
        DataTable tHora = new DataTable();
        DataTable tProfesor = new DataTable();
        DataTable tMateria = new DataTable();
        public string titulo, respuesta;
        private string v1_u = null, v2_u, v3_u;
        private bool actualizar = false;

        // Metodo que permite mostrar la seccion seleccionada
        private void sub_GUI(object subForm)
        {
            if (this.Controls.Count > 0)
                this.Controls.RemoveAt(0);
            Form fh = subForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            this.Tag = fh;
            fh.Show();
        }

        // 1) Creacion del Form base.
        public Tablas(String t)
        {
            titulo = t; // String recibido desde el Form GUI_Pc.
            InitializeComponent();
        }
        // 2) Se carga la Interfaz creada.
        private void Tablas_Load(object sender, EventArgs e)
        {
            Mostrar_DGV();
            Formulario();
        }
        // 3.1) Se genera el DataGridView con los registros necesarios
        // dependiendo de la seccion que se seleccione.
        private void Mostrar_DGV()
        {
            // Objeto que permite realizar operaciones SQL
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            // Establecemos la fuente de datos de la tabla.
            // Esta tabla obtendra el conjunto de tuplas resultante de
            // la consulta generada dependiendo del titulo de la seccion.
            dgv_Tabla.DataSource = ObjetoCN.Mostrar_DGV(titulo);
        }
        // 3.2) Se genera el ComboBox con los registros necesarios
        // dependiendo de la seccion que se seleccione.
        private void Mostrar_CB(ComboBox cb, String sub_titulo)
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            DataTable tabla_cb = new DataTable();
            int j = 0;
            switch (sub_titulo)
            {
                case "Dia":
                    tDia = ObjetoCN.Mostrar_CB(titulo, sub_titulo, "", "", "", "", "", "");
                    tabla_cb = tDia; j = 1;
                    break;
                case "Profesor":
                    tProfesor = ObjetoCN.Mostrar_CB(titulo, sub_titulo, "", "", "", "", "", "");
                    tabla_cb = tProfesor; j = 1;
                    break;
                case "Profesor_Imparte":
                    String v1 = tMateria.Rows[cb_v4.SelectedIndex][0].ToString();
                    tProfesor = ObjetoCN.Mostrar_CB(titulo, sub_titulo, v1, "", "", "", "", "");
                    tabla_cb = tProfesor; j = 1;
                    break;
                case "Materia":
                    tMateria = ObjetoCN.Mostrar_CB(titulo, sub_titulo, "", "", "", "", "", "");
                    tabla_cb = tMateria; j = 1;
                    break;
                case "Materia_Imparte":
                    tMateria = ObjetoCN.Mostrar_CB(titulo, sub_titulo, "", "", "", "", "", "");
                    tabla_cb = tMateria; j = 1;
                    break;
                case "Hora":
                    tHora = ObjetoCN.Mostrar_CB(titulo, sub_titulo, "", "", "", "", "", "");
                    tabla_cb = tHora; j = 1;
                    break;
                case "Salon_Hora_Dia":
                    String Hora = tHora.Rows[cb_v2.SelectedIndex][0].ToString();
                    String v2 = "0", v3 = "0", v4 = "0", v5 = "0", v6 = "0";
                    if (chkb_Lunes.Checked)
                        v2 = "1";
                    if (chkb_Martes.Checked)
                        v3 = "2";
                    if (chkb_Miercoles.Checked)
                        v4 = "3";
                    if (chkb_Jueves.Checked)
                        v5 = "4";
                    if (chkb_Viernes.Checked)
                        v6 = "5";
                    tSalon = ObjetoCN.Mostrar_CB(titulo, sub_titulo, Hora, v2, v3, v4, v5, v6);
                    tabla_cb = tSalon; j = 0;
                    break;
            }

            for (int i = 0; i < tabla_cb.Rows.Count; i++)
            {
                cb.Items.Add(tabla_cb.Rows[i][j]);
            }
        }
        // 4) Metodos que muestran los elementos necesarios segun la
        // seccion elegida. Aqui se encuentran los botones,
        // etiquetas, listas, etc.
        private void Asistencias()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            // Botones
            btn_Reporte_Asistencia.Visible = true;
            btn_Bajas.Visible = false;
            btn_Actualizar.Visible = false;
            btn_Reporte_.Visible = true;
            //DGV: Boton
            DataGridViewButtonColumn dgv_btn_asistencia = new DataGridViewButtonColumn();
            dgv_btn_asistencia.Text = "Asistencia";
            dgv_btn_asistencia.UseColumnTextForButtonValue = true;
            dgv_btn_asistencia.FlatStyle = FlatStyle.Flat;
            dgv_btn_asistencia.Width = 30;
            dgv_Tabla.Columns.Add(dgv_btn_asistencia);
            dgv_btn_asistencia.DataGridView.CellMouseDown += new DataGridViewCellMouseEventHandler(Alta_Asistencia);
            //DGV: Columnas
            dgv_Tabla.Columns[5].Visible = false;
            dgv_Tabla.Columns[6].Visible = false;
            dgv_Tabla.Columns[7].Visible = false;
            dgv_Tabla.Columns[8].Visible = false;
            //dgv_Tabla.Columns[9].Visible = false;
            // Paneles
            panel_Altas.Visible = true;
            tbl_l_panel_Altas.Visible = true;
        }
        private void Salones()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            // Botones
            btn_Actualizar.Visible = false;
            btn_Bajas.Visible = false;
            // Paneles
            panel_Altas.Visible = true;
        }
        private void Reporte_Asistencias()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            // Botones
            btn_Actualizar.Visible = false;
            btn_Bajas.Visible = false;
            // Paneles
            panel_Altas.Visible = true;
        }
        private void Profesor()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            lbl_v1.Visible = true;
            lbl_v1.Text = "Código:";
            lbl_v2.Visible = true;
            lbl_v2.Text = "Nombre:";
            // Botones
            btn_Alta_v3.Visible = true;
            // TextBox
            txt_v1.Visible = true;
            txt_v1.Text = "";
            txt_v1.MaxLength = 4;
            txt_v2.Visible = true;
            txt_v2.Text = "";
            txt_v2.MaxLength = 60;
            // Paneles
            panel_Altas.Visible = true;
            tbl_l_panel_Altas.Visible = true;
        }
        private void Materias()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            lbl_v1.Visible = true;
            lbl_v1.Text = "Código:";
            lbl_v2.Visible = true;
            lbl_v2.Text = "Nombre:";
            // Botones
            btn_Alta_v3.Visible = true;
            // TextBox
            txt_v1.Visible = true;
            txt_v1.Text = "";
            txt_v2.Visible = true;
            txt_v2.Text = "";
            // Paneles
            panel_Altas.Visible = true;
            tbl_l_panel_Altas.Visible = true;
        }
        private void Impartido()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            lbl_v1.Visible = true;
            lbl_v1.Text = "Materia:";
            lbl_v2.Visible = true;
            lbl_v2.Text = "Profesor:";
            // Botones
            btn_Actualizar.Visible = false;
            btn_Alta_v3.Visible = true;
            // ComboBox
            cb_v1.Visible = true;
            Mostrar_CB(cb_v1, "Materia");
            cb_v2.Visible = true;
            Mostrar_CB(cb_v2, "Profesor");
            // DataGridView
            dgv_Tabla.Columns[0].Visible = false;
            dgv_Tabla.Columns[2].Visible = false;
            // Paneles
            panel_Altas.Visible = true;
            tbl_l_panel_Altas.Visible = true;
        }
        private void Avisos()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            lbl_v1.Visible = true;
            lbl_v1.Text = "Código:";
            lbl_v2.Visible = true;
            lbl_v2.Text = "Nombre:";
            lbl_v3.Visible = true;
            lbl_v3.Text = "Duración:";
            // Botones
            btn_Alta_v4.Visible = true;
            // TextBox
            txt_v1.Visible = true;
            txt_v1.Text = "";
            txt_v2.Visible = true;
            txt_v2.Enabled = false;
            txt_v2.Text = "";
            txt_v3.Visible = true;
            txt_v3.Text = "Segundos";
            txt_v3.Enabled = true;
            // PictureBox
            pb_Imagen.Visible = true;
            // Paneles
            panel_Altas.Visible = true;
            tbl_l_panel_Altas.Visible = true;
        }
        private void Horarios()
        {
            // Etiquetas
            lbl_Titulo.Text = titulo;
            lbl_v1.Visible = true;
            lbl_v1.Text = "Día:";
            lbl_v2.Visible = true;
            lbl_v2.Text = "Hora:";
            lbl_v3.Visible = true;
            lbl_v3.Text = "Salón:";
            lbl_v4.Visible = true;
            lbl_v4.Text = "Materia:";
            lbl_v5.Visible = true;
            lbl_v5.Text = "Profesor:";
            lbl_5.Visible = true;
            // Botones
            btn_v6.Visible = true;
            btn_Actualizar.Visible = false;
            // CheckBox
            tbl_l_panel_Dias.Visible = true;
            // ComboBox
            //cb_v1.Visible = true;
            //Mostrar_CB(cb_v1, "Dia");
            cb_v2.Visible = true;
            Mostrar_CB(cb_v2, "Hora");
            cb_v3.Visible = true;
            cb_v3.Enabled = false;
            //Mostrar_CB(cb_v3, "Salon");
            cb_v4.Visible = true;
            Mostrar_CB(cb_v4, "Materia_Imparte");
            cb_v5.Visible = true;
            cb_v5.Enabled = false;
            //Mostrar_CB(cb_v5, "Profesor");
            // Paneles
            panel_Altas.Visible = true;
            tbl_l_panel_Altas.Visible = true;
        }
        // 5) Metodo que se encarga de mostrar todos los elementos 
        // que cada seccion requiere. Manda a llamar al metodo necesario
        //  para mostrar los elementos necesarios.
        private void Formulario()
        {
            switch (titulo)
            {
                case "Asistencias":
                    Asistencias();
                    break;
                case "Salones":
                    Salones();
                    break;
                case "Reporte de Asistencias":
                    Reporte_Asistencias();
                    break;
                case "Profesor":
                    Profesor();
                    break;
                case "Materias":
                    Materias();
                    break;
                case "Impartido":
                    Impartido();
                    break;
                case "Archivo":
                    Avisos();
                    break;
                case "Horarios":
                    Horarios();
                    break;
            }
        }
        // Limpiar o vaciar elementos:
        private void limpiar()
        {
            switch (titulo)
            {
                case "Profesor":
                    txt_v1.Text = "";
                    txt_v2.Text = "";
                    break;
                case "Materias":
                    txt_v1.Text = "";
                    txt_v2.Text = "";
                    break;
                case "Horarios":
                    chkb_Lunes.Checked = true;
                    chkb_Martes.Checked = true;
                    chkb_Miercoles.Checked = true;
                    chkb_Jueves.Checked = true;
                    chkb_Viernes.Checked = true;
                    cb_v2.SelectedIndex = -1;
                    cb_v3.SelectedIndex = -1;
                    cb_v4.SelectedIndex = -1;
                    cb_v5.SelectedIndex = -1;
                    cb_v5.Enabled = false;
                    break;
                case "Impartido":
                    cb_v1.SelectedIndex = -1;
                    cb_v2.SelectedIndex = -1;
                    break;
                case "Archivo":
                    txt_v1.Text = "";
                    txt_v2.Text = "";
                    txt_v3.Text = "Segundos";
                    //pb_Imagen.Image.Dispose();
                    pb_Imagen.Image = null;
                    break;
            }

        }
        // Eventos:
        // =======================================================================================
        // Validar entrada de datos:
        private void Letras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void Numeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        // Combobox:
        // Horarios: Metodo que permite obtener la lista de Maestros que imparten la materia seleccionada
        // Si un maestro no tiene ninguna materia asignada o una materia no tienen ningun maestro asignado
        // no se mostraran en las listas para generar Horarios.
        private void Materia_seleccionada(object sender, EventArgs e)
        {
            cb_v5.SelectedIndex = -1;
            if (cb_v4.SelectedIndex != -1)
            {
                cb_v5.Items.Clear();
                Mostrar_CB(cb_v5, "Profesor_Imparte");
                cb_v5.Enabled = true;
            }
        }
        private void Hora_seleccionada(object sender, EventArgs e)
        {
            if (titulo == "Horarios")
            {
                cb_v3.SelectedIndex = -1;
                if (cb_v2.SelectedIndex != -1)
                {
                    cb_v3.Items.Clear();
                    Mostrar_CB(cb_v3, "Salon_Hora_Dia");
                    cb_v3.Enabled = true;
                }
            }
        }
        // PictureBox:
        // Metodo que carga la imagen para obtener su direccion
        private void Cargar_Imagen(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {

                open.Filter = "(*.jpg;*.jpeg;*.bmp;*.png;)| *.jpg;*.jpeg;*.bmp;*.png; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    string imagePath = open.FileName.ToString();
                    string impath = imagePath.ToString();
                    impath = impath.Substring(impath.LastIndexOf("\\"));
                    impath = impath.Remove(0, 1);
                    txt_v2.Text = impath;
                }
            }
        }
        // Metodo que muestra la imagen seleccionada de la tabla
        private void Mostrar_Imagen(object sender, DataGridViewCellEventArgs e)
        {
            if (titulo == "Archivo")
            {
                // Se utiliza FileStream ya que permite eliminar la imagen sin presentar problemas con el sistema.
                FileStream fs = new FileStream("C:\\Fotos\\" + dgv_Tabla.CurrentRow.Cells[1].Value.ToString(), FileMode.Open, FileAccess.Read);
                pb_Imagen.Image = Image.FromStream(fs);
                fs.Close();
            }
        }
        // Botones:
        // Metodo encargado de mostrar el reporte de Asistencia
        private void btn_Generar_Reporte_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            sub_GUI(new Tablas("Reporte de Asistencias"));
        }
        // Metodos encargados de gestionar las Altas y Actualizaciones 
        private void Altas_Actualizaciones(object sender, EventArgs e)
        {
            switch (titulo)
            {
                case "Horarios":
                    Alta_Horario();
                    limpiar();
                    break;
                case "Profesor":
                    Alta_Profesor();
                    limpiar();
                    break;
                case "Impartido":
                    Alta_Impartido();
                    limpiar();
                    break;
                case "Materias":
                    Alta_Materia();
                    limpiar();
                    break;
                case "Archivo":
                    Alta_Archivo();
                    limpiar();
                    break;
            }
        }
        private void Actualizar(object sender, EventArgs e)
        {
            if (dgv_Tabla.SelectedCells.Count > 0 && dgv_Tabla.Rows.Count > 0)
            {
                actualizar = true;
                switch (titulo)
                {
                    case "Profesor":
                        txt_v1.Text = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
                        btn_Alta_v3.Text = "Actualizar";
                        break;
                    case "Materias":
                        txt_v1.Text = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
                        btn_Alta_v3.Text = "Actualizar";
                        break;
                    case "Archivo":
                        txt_v1.Text = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
                        txt_v3.Text = dgv_Tabla.CurrentRow.Cells[2].Value.ToString();
                        btn_Alta_v4.Text = "Actualizar";
                        break;
                }
            }
        }
        private void Alta_Horario()
        {
            if (chkb_Lunes.Checked != false || chkb_Martes.Checked != false || chkb_Miercoles.Checked != false || chkb_Jueves.Checked != false || chkb_Viernes.Checked != false)
            {
                if (cb_v2.SelectedItem != null && cb_v3.SelectedItem != null && cb_v4.SelectedItem != null
                 && cb_v5.SelectedItem != null)
                {
                    // Alta
                    if (actualizar == false)
                    {
                        DialogResult resultado = MessageBox.Show("¿Esta seguro que desea dar de alta un nuevo horario?", "Confirmar Accion", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            String v2 = tHora.Rows[cb_v2.SelectedIndex][0].ToString();
                            String v3 = tSalon.Rows[cb_v3.SelectedIndex][0].ToString();
                            String v4 = tMateria.Rows[cb_v4.SelectedIndex][0].ToString();
                            String v5 = tProfesor.Rows[cb_v5.SelectedIndex][0].ToString();
                            if (chkb_Lunes.Checked)
                                respuesta = ObjetoCN.Operaciones(titulo, "Insert", "1", v2, v3, v4, v5);
                            if (chkb_Martes.Checked)
                                respuesta = ObjetoCN.Operaciones(titulo, "Insert", "2", v2, v3, v4, v5);
                            if (chkb_Miercoles.Checked)
                                respuesta = ObjetoCN.Operaciones(titulo, "Insert", "3", v2, v3, v4, v5);
                            if (chkb_Jueves.Checked)
                                respuesta = ObjetoCN.Operaciones(titulo, "Insert", "4", v2, v3, v4, v5);
                            if (chkb_Viernes.Checked)
                                respuesta = ObjetoCN.Operaciones(titulo, "Insert", "5", v2, v3, v4, v5);
                            if (respuesta == "1")
                                MessageBox.Show("Alta exitosa");
                            if (respuesta == "0")
                                MessageBox.Show("ERROR: Ya existe el horario que se intento dar de alta o se empalma con uno existente:"
                                    + "\n " + cb_v2.Text + "|" + cb_v3.Text + "|" + cb_v4.Text + "|" + cb_v5.Text);
                            if (respuesta == "-1")
                                MessageBox.Show("ERROR: No es posible que el profesor de clase a la misma hora en distintos salones:"
                                    + "\n " + cb_v2.Text + "|" + cb_v3.Text + "|" + cb_v4.Text + "|" + cb_v5.Text);
                            Mostrar_DGV();
                        }
                        else
                            MessageBox.Show("Se ha cancelado la acción.");
                    }
                    // Actualizacion
                    //else{}
                }
                else
                    MessageBox.Show("Por favor, seleccione un dato en cada uno de los campos.");
                dgv_Tabla.Refresh();
            }
            else
                MessageBox.Show("Por favor, almenos un dia.");
            dgv_Tabla.Refresh();
        }
        private void Alta_Impartido()
        {
            if (cb_v1.SelectedItem != null && cb_v2.SelectedItem != null)
            {
                // Alta
                if (actualizar == false)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea dar de alta la asignacion de Materia-Profesor?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        String v1 = tMateria.Rows[cb_v1.SelectedIndex][0].ToString();
                        String v2 = tProfesor.Rows[cb_v2.SelectedIndex][0].ToString();
                        respuesta = ObjetoCN.Operaciones(titulo, "Insert", v1, v2, "", "", "");
                        if (respuesta == "1")
                            MessageBox.Show("Alta exitosa");
                        if (respuesta == "0")
                            MessageBox.Show("ERROR: Ya existe la asingnacion que se intento dar de alta:"
                                + "\n " + cb_v1.Text + "|" + cb_v2.Text);
                        Mostrar_DGV();
                    }
                    else
                        MessageBox.Show("Se ha cancelado la acción.");
                }
                // Actualizacion
                //else{}
            }
            else
                MessageBox.Show("Por favor, seleccione un dato en cada uno de los campos.");
            dgv_Tabla.Refresh();
        }
        private void Alta_Profesor()
        {
            if (txt_v1.Text != "" && txt_v2.Text != "")
            {
                // Alta
                if (actualizar == false)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea dar de alta a " + txt_v2.Text + " ?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        respuesta = ObjetoCN.Operaciones(titulo, "Insert", txt_v1.Text, txt_v2.Text, "", "", "");
                        if (respuesta == "1")
                            MessageBox.Show("Alta exitosa");
                        if (respuesta == "0")
                            MessageBox.Show("ERROR: Ya fue dado de alta anteriormente");
                        Mostrar_DGV();
                    }
                    else
                        MessageBox.Show("Se ha cancelado la acción.");
                }
                // Actualizacion
                else
                {
                    String Profesor = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea actualizar los datos del profesor " + Profesor + " ?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                        respuesta = ObjetoCN.Operaciones(titulo, "Update", v1_u, txt_v1.Text, txt_v2.Text, "", "");
                        if (respuesta == "1")
                            MessageBox.Show("Actualizacion exitosa");
                        if (respuesta == "-1")
                            MessageBox.Show("ERROR: No existe el Profesor que desea actualizar");
                        if (respuesta == "-2")
                            MessageBox.Show("ERROR: La clave del Profesor ya existe");
                        Mostrar_DGV();
                        actualizar = false;
                        limpiar();
                        btn_Alta_v3.Text = "Agregar";
                    }
                    else
                    {
                        MessageBox.Show("Se ha cancelado la acción.");
                        actualizar = false;
                        limpiar();
                        btn_Alta_v3.Text = "Agregar";
                    }

                }
            }
            else
                MessageBox.Show("Por favor, seleccione un dato en cada uno de los campos.");
            dgv_Tabla.Refresh();
        }
        private void Alta_Materia()
        {
            if (txt_v1.Text != "" && txt_v2.Text != "")
            {
                // Alta
                if (actualizar == false)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea dar de alta la materia " + txt_v2.Text + " ?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        respuesta = ObjetoCN.Operaciones(titulo, "Insert", txt_v1.Text, txt_v2.Text, "", "", "");
                        if (respuesta == "1")
                            MessageBox.Show("Alta exitosa");
                        if (respuesta == "0")
                            MessageBox.Show("ERROR: La materia fue dada de alta anteriormente");
                        Mostrar_DGV();
                    }
                    else
                        MessageBox.Show("Se ha cancelado la acción.");
                }
                // Actualizacion
                else
                {
                    String Materia = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea actualizar los datos de la materia " + Materia + " ?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                        respuesta = ObjetoCN.Operaciones(titulo, "Update", v1_u, txt_v1.Text, txt_v2.Text, "", "");
                        if (respuesta == "1")
                            MessageBox.Show("Actualizacion exitosa");
                        if (respuesta == "-1")
                            MessageBox.Show("ERROR: No existe la materia que desea actualizar");
                        if (respuesta == "-2")
                            MessageBox.Show("ERROR: La clave de la materia ya existe");
                        Mostrar_DGV();
                        actualizar = false;
                        limpiar();
                        btn_Alta_v3.Text = "Agregar";
                    }
                    else
                    {
                        MessageBox.Show("Se ha cancelado la acción.");
                        actualizar = false;
                        limpiar();
                        btn_Alta_v3.Text = "Agregar";
                    }

                }
            }
            else
                MessageBox.Show("Por favor, seleccione un dato en cada uno de los campos.");
            dgv_Tabla.Refresh();
        }
        private void Alta_Archivo()
        {
            if (pb_Imagen != null && txt_v1.Text != "" && txt_v2.Text != "" && txt_v3.Text != "")
            {
                if (actualizar == false)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea dar de alta el aviso " + txt_v2.Text + "?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        string name = txt_v2.Text;
                        string folder = "C:\\Fotos";
                        //string folder = "C:\\Program Files\\NotificationBoard\\img";
                        string path = System.IO.Path.Combine(folder, name);
                        Image a = pb_Imagen.Image;
                        try
                        {
                            a.Save(path);
                        }
                        catch
                        {
                            MessageBox.Show("x");
                        }
                        respuesta = ObjetoCN.Operaciones(titulo, "Insert", txt_v1.Text, txt_v2.Text, txt_v3.Text, "", "");
                        if (respuesta == "1")
                            MessageBox.Show("Alta exitosa");
                        if (respuesta == "0")
                            MessageBox.Show("ERROR: La imagen fue dada de alta anteriormente");
                        limpiar();
                        Mostrar_DGV();
                    }
                    else
                        MessageBox.Show("Se ha cancelado la acción.");
                }
                if (actualizar == true)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea actualizar los datos de la imagen " + txt_v2.Text + "?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                        respuesta = ObjetoCN.Operaciones(titulo, "Update", v1_u, txt_v1.Text, txt_v2.Text, txt_v3.Text, "");
                        MessageBox.Show(respuesta);
                        Mostrar_DGV();
                        actualizar = false;
                        limpiar();
                        btn_Alta_v4.Text = "Guardar";
                    }
                    else
                    {
                        MessageBox.Show("Se ha cancelado la acción.");
                        Mostrar_DGV();
                        actualizar = false;
                        limpiar();
                        btn_Alta_v4.Text = "Guardar";
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un dato en cada uno de los campos.");
                btn_Alta_v4.Text = "Guardar";
            }
        }
        private void Alta_Asistencia(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String v1, v2, v3, v4, v5;
                v1 = dgv_Tabla.CurrentRow.Cells[6].Value.ToString();
                v2 = dgv_Tabla.CurrentRow.Cells[7].Value.ToString();
                v3 = dgv_Tabla.CurrentRow.Cells[8].Value.ToString();
                v4 = dgv_Tabla.CurrentRow.Cells[9].Value.ToString();
                v5 = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
                respuesta = ObjetoCN.Operaciones(titulo, "Insert", v1, v2, v3, v4, v5);
                if (respuesta == "1")
                    MessageBox.Show("Alta exitosa");
                if (respuesta == "0")
                    MessageBox.Show("ERROR: La asistencia fue dada de alta anteriormente");
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                dgv_Tabla.CurrentRow.Cells[0] = cell;
            }
        }
        // Metodos encargados de gestionar las Bajas 
        private void Bajas(object sender, EventArgs e)
        {
            switch (titulo)
            {
                case "Horarios":
                    Baja_Horario();
                    limpiar();
                    break;
                case "Profesor":
                    Baja_Profesor();
                    limpiar();
                    break;
                case "Impartido":
                    Baja_Impartido();
                    limpiar();
                    break;
                case "Materias":
                    Baja_Materia();
                    limpiar();
                    break;
                case "Archivo":
                    Baja_Archivo();
                    limpiar();
                    break;
            }
        }
        private void Baja_Horario()
        {
            String Horario = dgv_Tabla.CurrentRow.Cells[2].Value.ToString() + "|" + dgv_Tabla.CurrentRow.Cells[3].Value.ToString()
                + "|" + dgv_Tabla.CurrentRow.Cells[4].Value.ToString() + "|" + dgv_Tabla.CurrentRow.Cells[5].Value.ToString()
                + "|" + dgv_Tabla.CurrentRow.Cells[6].Value.ToString(); ;
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminar este horario?" +
                "\n" + Horario, "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                if (dgv_Tabla.Rows.Count > 0)
                {
                    v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                    v2_u = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
                    v3_u = dgv_Tabla.CurrentRow.Cells[6].Value.ToString();
                    respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, v2_u, v3_u, "", "");
                    MessageBox.Show("Baja exitosa");
                    Mostrar_DGV();
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.");
            }
        }
        private void Baja_Impartido()
        {
            String Impartido = dgv_Tabla.CurrentRow.Cells[1].Value.ToString() + "|" + dgv_Tabla.CurrentRow.Cells[3].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminar este registro?" +
                "\n" + Impartido, "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                if (dgv_Tabla.Rows.Count > 0)
                {
                    v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                    v2_u = dgv_Tabla.CurrentRow.Cells[2].Value.ToString();
                    respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, v2_u, "", "", "");
                    MessageBox.Show("Baja exitosa");
                    Mostrar_DGV();
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.");
            }
        }
        private void Baja_Profesor()
        {
            String Profesor = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminar al profesor " + Profesor + "?" +
                "\n Si elimina al profesor se eliminaran sus horarios y asignaciones de materias.", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                if (dgv_Tabla.Rows.Count > 0)
                {
                    v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                    respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                    MessageBox.Show("Baja exitosa");
                    Mostrar_DGV();
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.");
            }
        }
        private void Baja_Materia()
        {
            String Materia = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminar la materia " + Materia + "?" +
                "\n Si elimina la materia se eliminaran sus horarios y asignaciones de profesor.", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                if (dgv_Tabla.Rows.Count > 0)
                {
                    v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                    respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                    MessageBox.Show("Baja exitosa");
                    Mostrar_DGV();
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.");
            }
        }
        private void Baja_Archivo()
        {
            //pb_Imagen.Image = null;
            String Aviso = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar el aviso " + Aviso + "?", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                if (dgv_Tabla.Rows.Count > 0)
                {
                    if (pb_Imagen.Image != null)
                        pb_Imagen.Image.Dispose();
                    v1_u = dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
                    respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");

                    string folder = "C:\\Fotos";
                    string name = dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
                    string path = System.IO.Path.Combine(folder, name);
                    File.Delete(path);
                    Mostrar_DGV();
                    MessageBox.Show("Se elimino correctamente");
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.");
            }
        }
    }
}
