using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        //atributos simples
        public int IDUsuario { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasennia { get; set; }

        public string Email { get; set; }

        public bool Activo { get; set; }



        //Atributos compuestos

        public Empresa MiEmpresa { get; set; }

        public UsuarioRol MiRol { get; set; }


        public Usuario()
        {
            MiEmpresa = new Empresa();
            MiRol = new UsuarioRol();
            Activo = true;

        }


        //fns y methods 

        public bool Agregar()
        {
            bool R = false;

            //TODO: ejecutar un SP que contenga la instruccion 
            //INSERT correspondiente y retornar true si 
            //todo sale bien 

            return R;
        }
        public bool Modificar()
        {
            bool R = false;

            //TODO: ejecutar un SP que contenga la instruccion 
            //UPDATE correspondiente y retornar true si 
            //todo sale bien 

            return R;
        }
        public bool Eliminar()
        {
            //en las eliminaciones logicas, lo que haremos sera cambiar el valor del
            //campo Activo a 0 (false)
            bool R = false;

            //TODO: ejecutar un SP que contenga la instruccion 
            //UPDATE correspondiente y retornar true si 
            //todo sale bien 

            return R;
        }

        public  Usuario ConsultarPorID()
        {
            Usuario R = new Usuario();

            //TODO: ejecutar un SP que contenga la instruccion 
            //SELECT correspondiente y retornar true si 
            //todo sale bien 

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            //TODO: ejecutar un SP que contenga la instruccion 
            //SELECT correspondiente y retornar true si 
            //todo sale bien 

            return R;
        }


        public bool ConsultarPorNombreUsuario()
        {
            bool R = false;

            //TODO: ejecutar un SP que contenga la instruccion 
            //SELECT correspondiente y retornar true si 
            //todo sale bien 

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            //TODO: ejecutar un SP que contenga la instruccion 
            //SELECT correspondiente y retornar true si 
            //todo sale bien 

            return R;
        }

        public DataTable ListarActivos()
        {

            DataTable R = new DataTable();



            return R;
        }
        public DataTable ListarInactivos()
        {

            DataTable R = new DataTable();



            return R;
        }

        public bool ValidarLogin(string NombreUsuario, string Contrasennia)
        {
            bool R = false;
            //TODO: ejecutar un SP que contenga la instruccion 
            //SELECT correspondiente y retornar true si 
            //todo sale bien
            return R;

        }


        public bool EnviarCodigoRecuperacion(string Email)
        {
            bool R = false;
            //TODO: ejecutar un SP que contenga la instruccion 
            //SELECT correspondiente y retornar true si 
            //todo sale bien
            return R;

        }

        public bool ResetearContrasennia()
        {
            bool R = false;
            //TODO: ejecutar un SP que contenga la instruccion 
            //SELECT correspondiente y retornar true si 
            //todo sale bien
            return R;

        }



    }
}
