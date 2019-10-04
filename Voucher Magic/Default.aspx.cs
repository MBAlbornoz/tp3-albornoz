using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace Voucher_Magic
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarVoucher_Click(object sender, EventArgs e)
        {
            NVoucher buscar = new NVoucher();
            String codVoucher = txtBuscarVoucher.Text;
   
            bool encontro=buscar.existeVoucher(codVoucher);
            if(encontro)
            {
                btnBuscarVoucher.Text="Encontro";
                //btnBuscarVoucher.GetRouteUrl;
                
            }
        }
    }
}