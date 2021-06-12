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
        int camCortCuelloM;
        int camCort;
        int camLargCuelloM;
        int camLarg;
        int pantChup;
        int pant;
       

        public int CamCortCuelloM { get => camCortCuelloM; set => camCortCuelloM = value; }
        public int CamCort { get => camCort; set => camCort = value; }
        public int CamLargCuelloM { get => camLargCuelloM; set => camLargCuelloM = value; }
        public int CamLarg { get => camLarg; set => camLarg = value; }
        public int PantChup { get => pantChup; set => pantChup = value; }
        public int Pant { get => pant; set => pant = value; }
        public Hashtable Stock { get => stock; set => stock = value; }

        public Tienda()
        {
            stock = new Hashtable();
            CamCortCuelloM = 200;
            CamCort = 300;
            CamLargCuelloM = 150;
            CamLarg = 350;
            PantChup = 1500;
            Pant = 500;

            Stock.Add("Camisa manga corta", 300);
            Stock.Add("Camisa manga corta cuello Mao", 200);
            Stock.Add("Camisa manga larga", 350);
            Stock.Add("Camisa manga larga cuello Mao", 150);
            Stock.Add("Pantalón", 500);
            Stock.Add("Pantalón chupín", 1500);
        }



        public void ReducirCantidadCamiseta(bool cuelloM, bool mangaL, int cantidad)
        {
            

            if(cuelloM == true && mangaL == true)
            {
              
                CamLargCuelloM = CamLargCuelloM - cantidad;
            }
            else if(cuelloM == false && mangaL == true)
            {
              
                CamLarg = CamLarg - cantidad;
            }
            else if (cuelloM == true && mangaL == false)
            {
                
                CamCortCuelloM = CamCortCuelloM - cantidad;
            }
            else if(cuelloM == false && mangaL == false)
            {
               
                CamCort = CamCort - cantidad;
            }
            
        }

        public void ReducirCantidadPant(bool chup, int cantidad)
        {
            if(chup == true)
            {
              
                PantChup = pantChup - cantidad;
            }
            else
            {
                
                Pant = Pant - cantidad;
            }
        }


        public string ActualizarCantidadCamisa(bool cuelloM, bool mangaL)
        {
            if (cuelloM == true && mangaL == true)
            {
                return Convert.ToString(CamLargCuelloM);
            }
            else if (cuelloM == false && mangaL == true)
            {
                return Convert.ToString(CamLarg);           
            }
            else if (cuelloM == true && mangaL == false)
            {
                return Convert.ToString(CamCortCuelloM);
            }
            else 
            {
                return Convert.ToString(CamCort);
            }
          
        }


        public string ActualizarCantidadPant(bool chup)
        {
            if (chup == true)
            {
                return Convert.ToString(PantChup);
            }
            else
            {
                return Convert.ToString(Pant);
            }
        }


        public void ActualizarStock(Cotizacion cotiza)
        {
            string detalle = cotiza.Prenda.Detalle();

            MessageBox.Show(detalle);

            int numero = (int)this.Stock[detalle];

            numero = numero - cotiza.Cantidad;

            this.Stock[cotiza.Prenda.Detalle()] = numero;
        }

      
    }
}
