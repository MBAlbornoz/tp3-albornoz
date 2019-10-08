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
            String codError = "";
   
            bool encontro=buscar.existeVoucher(codVoucher);
            if(encontro)
            {
                //btnBuscarVoucher.Text="Encontro";
                if(!buscar.estadoVoucher(codVoucher))
                {
                    Session["NumeroVoucher" + Session.SessionID] = codVoucher;
                    Response.Redirect("Productos.aspx");
                }
                codError = "El codigo de voucher: " +codVoucher+ " ya ha sido utilizado. Por favor ingrese otro código o contactese con su proveedor";
            }
            codError = "El codigo de Voucher: " + codVoucher + " no existe. Por favor, verifique el código y vuelva a ingresarlo.";
        }
    }
}