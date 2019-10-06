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
    public partial class FindClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void BtnRegistroCliente_Click(object sender, EventArgs e)
        {

            NCliente negocio = new NCliente();
            Cliente cliente= new Cliente();
            List<Cliente> listaClientes;
            try
            {
                //listaClientes = negocio.listarClientes();
                int numeroCliente = Convert.ToInt32(TextVerDNICl.Text);
                // int numeroCliente = Convert.ToInt32(Session["NumeroDNICliente" + Session.SessionID]);
                //  cliente = listaClientes.Find(J => J.dni == numeroCliente);
                cliente = negocio.buscarCliente(numeroCliente);

                if (TextVerDNICl.Text == "")
                {
                    //TEMPORAL, DEBO CAMBIAR A POSBACK PARA QUE RELEA LA PAGINA
                    //DEBO MOSTRAR MENSAJE QUE INGRESE EL DNI
                    Response.Redirect("FindClient.aspx");
                }

                if (cliente.id != 0)
                {
                    //cargarFormCliente(cliente);
                    Response.Redirect("~/FormCliente.aspx");
                }
                else if (cliente.id == 0)
                {
                    //paso por aqui
                    Response.Redirect("~/FormCliente.aspx");
                   // Response.Redirect("FormCliente.aspx");
                }

            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex;
              //  Response.Redirect("Error.aspx");
            }

           
        }

        private void cargarFormCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        protected void TextVerDNICl_TextChanged(object sender, EventArgs e)
        {
            string dni = TextVerDNICl.Text;

            if (Convert.ToInt32(dni) <= 8)
            {
                Session["NumeroDNICliente" + Session.SessionID] = dni;
               // Response.Redirect(".aspx");
            }
            else
            {
                Session["Error" + Session.SessionID] = "El numero de DNI es incorrecto";
              //  Response.Redirect("Error.aspx");
            }
        }
    }
}