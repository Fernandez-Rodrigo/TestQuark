using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace VentaMayorista
{
    class Tienda
    {
        string nombre, direccion;
        List<string> prendas = new List<string> { "Camisa manga corta", "Camisa manga corta cuello Mao", "Camisa manga larga", "Camisa manga larga cuello Mao", "Pantalón", "Pantalón chupín" };

        Hashtable stock;
        
        public Hashtable Stock { get => stock; set => stock = value; }

        public Tienda()
        {
            stock = new Hashtable();
          
            Stock.Add("Camisa manga corta", 300);
            Stock.Add("Camisa manga corta cuello Mao", 200);
            Stock.Add("Camisa manga larga", 350);
            Stock.Add("Camisa manga larga cuello Mao", 150);
            Stock.Add("Pantalón", 500);
            Stock.Add("Pantalón chupín", 1500);
        }
      
       

        public void ActualizarStock(Cotizacion cotiza)
        {
            string detalle = cotiza.Prenda.Detalle();

           int numero = (int)this.Stock[detalle];

            numero = numero - cotiza.Cantidad;

            this.Stock[cotiza.Prenda.Detalle()] = numero;
        }

      
    }
}
