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
            String codVoucher = "5919099598E4C13F2ED5B12E50B1385";
            bool encontro=buscar.existeVoucher(codVoucher);
            if(encontro)
            {
                btnBuscarVoucher.Text="Encontro";
            }
        }
    }
}