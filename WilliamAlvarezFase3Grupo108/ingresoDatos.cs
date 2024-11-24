﻿using System;
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
                    this.tAtencion = "Examenes de laboratorio";
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
                this.vcopago = calcularValorPagar().ToString(); // Cálculo corregido del copago
                this.fechaAcceso = this.dtskAcceso.Value.ToString(); // Obtiene la fecha seleccionada
                this.txtValorcopago.Text = this.vcopago;
                return true; // Retorna true indicando que la validación pasó 

                

            }
        }


        // Creamos un metodo para calcular el copago

        public int calcularValorPagar()
        {
            int intValorPagar = 0;
             

            if (this.tAtencion =="Medicina General")
            {
                switch (this.estrato)
                {
                    case "1":
                        intValorPagar = 0;
                        break;
                    case "2":
                        intValorPagar = 0;
                        break;
                    case "3":
                        intValorPagar = 10000;
                        break;
                    case "4":
                        intValorPagar = 15000;
                        break;
                    case "5":
                        intValorPagar = 20000;
                        break;
                    case "6":
                        intValorPagar = 30000;
                        break;


                }


                return intValorPagar;
            }

            if (this.tAtencion=="Examenes de laboratorio")
            {
                switch (this.estrato)
                {
                    case "1":
                        intValorPagar = 0;
                        break;
                    case "2":
                        intValorPagar = 0;
                        break;
                    case "3":
                        intValorPagar = 0;
                        break;
                    case "4":
                        intValorPagar = 5000;
                        break;
                    case "5":
                        intValorPagar = 10000;
                        break;
                    case "6":
                        intValorPagar = 20000;
                        break;


                }

            }

            return intValorPagar;
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtITipoidentificacion_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)

        /*pregunta si desea salir de la aplicacion si es si */
        {
            if (MessageBox.Show("Desea salir de la aplicacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                // salir de la aplicacion encaso de que sea si
                Application.Exit();



            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {

                MessageBox.Show("Datos registrados correctamente.");

            }


        }

        private void txtINidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números en la identificación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;  // Evita que el carácter no válido se ingrese
            }
        }


        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado es una letra o una tecla de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras en el nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;  // Evita que el carácter no válido se ingrese
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras y espacios, pero bloquea otros caracteres
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras y espacios en el nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;  // Evita que el carácter no válido se ingrese
            }
        }

        private void txtValorcopago_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpbtipoAtencion_Enter(object sender, EventArgs e)
        {

        }
    }
}

