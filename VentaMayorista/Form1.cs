using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaMayorista
{
    public partial class Form1 : Form
    {


        Tienda tienda = new Tienda();

        public Form1()
        {
            InitializeComponent();
            lblStock.Text = Convert.ToString(tienda.CamLarg);
        }
        
        private void radCam_CheckedChanged(object sender, EventArgs e)
        {
            if(radCam.Checked == true)
            {
                chkChup.Enabled = false;
                chkManga.Enabled = true;
                chkCuello.Enabled = true;
                
            }
        }

        private void radPant_CheckedChanged(object sender, EventArgs e)
        {
            if(radPant.Checked == true)
            {
                
                chkChup.Enabled = true;
                chkManga.Enabled = false;
                chkCuello.Enabled = false;
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {   if (radCam.Checked == true && Convert.ToInt32(lblStock.Text) >= Convert.ToInt32(txtCantidad.Text) && Convert.ToInt32(lblStock.Text) > 0 && Convert.ToInt32(txtCantidad.Text) > 0)
            {
                Camisa camisa = new Camisa(chkCuello.Checked, chkManga.Checked, Convert.ToDouble(txtPrecio1.Text), radPrem.Checked);
                Cotizacion cotiz = new Cotizacion(Convert.ToInt32(lblCotizNum.Text), Convert.ToInt32(lblCodVend.Text), Convert.ToString(FechaForm), radCam.Text, Convert.ToInt32(txtCantidad.Text));
                cotiz.Prenda = camisa;
                double resultado = cotiz.PrecioFinal();
                lblPrecioFinal.Text = Convert.ToString(resultado);
                tienda.ActualizarStock(cotiz);
                lblStock.Text =  Convert.ToString(tienda.Stock[camisa.Detalle()]);
                int cotizNub = Convert.ToInt32(lblCotizNum.Text) + 1;
                lblCotizNum.Text = Convert.ToString(cotizNub);
            }   
            else if (radPant.Checked == true && Convert.ToInt32(lblStock.Text) >= Convert.ToInt32(txtCantidad.Text) && Convert.ToInt32(lblStock.Text) > 0 && Convert.ToInt32(txtCantidad.Text) > 0)
            {
                Pantalon pantalon = new Pantalon(Convert.ToDouble(txtPrecio1.Text), radPrem.Checked, chkChup.Checked);
                lblStock.Text = Convert.ToString(tienda.Stock[pantalon.Detalle()]);
                Cotizacion cotiz = new Cotizacion(Convert.ToInt32(lblCotizNum.Text), Convert.ToInt32(lblCodVend.Text), Convert.ToString(FechaForm), radPant.Text, Convert.ToInt32(txtCantidad.Text));
                double resultado = cotiz.PrecioFinal();
                lblPrecioFinal.Text = Convert.ToString(resultado);
                tienda.ActualizarStock(cotiz);
                int cotizNub = Convert.ToInt32(lblCotizNum.Text) + 1;
                lblCotizNum.Text = Convert.ToString(cotizNub);

            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este artículo o la cantidad es incorrecta");
            }



        }

        private void btnStock_Click(object sender, EventArgs e)
        {  /*
            if (radCam.Checked == true)
            {
                lblStock.Text = tienda.ActualizarCantidadCamisa(chkCuello.Checked, chkManga.Checked);
            }

            if (radPant.Checked == true)
            {
                lblStock.Text = tienda.ActualizarCantidadPant(chkChup.Checked);
            }
            */
        }
        
    }
}
