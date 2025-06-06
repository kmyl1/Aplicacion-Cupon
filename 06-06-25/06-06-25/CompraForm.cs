using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_06_25
{
    public partial class CompraForm : Form
    {

        private clsCompra compra;

        public CompraForm()
        {
            compra=new clsCompra();
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (txt_Monto.Text != "" && txt_Cupon.Text != "")
            {   
                try
                {
                    float monto = float.Parse(txt_Monto.Text);
                    string cupon=txt_Cupon.Text;
                    compra.CompraT(monto, cupon);
                    txt_Pago.Text = "$"+compra.getCompra;
                    txt_Cuponu.Text = compra.getCupon;
                    txt_Descuento.Text = "$" + compra.getDescuento;
                    txt_Total.Text = "$"+compra.getTotal;
                    txt_Monto.Text = "";
                    txt_Cupon.Text = "";
                }
                catch 
                {
                    MessageBox.Show("Datos capturados incorrectos");
                    txt_Monto.Text = "";
                    txt_Cupon.Text = "";
                }
            }
        }
    }
}
