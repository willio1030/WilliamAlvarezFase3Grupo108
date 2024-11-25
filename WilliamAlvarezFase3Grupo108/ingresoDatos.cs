using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilliamAlvarezFase3Grupo108
{
    public partial class frmIngresodatos : Form
    {
        private string tIdentificacion;
        private string nIdentificacion;
        private string nombre;
        private string edad;
        private string estrato;
        private string tAtencion;
        private string vcopago;
        private string fechaAcceso;
        private string tEstructura;
        private string rDatos;



        public frmIngresodatos()
        {
            InitializeComponent();
            // declaracion del metodo cargar ElementosIniciales

            cargarElementosIniciales();
            
        }
        // crear metodo que no retorna nada de cargarElemenotsIniciales
        public void cargarElementosIniciales() 
        {

            /* esto se hace para colocar en los 
             campos asignarle campo vacio para que
            el usuario los llene */

            // Atributos de clase 

            this.cmbTipoidentificacion.Text = "";
            this.txtINidentificacion.Text = "";
            this.txtNombre.Text = "";
            this.txtedad.Text = "";
            this.cmbEstrato.Text = "";
            this.rtbnmedicinaGeneral.Checked = false;
            this.rtbnExameneslaboratorio.Checked = false;
            this.txtValorcopago.Text = "";
            this.dtskAcceso.Value = DateTime.Now;
            this.cmbTipoestructura.Text = "";
            this.txtReportedatos.Text = "";

            // borrar o colocar los combobox vacios

            this.cmbTipoidentificacion.Items.Clear();
            this.cmbEstrato.Items.Clear();
            this.cmbTipoestructura.Items.Clear();

            // empezar a cargar los valores de los comboBox

            this.cmbTipoidentificacion.Items.Add("CC");
            this.cmbTipoidentificacion.Items.Add("CE");
            this.cmbTipoidentificacion.Items.Add("NUIP");
            this.cmbTipoidentificacion.Items.Add("PAS");

            this.cmbEstrato.Items.Add("1");
            this.cmbEstrato.Items.Add("2");
            this.cmbEstrato.Items.Add("3");
            this.cmbEstrato.Items.Add("4");
            this.cmbEstrato.Items.Add("5");
            this.cmbEstrato.Items.Add("6");

            this.cmbTipoestructura.Items.Add("Pila");
            this.cmbTipoestructura.Items.Add("Cola");
            this.cmbTipoestructura.Items.Add("Lista");

            // enfocar en el primer campo 

            this.txtINidentificacion.Focus();

        }

        /* validar que los campos con * son requeridos
         * para ello debo declarar las variables de tipo 
         * privado */


        public bool validarFormulario()
        {
            string mensajeValidacion = ""; // Variable para acumular los mensajes de error

            // Recuperar y validar el campo "Tipo de Identificación"
            this.tIdentificacion = this.cmbTipoidentificacion.Text.Trim(); // Obtiene el valor del combo box
            if (string.IsNullOrEmpty(this.tIdentificacion)) // Verifica si está vacío
            {
                mensajeValidacion += "- Tipo de identificación\n"; // Agrega un mensaje de error
            }

            // Validar el campo "Número de Identificación"
            if (string.IsNullOrEmpty(this.txtINidentificacion.Text.Trim())) // Valida el texto del TextBox
            {
                mensajeValidacion += "- Número de identificación\n"; // Agrega mensaje de error
            }

            // Validar el campo "Nombre Completo"
            if (string.IsNullOrEmpty(this.txtNombre.Text.Trim())) // Valida el texto del TextBox
            {
                mensajeValidacion += "- Nombre Completo\n"; // Agrega mensaje de error
            }

            // Validar el campo "Edad"
            if (string.IsNullOrEmpty(this.txtedad.Text.Trim())) // Valida el texto del TextBox
            {
                mensajeValidacion += "- Edad\n"; // Agrega mensaje de error
            }

            // Recuperar y validar el campo "Estrato"
            this.estrato = this.cmbEstrato.Text.Trim(); // Obtiene el valor del combo box
            if (string.IsNullOrEmpty(this.estrato)) // Verifica si está vacío
            {
                mensajeValidacion += "- Estrato\n"; // Agrega mensaje de error
            }

            // Recuperar y validar el campo "Tipo de estructura "
            this.tEstructura = this.cmbTipoestructura.Text.Trim(); // Obtiene el valor del combo box

            if (string.IsNullOrEmpty(this.tEstructura)) // Verifica si está vacío
            {
                mensajeValidacion += "- Tipo de estructura\n"; // Agrega mensaje de error
            }

            // Validar los campos de tipo de atención (RadioButton)
            if (!this.rtbnmedicinaGeneral.Checked && !this.rtbnExameneslaboratorio.Checked) // Ningún radio button seleccionado
            {
                mensajeValidacion += "- Tipo de atención\n"; // Agrega mensaje de error
            }
            else
            {
                // Asignar el tipo de atención seleccionado
                if (this.rtbnmedicinaGeneral.Checked)
                {
                    this.tAtencion = "Medicina General";
                }
                else if (this.rtbnExameneslaboratorio.Checked)
                {
                    this.tAtencion = "Exámenes de laboratorio";
                }
            }

            // Mostrar mensaje de validación si hay errores
            if (!string.IsNullOrEmpty(mensajeValidacion)) // Si hay mensajes acumulados
            {
                mensajeValidacion = "DEBE DILIGENCIAR TODOS LOS CAMPOS:\n*******\n\n" + mensajeValidacion; // Agrega encabezado
                MessageBox.Show(mensajeValidacion, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Muestra el mensaje
                return false; // Retorna falso indicando que la validación falló
            }
            else
            {
                // Asignar fecha de acceso si todo está validado
                this.fechaAcceso = this.dtskAcceso.Value.ToString(); // Obtiene la fecha seleccionada
                return true; // Retorna true indicando que la validación pasó
            }
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
            if (!long.TryParse(txtINidentificacion.Text, out _))
            {
                // Si no es un número, muestra un mensaje en una ventana emergente
                MessageBox.Show("Solo puede ingresar números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Luego limpia el contenido del TextBox para que el usuario vea que no se aceptaron otros caracteres.
                txtINidentificacion.Text = "";




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

        private void btnSalir_Click(object sender, EventArgs e)
            
            /*pregunta si desea salir de la aplicacion si es si */
        {
            if (MessageBox.Show("Desea salir de la aplicacion?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            { 

                // salir de la aplicacion encaso de que sea si
                Application.Exit();


            
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                
            
            
            }




               
            

        }
    }
}
