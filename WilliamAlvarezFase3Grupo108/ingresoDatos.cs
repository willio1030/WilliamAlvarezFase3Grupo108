﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        // private string reporteDatos;


        // inicializacion de variables para lista cola y pila

        Stack<estructuraDatosusuario> Pila = new Stack<estructuraDatosusuario>();
        Queue<estructuraDatosusuario> Cola = new Queue<estructuraDatosusuario>();
        List<estructuraDatosusuario> Lista = new List<estructuraDatosusuario>();


        // variables de control para el reporte de los datos

        private int intReporDatostepila;
        private int intReporteDatoscola;
        private int intreporteDatoslista;



        public frmIngresodatos()
        {
            InitializeComponent();
            // declaracion del metodo cargar ElementosIniciales

            cargarElementosIniciales();
            // inicializacion variables que capturan el reporte 

            this.intreporteDatoslista = 0;
            this.intReporteDatoscola = 0;
            this.intreporteDatoslista = 0;

            //desabilitar botones reporte pila cola y lista

            this.btnReportepila.Enabled = false;
            this.btnReportecola.Enabled = false;
            this.btnReportelista.Enabled = false;

            //desabilitar botones Eliminar pila cola y lista

            this.btnEliminarpila.Enabled = false;
            this.btnEliminarcola.Enabled = false;
            this.btnEliminarlista.Enabled = false;



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
            this.nIdentificacion = this.txtedad.Text.Trim();

            if (string.IsNullOrEmpty(this.nIdentificacion)) // Valida el texto del TextBox
            {
                mensajeValidacion += "- Número de identificación\n"; // Agrega mensaje de error
            }

            // Validar el campo "Nombre Completo"

            this.nombre = this.txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(this.nombre)) // Valida el texto del TextBox
            {
                mensajeValidacion += "- Nombre Completo\n"; // Agrega mensaje de error
            }
            // Validar el campo "Edad"

            this.edad = this.txtedad.Text.Trim();

            if (string.IsNullOrEmpty(this.edad)) // Valida el texto del TextBox
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


            if (this.tAtencion == "Medicina General")
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

            if (this.tAtencion == "Examenes de laboratorio")
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

                /*traer la informacion de los atributos de clase 
                 que son recuperados del formulario ahora los vamos 
                a montarlo en la clase DTO estructuraDatosusuario*/

                estructuraDatosusuario miEstructura = new estructuraDatosusuario();
                miEstructura.tIdentificacion = this.tIdentificacion;
                miEstructura.nIdentificacion = this.nIdentificacion;
                miEstructura.nombre = this.nombre;
                miEstructura.edad = int.Parse(this.edad);
                miEstructura.estrato = int.Parse(this.estrato);
                miEstructura.tAtencion = this.tAtencion;
                miEstructura.vCopago = int.Parse(this.vcopago);
                miEstructura.fechaAcceso = this.fechaAcceso;
                miEstructura.tEstructura = this.tEstructura;

                if (this.tEstructura.Equals("Pila"))

                {

                    /*sumar los valores de la pila cada vez que se ingres un dato*/

                    this.intReporDatostepila = this.intReporDatostepila + int.Parse(this.vcopago);
                    this.Pila.Push(miEstructura);

                    // como se refleja en el dataGribView
                    dgPila.DataSource = null;
                    dgPila.DataSource = this.Pila.ToArray();
                    this.tabEstructuras.SelectedIndex = 0;
                    MessageBox.Show("el registro fue agregado a la pila ", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReportepila.Enabled = true;
                    this.btnEliminarpila.Enabled = true;
                    ;


                }

                if (this.tEstructura.Equals("Cola"))

                {
                    this.Cola.Enqueue(miEstructura);

                    // como se refleja en el dataGribView
                    dgCola.DataSource = null;
                    dgCola.DataSource = this.Cola.ToArray();
                    this.tabEstructuras.SelectedIndex = 1;
                    MessageBox.Show("el registro fue agregado a la cola ", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReportecola.Enabled = true;
                    this.btnEliminarcola.Enabled = true;

                }

                if (this.tEstructura.Equals("Lista"))

                {
                    this.Lista.Add(miEstructura);

                    // como se refleja en el dataGribView
                    dgLista.DataSource = null;
                    dgLista.DataSource = this.Lista.ToArray();
                    this.tabEstructuras.SelectedIndex = 2;
                    MessageBox.Show("el registro fue agregado a la lista ", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReportelista.Enabled = true;
                    this.btnEliminarlista.Enabled = true;

                }

                cargarElementosIniciales();


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

        private void btnReportepila_Click(object sender, EventArgs e)


        {
            if (Pila.Count > 0)
            {
                int sumaCopagos = Pila.Sum(p => p.vCopago);
                txtReportedatos.Text = $" {sumaCopagos}";
            }
            else
            {
                MessageBox.Show("La pila está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }





        private void txtReportedatos_TextChanged(object sender, EventArgs e)
        {

            {

            }


        }

        private void btnReportecola_Click(object sender, EventArgs e)
        {
            // Verificamos si la cola está vacía antes de contar los elementos
            if (Cola.Count > 0)
            {
                // Contamos los elementos de la cola
                int cantidadRegistros = Cola.Count;

                // Actualizamos el TextBox txtReportedatos.Text
                txtReportedatos.Text = $" {cantidadRegistros}";
            }
            else
            {
                txtReportedatos.Text = "La cola está vacía.";
            }
        }

        private void btnReportelista_Click(object sender, EventArgs e)
        {
            // Verificamos si la lista está vacía antes de calcular el promedio
            if (Lista.Count > 0)
            {
                // Calculamos el promedio de las edades utilizando LINQ
                double promedioEdades = Lista.Average(l => l.edad);

                // Actualizamos el TextBox txtReportedatos.Text
                txtReportedatos.Text = $" {promedioEdades}";
            }
            else
            {
                txtReportedatos.Text = "La lista está vacía.";
            }
        }

        private void btnEliminarpila_Click(object sender, EventArgs e)
        {
            if (Pila.Count > 0)
            {
                // Eliminamos el elemento superior de la pila
                Pila.Pop();

                // Actualizamos el DataGridView de la pila
                dgPila.DataSource = null;
                dgPila.DataSource = Pila.ToArray();

                // Mostrar un mensaje de confirmación (opcional)
                MessageBox.Show("Elemento eliminado de la pila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La pila está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminarcola_Click(object sender, EventArgs e)
        {
            if (Cola.Count > 0)
            {
                // Eliminamos el primer elemento de la cola
                Cola.Dequeue();

                // Actualizamos el DataGridView de la cola
                dgCola.DataSource = null;
                dgCola.DataSource = Cola.ToArray();

                MessageBox.Show("Elemento eliminado de la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cola está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnEliminarlista_Click(object sender, EventArgs e)
        {
            if (Lista.Count > 0)
            {
                Lista.RemoveAt(Lista.Count - 1); // Elimina el último elemento
                dgLista.DataSource = null;
                dgLista.DataSource = Lista.ToArray();
                MessageBox.Show("Último elemento eliminado de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La lista está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private estructuraDatosusuario obtenerCliente(string nIdentificacion)
        {
            // Utiliza LINQ para encontrar el elemento de forma más concisa
            return Lista.FirstOrDefault(cliente => cliente.nIdentificacion == nIdentificacion);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            txtINidentificacion.Text = "";
            txtNombre.Text = "";
            txtedad.Text = "";
            // ... y así con todos los demás TextBox

            // Limpiar los ComboBox
            cmbTipoidentificacion.SelectedIndex = -1;
            cmbEstrato.SelectedIndex = -1;
            cmbTipoestructura.SelectedIndex = -1;

            // Limpiar los RadioButton
            rtbnmedicinaGeneral.Checked = false;
            rtbnExameneslaboratorio.Checked = false;

            // Limpiar el DatePicker
            dtskAcceso.Value = DateTime.Now; // O cualquier fecha por defecto que prefieras

            // Limpiar el TextBox de reporte
            txtReportedatos.Text = "";



        }
        private List<estructuraDatosusuario> Buscar(IEnumerable<estructuraDatosusuario> estructura, string nIdentificacion)
        {
            return estructura.Where(x => x.nIdentificacion == nIdentificacion).ToList();
        }

        private void btnBuscarPila_Click(object sender, EventArgs e)
        {
            string nIdentificacionABuscar = txtINidentificacion.Text;
            var resultados = Buscar(Pila, nIdentificacionABuscar);
            dgPila.DataSource = resultados;
            // ... Mostrar mensaje si no se encuentran resultados
        }

        private void btnBuscarCola_Click(object sender, EventArgs e)
        {
            // ... (similar al anterior, pero usando Cola)
        }

        private void btnBuscarLista_Click(object sender, EventArgs e)
        {
            // ... (similar al anterior, pero usando Lista)
        }
    }
}





