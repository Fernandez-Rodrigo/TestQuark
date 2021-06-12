using System;
using System.Collections.Generic;
using System.Text;

namespace VentaMayorista
{
    class Prenda : ICotizable
    {
        bool calidadP;  
        double precioFinal;
        double precioBase;
        
        public bool CalidadP { get => calidadP; set => calidadP = value; }
  
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }

        /* public double CalculoPrecio(double precio_, bool calid)
         {

             if (calid == true)
             {
                 precio_ = precio_ * 1.3;
             }

             PrecioFinal = precio_;

             return PrecioFinal;
         }
        */
        public double CalculoPrecio()
        {
            if (this.calidadP == true)
            {
                this.PrecioBase = this.PrecioBase * 1.3;
            }

            return this.PrecioBase;
        }


        public virtual string Detalle()
        {
            return "prenda";
        }

    }



}
