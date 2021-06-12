using System;
using System.Collections.Generic;
using System.Text;

namespace VentaMayorista
{
    class Vendedor
    {
        string nombre, apellido;
        int codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }

       public Vendedor(string nombre, string apellido, int codigo)
        {

        }
    }
}
