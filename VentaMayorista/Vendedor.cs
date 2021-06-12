using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace VentaMayorista
{
    class Vendedor
    {
        string nombre, apellido;
        int codigo;
        List<Cotizacion> cotizaciones = new List<Cotizacion>();


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        internal List<Cotizacion> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }

        public Vendedor(string nombre, string apellido, int codigo)
       {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Codigo = codigo;
       }

        public void AgregarCotiz(Cotizacion c)
        {
            this.Cotizaciones.Add(c);
        }

        public async Task ImprimirHistorial()
        {
            foreach (Cotizacion cot in this.cotizaciones)
            {
                string[] lines =
                {
                    "\n" + this.Nombre + " " + this.Apellido + " " + Convert.ToString(this.Codigo),
                    "\n" + " " + Convert.ToString(cot.Fecha),
                    "\n" + " " + Convert.ToString(cot.Cantidad) + " " + cot.Prenda.Detalle(),
                    "\n-----------------------------------------------------------------"
                };

                await File.WriteAllLinesAsync(this.nombre + " " + " -HISTORIAL.txt", lines);

            }
        }

    }
}
