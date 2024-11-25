using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilliamAlvarezFase3Grupo108
{
    public partial class frmIngresodatos : Form
    {
        public frmIngresodatos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtITipoidentificacion_TextChanged(object sender, EventArgs e)
        {
            // Esta línea verifica si el texto en el TextBox no es un número
            if (!long.TryParse(txtITipoidentificacion.Text, out _))
            {
                // Si no es un número, muestra un mensaje en una ventana emergente
                MessageBox.Show("Solo puede ingresar números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Luego limpia el contenido del TextBox para que el usuario vea que no se aceptaron otros caracteres.
                txtITipoidentificacion.Text = "";




            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Esta línea verifica si el texto en el TextBox contiene caracteres que no sean letras o espacios
            if (txtNombre.Text.Any(c => !char.IsLetter(c) && c != ' '))
            {
                // Si el texto contiene caracteres no permitidos (que no sean letras ni espacio), muestra un mensaje
                MessageBox.Show("Solo puede ingresar letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Luego limpia el contenido del TextBox para que el usuario vea que no se aceptaron otros caracteres
                txtNombre.Clear();  // Usamos Clear() para limpiar el TextBox
            }
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el texto ingresado es un número y está en el rango de 10 a 99
            if (!int.TryParse(txtedad.Text, out int edad) || edad < 1 || edad >= 99)
            {
                // Si no es un número o no está en el rango, muestra un mensaje
                MessageBox.Show("Solo puede ingresar una edad entre 1 y 99.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Luego limpia el contenido del TextBox
                txtedad.Text = "";
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
