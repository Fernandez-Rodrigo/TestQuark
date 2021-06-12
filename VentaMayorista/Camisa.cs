using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace VentaMayorista
{
    class Camisa : Prenda
    {
        bool mangaL;
        bool cuelloM;
        

        public bool MangaL { get => mangaL; set => mangaL = value; }
        public bool CuelloM { get => cuelloM; set => cuelloM = value; }
 

        public Camisa(bool cuello, bool manga,  double precio, bool calidad)
        {
            this.cuelloM = cuello;
            this.mangaL = manga;
            this.PrecioBase = precio;
            this.CalidadP = calidad;

        }     

        public override double CalculoPrecio()
        {

            if (this.mangaL == false)
            {
                this.PrecioBase = this.PrecioBase * 0.9;
            }
            if (this.cuelloM == true)
            {
                this.PrecioBase = this.PrecioBase * 1.03;
            }


            this.PrecioBase = base.CalculoPrecio();

            return this.PrecioBase;


        }


        public override string Detalle()
        {
            string detalle = (this.mangaL)? "Camisa manga larga" : "Camisa manga corta";

            detalle = (this.cuelloM) ? detalle + " cuello Mao" : detalle;

            return detalle;
        }




    }

}
