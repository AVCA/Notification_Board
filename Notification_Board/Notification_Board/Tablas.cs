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

namespace Notification_Board
{
    public partial class Tablas : Form
    {
        CN_Operaciones ObjetoCN = new CN_Operaciones();
        DataTable tDia = new DataTable();
        DataTable tSalon = new DataTable();
        DataTable tHora = new DataTable();
        DataTable tProfesor = new DataTable();
        DataTable tMateria = new DataTable();
        public string diaAct, horaAct, salonAct, profesorAct, materiaAct;
        public string titulo,respuesta;
        private string v1_u = null,v2_u,v3_u;
        private bool editar = false;

        public Tablas(String t)
        {
            titulo = t;
            InitializeComponent();
        }
            
        private void horarios_Load(object sender, EventArgs e)
        {
            lbl_t.Text = titulo;
            Mostrar();
            if (titulo == "Impartido")
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }
            Formulario();
            CargarDia();
            CargarHora();
            CargarSalon();
            CargarProfesor();
            CargarMaterias();
        }

        private void Mostrar()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            dataGridView1.DataSource = ObjetoCN.Mostrar(titulo);
           
        }

        private void mostrar_cb()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            cb_v1.DataSource = ObjetoCN.Mostrar(titulo);
           
        }

        private void Formulario()
        {
            switch (titulo)
            {
                case "Profesor":
                    lbl_t.Text = titulo;
                    btn_agregar_p.Visible = true;
                    lbl_v1.Visible = true;
                    lbl_v1.Text = "Código:";
                    txt_v1.Visible = true;
                    txt_v1.Text = "";
                    lbl_v2.Visible = true;
                    lbl_v2.Text = "Nombre:";
                    txt_v2.Visible = true;
                    txt_v2.Text = "";
                    break;
                case "Materias":
                    lbl_t.Text = titulo;
                    btn_agregar_p.Visible = true;
                    lbl_v1.Visible = true;
                    lbl_v1.Text = "Código:";
                    txt_v1.Visible = true;
                    txt_v1.Text = "";
                    lbl_v2.Visible = true;
                    lbl_v2.Text = "Nombre:";
                    txt_v2.Visible = true;
                    txt_v2.Text = "";
                    break;
                case "Impartido":
                    lbl_t.Text = titulo;
                    btn_agregar_p.Visible = true;

                    lbl_v1.Visible = true;
                    lbl_v1.Text = "Materia:";

                    cb_v1.Visible = true;

                    lbl_v2.Visible = true;
                    lbl_v2.Text = "Profesor:";

                    cb_v2.Visible = true;

                    break;
                case "Archivo":
                    lbl_t.Text = titulo;
                    btn_agregar_archivo.Visible = true;

                    lbl_v1.Visible = true;
                    lbl_v1.Text = "Código:";

                    txt_v1.Visible = true;
                    txt_v1.Text = "";

                    lbl_v2.Visible = true;
                    lbl_v2.Text = "Nombre:";

                    txt_v2.Visible = true;
                    txt_v2.Enabled = false;
                    txt_v2.Text = "";

                    lbl_v3.Visible = true;
                    lbl_v3.Text = "Duración:";

                    txt_v3.Visible = true;
                    txt_v3.Text = "Horas";
                    txt_v3.Enabled = true;

                    pictureBox1.Visible = true;

                    break;
                case "Horarios":
                    lbl_t.Text = titulo;
                    btn_v5.Visible = true;
                    btn_v5.Dock = DockStyle.None;

                    lbl_v1.Visible = true;
                    lbl_v1.Text = "Día:";

                    cb_v1.Visible = true;
                    // Cargar valores 

                    lbl_v2.Visible = true;
                    lbl_v2.Text = "Hora:";

                    cb_v2.Visible = true;
                    // Cargar valores 

                    lbl_v3.Visible = true;
                    lbl_v3.Text = "Salón:";

                    cb_v3.Visible = true;
                    // Cargar valores 

                    lbl_v4.Visible = true;
                    lbl_v4.Text = "Materia:";

                    cb_v4.Visible = true;
                    // Cargar valores 

                    lbl_v5.Visible = true;
                    lbl_v5.Text = "Profesor:";

                    lbl_5.Visible = true;

                    cb_v5.Visible = true;
                    // Cargar valores 

                    break;
            }
        }

        private void CargarDia()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            tDia = ObjetoCN.Llenar("Dia");
            for(int i=0; i < tDia.Rows.Count; i++)
            {
                cb_v1.Items.Add(tDia.Rows[i][1]);
            }
        }

        private void CargarHora()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            tHora = ObjetoCN.Llenar("Hora");
            for (int i = 0; i < tHora.Rows.Count; i++)
            {
                cb_v2.Items.Add(tHora.Rows[i][1]);
            }
        }

        private void CargarSalon()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            tSalon = ObjetoCN.Llenar("Salon");
            for (int i = 0; i < tSalon.Rows.Count; i++)
            {
                cb_v3.Items.Add(tSalon.Rows[i][0]);
            }
        }

        private void CargarProfesor()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            tProfesor = ObjetoCN.Llenar("Profesor");
            if (titulo == "Horarios")
            {
                for (int i = 0; i < tProfesor.Rows.Count; i++)
                {
                    cb_v5.Items.Add(tProfesor.Rows[i][1]);
                }
            }
            if (titulo == "Impartido")
            {
                cb_v2.Items.Clear();
                cb_v4.Items.Clear();
                for (int i = 0; i < tProfesor.Rows.Count; i++)
                {
                    cb_v2.Items.Add(tProfesor.Rows[i][1]);
                    cb_v4.Items.Add(tProfesor.Rows[i][0]);
                }
            }
            
        }

        private void CargarMaterias()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            tMateria = ObjetoCN.Llenar("Materias");
            if (titulo == "Horarios")
            {
                for (int i = 0; i < tMateria.Rows.Count; i++)
                {
                    cb_v4.Items.Add(tMateria.Rows[i][1]);
                }
            }
            if (titulo == "Impartido")
            {
                cb_v1.Items.Clear();
                cb_v3.Items.Clear();
                for (int i = 0; i < tMateria.Rows.Count; i++)
                {
                   
                    cb_v1.Items.Add(tMateria.Rows[i][1]);
                    cb_v3.Items.Add(tMateria.Rows[i][0]);
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_v1.Text != "" && txt_v2.Text != "" && txt_v3.Text != "" && txt_v4.Text != "" && txt_v5.Text != "") { 
            if (editar == false)
            {
                ObjetoCN.Operaciones(titulo, "Insert", txt_v1.Text, txt_v2.Text, txt_v3.Text, txt_v4.Text, txt_v5.Text);
                limpiar();
                Mostrar();
            }
            if (editar == true)
            {
                v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ObjetoCN.Operaciones(titulo, "Update", v1_u, txt_v1.Text, txt_v2.Text, "", "");
                Mostrar();
                editar = false;
                limpiar();
                btn_agregar_p.Text = "Agregar";
            } }
            dataGridView1.Refresh();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count>0 && dataGridView1.Rows.Count>0)
            {
                editar = true;
                switch (titulo)
                {
                    case "Profesor":
                        txt_v1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        btn_agregar_p.Text = "Actualizar";
                        break;
                    case "Materias":
                        txt_v1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        btn_agregar_p.Text = "Actualizar";
                        break;
                }
            }
        }

        private void limpiar()
        {
            switch(titulo)
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
                    CargarDia();
                    CargarHora();
                    CargarSalon();
                    CargarMaterias();
                    CargarProfesor();
                    break;
                case "Archivo":
                    txt_v1.Text = "";
                    txt_v2.Text = "";
                    txt_v3.Text = "Horas";
                    break;
            }
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.Rows.Count > 1)
                {
                    switch (titulo)
                    {
                        case "Profesor":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                            Mostrar();
                            break;
                        case "Materias":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                            Mostrar();
                            break;
                        case "Horarios":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            v2_u = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            v3_u = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                            ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                            Mostrar();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.");
            }
        }

        private void btn_v4_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null && txt_v1.Text != "" && txt_v2.Text != "" && txt_v3.Text != "")
            {
                if (editar == false)
                {
                    DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas agregar?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        string name = txt_v2.Text;
                        //Mi direccion de prueba
                        string folder = "C:\\Fotos";
                        //string folder = "C:\\Program Files\\NotificationBoard\\img";
                        string path = System.IO.Path.Combine(folder, name);
                        Image a = pictureBox1.Image;
                        try
                        {
                            a.Save(path);
                        }
                        catch
                        {
                            MessageBox.Show("x");
                        }
                        respuesta = ObjetoCN.Operaciones(titulo, "Insert", txt_v1.Text, txt_v2.Text, txt_v3.Text, "", "");
                        if (respuesta == "ERROR")
                        {
                            MessageBox.Show(respuesta);
                        }
                        else
                        {
                            MessageBox.Show(respuesta);
                        }
                        limpiar();
                        Mostrar();
                    }
                    else
                        MessageBox.Show("Se ha cancelado la acción.");
                }
                if (editar == true)
                {
                    DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas editar?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        respuesta = ObjetoCN.Operaciones(titulo, "Update", v1_u, txt_v1.Text, txt_v2.Text, txt_v3.Text, "");
                        if (respuesta == "ERROR")
                        {
                            MessageBox.Show(respuesta);
                        }
                        else
                        {
                            MessageBox.Show(respuesta);
                        }
                        Mostrar();
                        editar = false;
                        limpiar();
                        btn_agregar_archivo.Text = "Guardar";
                    }
                    else { 
                    MessageBox.Show("Se ha cancelado la acción.");
                        Mostrar();
                        editar = false;
                        limpiar();
                        btn_agregar_archivo.Text = "Guardar";
                    }
                }
            }
            else
            {
                MessageBox.Show("Elige una imagen");
            }
        }

        private void cb_v1_SelectedIndexChanged(object sender, EventArgs e)
        {
            diaAct = cb_v1.SelectedIndex.ToString();
        }

        private void cb_v2_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaAct = cb_v2.SelectedIndex.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void lbl_v5_Click(object sender, EventArgs e)
        {

        }

        private void cb_v3_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonAct = cb_v3.SelectedIndex.ToString();
        }

        private void cb_v4_SelectedIndexChanged(object sender, EventArgs e)
        {
            materiaAct = cb_v4.SelectedIndex.ToString();
        }

        private void cb_v5_SelectedIndexChanged(object sender, EventArgs e)
        {
            profesorAct = cb_v5.SelectedIndex.ToString();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    switch (titulo)
                    {
                        case "Profesor":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                            Mostrar();
                            break;
                        case "Materias":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            respuesta =  ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                            Mostrar();
                            break;
                        case "Horarios":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            v2_u = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            v3_u = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                            respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, v2_u, v3_u, "", "");
                            Mostrar();
                            break;
                        case "Impartido":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            v2_u = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                            respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, v2_u, "", "", "");
                            Mostrar();
                            break;
                        case "Archivo":
                            v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            respuesta = ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                            Mostrar();
                            break;
                    }
                    if (respuesta == "ERROR")
                    {
                        MessageBox.Show("ERROR: Eliminacion fallida");
                    }
                    else
                    {
                        MessageBox.Show("Se elimino correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.Rows.Count > 0)
            {
                editar = true;
                switch (titulo)
                {
                    case "Profesor":
                        txt_v1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        btn_agregar_p.Text = "Actualizar";
                        break;
                    case "Materias":
                        txt_v1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        btn_agregar_p.Text = "Actualizar";
                        break;
                    case "Archivo":
                        txt_v1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_v2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        txt_v3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        btn_agregar_archivo.Text = "Actualizar";
                        break;
                }
            }
        }

        private void btn_v5_Click_1(object sender, EventArgs e)
        {
            if (cb_v1.SelectedItem != null && cb_v2.SelectedItem != null && cb_v3.SelectedItem != null && cb_v4.SelectedItem != null
                && cb_v5.SelectedItem != null)
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas agregar?", "Confirmar Accion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    String v1, v2, v3, v4, v5;
                    v1 = Convert.ToString(tDia.Rows[Convert.ToInt32(diaAct)][0]);
                    v2 = Convert.ToString(tHora.Rows[Convert.ToInt32(horaAct)][0]);
                    v3 = Convert.ToString(tSalon.Rows[Convert.ToInt32(salonAct)][0]);
                    v4 = Convert.ToString(tMateria.Rows[Convert.ToInt32(materiaAct)][0]);
                    v5 = Convert.ToString(tProfesor.Rows[Convert.ToInt32(profesorAct)][0]);

                    ObjetoCN.Operaciones(titulo, "Insert", v1, v2, v3, v4, v5);
                    limpiar();
                    Mostrar();
                }
                else
                    MessageBox.Show("Se ha cancelado la acción.");
            }   
            else
                MessageBox.Show("Por favor, seleccione un dato en cada uno de los campos.");
            dataGridView1.Refresh();
        }

        private void btn_agregar_p_Click(object sender, EventArgs e)
        {
            if (txt_v1.Text != "" && txt_v2.Text != "" && txt_v3.Text != "" && txt_v4.Text != "" && txt_v5.Text != "")
            {
                if (editar == false)
                {
                    DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas agregar?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        if (titulo == "Impartido")
                        {
                            if (cb_v1.SelectedIndex != -1 && cb_v2.SelectedIndex != -1)
                            {
                                cb_v3.SelectedIndex = cb_v1.SelectedIndex;
                                cb_v4.SelectedIndex = cb_v2.SelectedIndex;
                                respuesta = ObjetoCN.Operaciones(titulo, "Insert", cb_v3.Text, cb_v4.Text, txt_v3.Text, txt_v4.Text, txt_v5.Text);
                            }
                            else
                            {
                                MessageBox.Show("Existen campos vacios.");
                                respuesta = "ERROR";
                            }
                           
                        }
                        else
                        {
                            respuesta = ObjetoCN.Operaciones(titulo, "Insert", txt_v1.Text, txt_v2.Text, txt_v3.Text, txt_v4.Text, txt_v5.Text);
                        }
                        if (respuesta=="ERROR")
                        {
                            MessageBox.Show("ERROR: Inserccion fallida");
                        }
                        else
                        {
                            MessageBox.Show("Se inserto correctamente");
                        }
                        limpiar();
                        Mostrar();
                    }
                    else
                        MessageBox.Show("Se ha cancelado la acción.");
                }
                if (editar == true)
                {
                    DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas actualizar?", "Confirmar Accion", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ObjetoCN.Operaciones(titulo, "Update", v1_u, txt_v1.Text, txt_v2.Text, "", "");
                        Mostrar();
                        editar = false;
                        limpiar();
                        btn_agregar_p.Text = "Agregar";
                    }
                    else
                        MessageBox.Show("Se ha cancelado la acción.");
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios.");
            }
            dataGridView1.Refresh();
        }
    }
}
