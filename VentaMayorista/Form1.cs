using System;
using System.Windows.Forms;

namespace VentaMayorista
{
    public partial class Form1 : Form
    {


        Tienda tienda = new Tienda();
        Vendedor v1;
        public Form1()
        {
            InitializeComponent();
            lblStock.Text = Convert.ToString(tienda.Stock["Camisa manga corta"]);
            this.v1 = new Vendedor(lblNombrevend.Text, lblApellidoVend.Text, Convert.ToInt32(lblCodVend.Text));
        }

        private void radCam_CheckedChanged(object sender, EventArgs e)
        {
            if (radCam.Checked == true)
            {
                chkChup.Enabled = false;
                chkManga.Enabled = true;
                chkCuello.Enabled = true;

            }
        }

        private void radPant_CheckedChanged(object sender, EventArgs e)
        {
            if (radPant.Checked == true)
            {

                chkChup.Enabled = true;
                chkManga.Enabled = false;
                chkCuello.Enabled = false;
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radCam.Checked == true && Convert.ToInt32(lblStock.Text) >= Convert.ToInt32(txtCantidad.Text) && Convert.ToInt32(lblStock.Text) > 0 && Convert.ToInt32(txtCantidad.Text) > 0 && Convert.ToDouble(txtPrecio1.Text) > 0)
                {
                    Camisa camisa = new Camisa(chkCuello.Checked, chkManga.Checked, Convert.ToDouble(txtPrecio1.Text), radPrem.Checked);
                    Cotizacion cotiz = new Cotizacion(Convert.ToInt32(lblCodVend.Text), camisa, Convert.ToInt32(txtCantidad.Text));
                    this.v1.AgregarCotiz(cotiz);
                    lblPrecioFinal.Text = Convert.ToString(cotiz.PrecioFinal());
                    tienda.ActualizarStock(cotiz);
                    lblStock.Text = Convert.ToString(tienda.Stock[camisa.Detalle()]);
                    lblCotizNum.Text = Convert.ToString((Convert.ToInt32(lblCotizNum.Text) + 1));
                }
                else if (radPant.Checked == true && Convert.ToInt32(lblStock.Text) >= Convert.ToInt32(txtCantidad.Text) && Convert.ToInt32(lblStock.Text) > 0 && Convert.ToInt32(txtCantidad.Text) > 0 && Convert.ToDouble(txtPrecio1.Text) > 0)
                {
                    Pantalon pantalon = new Pantalon(Convert.ToDouble(txtPrecio1.Text), radPrem.Checked, chkChup.Checked);
                    lblStock.Text = Convert.ToString(tienda.Stock[pantalon.Detalle()]);
                    Cotizacion cotiz = new Cotizacion(Convert.ToInt32(lblCodVend.Text), pantalon, Convert.ToInt32(txtCantidad.Text));
                    this.v1.AgregarCotiz(cotiz);
                    lblPrecioFinal.Text = Convert.ToString(cotiz.PrecioFinal());
                    tienda.ActualizarStock(cotiz);
                    lblCotizNum.Text = Convert.ToString(Convert.ToInt32(lblCotizNum.Text) + 1);
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock de este artículo, la cantidad es incorrecta o el precio es incorrecto");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Faltan datos, por favor completar todas las casillas");
            }



        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            
            foreach (Cotizacion cot in v1.Cotizaciones)
            {
                txtHist.Text = txtHist.Text + "\n" + v1.Nombre + " " + v1.Apellido + " " + Convert.ToString(v1.Codigo);
                txtHist.Text = txtHist.Text + "\n" + " " + Convert.ToString(cot.Fecha);
                txtHist.Text = txtHist.Text + "\n" + " " + Convert.ToString(cot.Cantidad) + " " + cot.Prenda.Detalle();
                txtHist.Text = txtHist.Text + "\n-----------------------------------------------------------------";
            }
        }

    }

}
