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

        public string titulo;
        private string v1_u = null;
        private bool editar = false;

        public Tablas(String t)
        {
            titulo = t;
            InitializeComponent();
           
        }

        private void horarios_Load(object sender, EventArgs e)
        {
            Mostrar();
            Formulario();
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
                    lbl_titulo.Text = titulo;
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
                    lbl_titulo.Text = titulo;
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
                case "Horarios":
                    lbl_titulo.Text = titulo;
                    btn_v5.Visible = true;

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

                    cb_v5.Visible = true;
                    // Cargar valores 

                    break;
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
            }
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.Rows.Count > 1)
            {
                switch (titulo)
                {
                    case "Profesor":
                        v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ObjetoCN.Operaciones(titulo, "Delete", v1_u,"","","","");
                        Mostrar();
                        break;
                    case "Materias":
                        v1_u = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ObjetoCN.Operaciones(titulo, "Delete", v1_u, "", "", "", "");
                        Mostrar();
                        break;
                }
            }
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagenes|*.jpg, .png";
            openFileDialog1.Title = "Selecciona la imagen que desea cargar";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                this.Cursor = new Cursor(openFileDialog1.OpenFile());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
