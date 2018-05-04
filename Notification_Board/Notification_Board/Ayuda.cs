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
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void btnProy_Click(object sender, EventArgs e)
        {
            lblResp.Text = "Sección de Proyección \n Dentro de esta opción podras iniciar la proyección hacia" +
                "la pantalla vinculada al sistema. \n Solo basta con darle click en Iniciar Proyección para " +
                "que inicie inmediatamente. \n Dentro de la proyección se encontrara una tabla con los datos" +
                "de los horarios guardados previamente mediante la sección de Horarios. \n También está disponible" +
                "un espacio para mostrar todos los avisos previamente guardados por medio de la sección de Avisos" +
                "por el tiempo dado en esa misma sección.";
        }

        private void btnHor_Click(object sender, EventArgs e)
        {
            lblResp.Text = "Sección de Horarios \n Dentro de esta opción podras añadir los horarios en los que se " +
                "encuentran los maestros. \n Para poder insertar un nuevo horario de algun maestro primero deberás " +
                "haber ingresado profesores y materias dentro de sus respectivas secciones. " +
                "De este modo podras verlos desplegados dentro de una lista en la sección de horarios. " +
                "\n Si ya los tienes ingresados, ahora puedes seleccionar el dia, la hora, salón y materia que estará " +
                "dando un profesor durante el semestre. Una vez que estes seguro de los datos que seleccionaste, " +
                "solo queda hacer click en el boton de Agregar. \n Puedes editar un horario dentro de la tabla, " +
                "al seleccionarlo y darle click al botón Editar, esto te permitirá cambiar los valores de ese horario, " +
                "después de estar satisfecho con los cambios solo se oprime el botón Actualizar." +
                "\n Puedes eliminar un horario registrado con tan solo seleccionarlo dentro de la tabla y hacer click " +
                "posteriormente en el botón Eliminar.";
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            lblResp.Text = "Sección de Profesores \n Dentro de esta opción podras añadir a los profesores que " +
                "darán clase dentro del edificio. \n Al tratar de agregar a un profesor, necesitarás introducir su código de identificación y su nombre, " +
                "posteriormente solo se oprime el botón Agregar. \n Es posible editar a algun profesor ingresado " +
                "previamente con tan solo seleccionar dentro de la tabla y hacer click en el botón Editar." +
                "\n Una vez hecho esto, los datos apareceran del lado derecho y podrás cambiarlos; para guardar los " +
                "cambios basta con dar click en Actualizar. \n También es posible eliminar profesores con tan solo " +
                "seleccionar al profesor que desees eliminar dentro de la tabla y dar un click en el botón Eliminar.";
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            lblResp.Text = "Sección de Materias \n Dentro de esta opción podras añadir las materias que serán impartidas " +
                "durante el semestre. \n Es necesario que llenes los campos vacios en la barra de la derecha " +
                "para poder ingresar una materia nueva, estos campos son el de codigo y nombre de la materia. " +
                "\n Una vez hecho esto, se puede oprimir el botón Agregar para que se guarde. \n Si quieres Editar " +
                "alguna materia puedes seleccionar dicha materia desde la tabla y hacer click en el botón Editar," +
                " esto desplegará los datos de la materia seleccionada en la barra derecha y te permitirá cambiarlos. " +
                "\n Una vez cambiados puedes hacer click en Actualizar para guardar los cambios. " +
                "\n El botón Eliminar solo funciona si previamente seleccionas la materia que desees eliminar de la tabla.";
        }

        private void btnAvi_Click(object sender, EventArgs e)
        {
            lblResp.Text = "Sección de Avisos \n Dentro de esta opción podras añadir los avisos/anuncios que desees mostrar " +
                "durante la proyección. \n Para poder registrar un aviso nuevo, debes llenar todos los campos " +
                "primero o sino el aviso no se guardará correctamente. \n Los campos a llenar son Codigo, Nombre " +
                "y Duración del aviso en horas. \n Posteriormente debes llenar el último campo que es la imagen del " +
                "aviso, esto se realiza haciendo click sobre el recuadro gris que se encuentra a la derecha de los " +
                "campos. \n El hacer click abrirá una ventana que te permitirá seleccionar la imagen del aviso que desees " +
                "guardar. \n Una vez hecho esto podras dar click en el botón Guardar para ingresar el aviso.";
        }
    }
}
