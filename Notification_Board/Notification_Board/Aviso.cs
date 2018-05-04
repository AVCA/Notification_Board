using CapaOperaciones;
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
    public partial class Aviso : Form
    {
        public string titulo;
        public Aviso(String t)
        {
            titulo = t;
            InitializeComponent();
        }

        CN_Operaciones ObjetoCN = new CN_Operaciones();

        private void Aviso_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (pictureBox1!=null && txtCod.Text!="" && txtNom.Text != "" && txtDur.Text != "")
            {
                string name = txtNom.Text + ".jpg";
                //Mi direccion de prueba
                //string folder = "C:\\Users\\otame\\Desktop\\Materias";
                string folder = "C:\\Program Files\\NotificationBoard\\img";
                string path = System.IO.Path.Combine(folder, name);
                Image a = pictureBox1.Image;
                a.Save(path);
                ObjetoCN.Operaciones(titulo, "Insert", txtCod.Text, txtNom.Text, txtDur.Text, "", "");
                Mostrar();
                
            }
            else
            {
                MessageBox.Show("Elige una imagen");
            }
        }

        private void Mostrar()
        {
            CN_Operaciones ObjetoCN = new CN_Operaciones();
            dataGridView1.DataSource = ObjetoCN.Mostrar(titulo);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                }
            }
        }
    }
}
