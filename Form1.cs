using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Datos_de_Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_edad.Clear();
            txt_matricula.Clear();
            txt_carrera.Clear();
            txt_datos_ingresados.Clear();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string matricula = txt_matricula.Text;
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string edad = txt_edad.Text;
            string carrera = txt_carrera.Text;

            // Concatenar los datos en una cadena
            string datosIngresados = $"Matrícula: {matricula}, Nombre: {nombre}, Apellido: {apellido}, Edad: {edad}, Carrera: {carrera}";

            // Mostrar los datos en el cuadro de texto
            txt_datos_ingresados.Text = datosIngresados;
        }
    }
}