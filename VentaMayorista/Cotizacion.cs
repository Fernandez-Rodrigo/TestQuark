using System;
using System.Collections.Generic;
using System.Text;

namespace VentaMayorista
{
    class Cotizacion
    {
        int identificacion;
        int codigo=0;
        string producto;
        int unidades;
        int sumaFinal;
        bool camisa;
        bool pantalon;
        DateTime fecha;
        double precioFinal;
        List<Cotizacion> cotizaciones = new List<Cotizacion>();
        int cantidad;
        Prenda prenda;

        public double PrecioFinal1 { get => precioFinal; set => precioFinal = value; }
        public bool Camisa { get => camisa; set => camisa = value; }
        public bool Pantalon { get => pantalon; set => pantalon = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal Prenda Prenda { get => prenda; set => prenda = value; }

        // string codVend, DateTime fecha, string prenda, int cant, int precioFinal, double precioB, int stock, bool calid

        public Cotizacion(int codigoCotiz, int codigoVend, string fecha, string prenda, int cantidad)
        {
            
            cotizaciones.Add(this);

            this.Cantidad = cantidad;

            codigoCotiz = codigoCotiz + 1;


        }
               
        public double PrecioFinalPantalon(double precio_, bool calid, int cantidad, bool chup)
        {
            Pantalon pantalon = new Pantalon(precio_, calid, chup);

            PrecioFinal1 = pantalon.PrecioFinal * cantidad;

         

            return PrecioFinal1;
        }

        public double PrecioFinal()
        {
            return this.Cantidad * this.Prenda.CalculoPrecio();
        }

    }
}
