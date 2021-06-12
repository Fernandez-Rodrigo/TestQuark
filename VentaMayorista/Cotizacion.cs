using System;
using System.Collections.Generic;
using System.Text;

namespace VentaMayorista
{
    class Cotizacion
    {
        int identificacion;
        static int numeroCot;
        int codigo;
        DateTime fecha;
        List<Cotizacion> cotizaciones = new List<Cotizacion>();
        int cantidad;
        Prenda prenda;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal Prenda Prenda { get => prenda; set => prenda = value; }
        internal List<Cotizacion> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }
        public int Identificacion { get => identificacion; set => identificacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Cotizacion(int codigoVend,Prenda p, int cantidad)
        {
            Cotizacion.numeroCot = Cotizacion.numeroCot++;
            Identificacion = codigoVend;
            this.codigo = Cotizacion.numeroCot;
            this.Fecha = DateTime.Now;
            this.Prenda = p;
            this.Cantidad = cantidad;
        }
               

        public double PrecioFinal()
        {
            return this.Cantidad * this.Prenda.CalculoPrecio();
        }

    }
}
