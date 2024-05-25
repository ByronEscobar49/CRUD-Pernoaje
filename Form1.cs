using DB1.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB1
{
    public partial class Form1 : Form
    {
        private PersonajesDB personaje;
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajesDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            { MessageBox.Show("Si se pudo 👌❤️😎😎😍🎶✔😘"); }
            else
            {
                MessageBox.Show("Nel Pastel 😢😒😓😔😢😢😢");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridViewPersonaje.DataSource = personaje.LeerPersonajes();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string historia = richTextBoxHistoria.Text;
            DateTime fechaCreacion = dateTimePickerFechaCreacion.Value;

            string raza = textBoxRaza.Text;
            int nivelPoder = (int)numericUpDownNivelPoder.Value;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder, historia, fechaCreacion);



            if (respuesta > 0)
            {
                LimpiarTextBox();
                MessageBox.Show("Se creo correctamente");
                dataGridViewPersonaje.DataSource = personaje.LeerPersonajes();

            }
            else
            {
                MessageBox.Show("Hubo un error al crear personaje");
            }
        }
        private void LimpiarTextBox()
        {
            textBoxNombre.Text = "";
            textBoxRaza.Text = "";
            numericUpDownNivelPoder.Value = 0;
            dateTimePickerFechaCreacion.Value = DateTime.Now;
            richTextBoxHistoria.Text = "";
        }
    }
}
