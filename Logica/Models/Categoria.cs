using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Categoria
    {


        // primero escribimos las propiedas simples
     public int IDCategoria { get; set; }

     
     public string NombreCategoria { get; set; }


        //escribimos las funciones y metodos (operaciones)

       public  DataTable Listar()
        {
            DataTable R = new DataTable();
            
            //TODO: HAY QUE PROGRAMAR LA LLAMADA AL SP QUE RETORNA DATOS 


            return R;

        }

    }
}
