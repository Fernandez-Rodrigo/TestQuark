using System;
using System.Collections.Generic;
using System.Text;

namespace VentaMayorista
{
    class Pantalon : Prenda
    {
        bool chupin;
        

        public Pantalon(double precio_, bool calid, bool chup)
        {
            this.chupin = chup;
            this.PrecioBase = precio_;
            this.CalidadP = calid;

        }

        public bool Chupin { get => chupin; set => chupin = value; }

   
        public double CalculoPrecio()
        {

            if (this.Chupin == false)
            {
                this.PrecioBase = this.PrecioBase * 0.9;
            }
           

            this.PrecioBase = base.CalculoPrecio();

            return this.PrecioBase;


        }
        public override string Detalle()
        {
           
                return (this.chupin) ? "Pantalón chupín" : "Pantalón";
            

        }
    }
}
