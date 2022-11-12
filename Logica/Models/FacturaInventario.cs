using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaInventario
    {
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Subtotal { get; set; } //Suma de cantidad * precio de venta 


        public decimal DescuentoTotal { get; set; }
        public decimal Subtotal2 { get; set; } //Subtotal - DescuentoTotal
        public decimal ImpuestosTotal { get; set; }

        public decimal TotalLinea { get; set; }//Subtotal2 + ImpuestoTotal 


        //atributos compuestos 
        public Inventario MiInventario { get; set; }
        public FacturaInventario()
        {
            MiInventario = new Inventario();    
        }
       

        // Crear funciones para la mate de totalizaciones para no tener 
        //que usar en la clase principal


        public decimal TotalizarLinea()
        {

            //totalizar subtotal
            Subtotal = Cantidad * PrecioVenta;
            //monto del descuento
            DescuentoTotal = (Subtotal * PorcentajeDescuento) / 100;
            //Subtotal12
            Subtotal2 = Subtotal - DescuentoTotal;
            //monto del impuesto
            ImpuestosTotal = (Subtotal2 * PorcentajeImpuesto) / 100;
            //total final
            TotalLinea = Subtotal2 + ImpuestosTotal;




            return TotalLinea;   



        }
    }
}
