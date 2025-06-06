using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_06_25
{
    class clsCompra
    {
        private float compra;
        private string cupon;
        private float descuento;
        private float total;

        public clsCompra()
        {
            compra = 0;
            cupon = "";
            descuento = 0;
            total = 0;
        }

        public float getCompra
        {
            get { return compra; }
        }

        public string getCupon
        {
            get { return cupon; }
        }

        public float getDescuento
        {
            get { return descuento; }
        }

        public float getTotal
        {
            get { return total; }
        }

        public void CompraT(float monto, string cupoon)
        {
            cupon = cupoon;
            compra = monto;

            descuento = compra * 15 / 100;

            if (cupon != "MX15")
            {
                cupon = "Ninguno";
                descuento = 0;
                total = compra;
            }
            else if (cupon=="MX15" && descuento>=500)
            {
                descuento = 500;
                total = compra - descuento;
            }
            else
            {
                total = compra-descuento;
            }

        }

    }
}
