using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_JurgenGranados.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnVerPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //cierra completamente la aplicacion
            Application.Exit();
        }

        private void BtnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //TO DO: Se debe validar el ingreso del usuario 

            //Si la validacion es correcta permite el ingreso al sistema
            //y muestre el formulario principal.

            Globales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}
