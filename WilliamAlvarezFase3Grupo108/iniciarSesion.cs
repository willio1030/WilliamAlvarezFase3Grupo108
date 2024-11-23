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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void itemMenuacercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EPS Salvando Vidas S.A | Gestion de servicios \n Estudiante William Arvey Alvarez B","Acerca de " );
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Habilitar el campo de contraseña y el botón "Ingresar"
            txtPassword. Enabled = true;
            btnIngresar.Enabled = true;
        }
    }
}
