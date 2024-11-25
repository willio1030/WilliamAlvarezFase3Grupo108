using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilliamAlvarezFase3Grupo108
{
    public partial class frmIniciarsesion : Form
    {
        /* 1 declaracion de variable constante 
         declaracion de manejador de errores */

        public const string password = "unad";
        private ErrorProvider error;
        public frmIniciarsesion()
        { 
            InitializeComponent();

            /* 2 inicializacion en el constructor
             * variable error del manejador de errores*/

            error= new ErrorProvider();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /* si la clave esta vacia */

             string password = "";
            /* utilizacion de this para llamar a txtpassword
             y trim para eliminar espacios innesarios */

            password = this.txtPassword.Text.Trim();

            /*validacion si la clave esta vacia */

            if (password.Equals(""))
            {
                this.error.SetError(this.txtPassword, "se debe ingresar una clave ");

                this.txtPassword.Focus();

            }
            /*validacion si la clave es diferente 
             tambien errorprovider devolviendolo con setError
             para la validacion de error
            */
            else

            {
                if (!password.Equals("unad"))
                {
                    this.error.SetError(this.txtPassword, "la clave ingresada no es valida ");

                    this.txtPassword.Focus();
                }

                /* anulamos el errroprovider 
                 instanciamos frmIngresoDatos con el
                objeto ingreso datos  para mostrar el formulario
                ademas para cerrar el anterior */
                else
                {
                    this.error.SetError(this.txtPassword, null);
                    frmIngresodatos ingresodatos = new frmIngresodatos();
                    ingresodatos.Show();
                    this.Hide();

                }


            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* 3 utilizacion de la palabra reservada Application
             para salir */

            Application.Exit(); 
        }

        private void itemMenuacercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EPS Salvando Vidas S.A |sistema de  Gestion de servicios usuarios \n Estudiante William Arvey Alvarez B grupo 108","Acerca de " );
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Habilitar el campo de contraseña y el botón "Ingresar"
            txtPassword. Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           



        }
    }
}
