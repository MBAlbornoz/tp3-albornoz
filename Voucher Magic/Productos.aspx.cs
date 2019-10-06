using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using DOMINIO;

namespace Voucher_Magic
{
    public partial class Productos : System.Web.UI.Page
    {
        public List<Producto> listaProductos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                NProducto negocio = new NProducto();
                listaProductos = negocio.listarProductos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void click_Elegir_Producto(object sender, EventArgs e)
        {
              Response.Redirect("Default.aspx");
        }

    }
}