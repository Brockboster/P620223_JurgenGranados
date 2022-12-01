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
    public partial class FrmPrincipalMDI : Form
    {
        public FrmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void FrmPrincipalMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            //al cerrar el formulario principal se deberia terminar la aplicacion

            //en el caso que lo que queremos es volver a mostrar el form de login 
            //deberiamos agregar un objeto global para dicho formulario 


            Application.Exit();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //en el caso del form de gestion de usuarios es necesario establecerlo 
            //en globales

            //si queremos que un formulario se muestre solo una vez deberiamos verificar
            //que este visible o no y en caso lo este se reinstancia y muestra de nuevo 


            //el simbolo ! niega una condicion logica 
            if(!Globales.MiFormMantUsuarios.Visible)
                {

                Globales.MiFormMantUsuarios = new FrmUsuariosGestion();
                Globales.MiFormMantUsuarios.Show();

            }

            

        }
    }
}
