using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voucher_Magic
{
    public partial class FindClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void BtnRegistroCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormCliente.aspx");
        }
    }
}