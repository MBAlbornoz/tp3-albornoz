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
    public partial class FormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            NCliente negocio = new NCliente();
            Cliente cliente = new Cliente();
            try
            {
             
                cliente = negocio.buscarCliente((int)Session["DNI_Ingresado" + Session.SessionID]);

                if (cliente.id != 0)
                {
                        //cliente = (Cliente)Session["ClienteExistente" + Session.SessionID];

                         //int numeroCliente = Convert.ToInt32(TextVerDNICl.Text);
                        TxtNombreCl.Text = (String)cliente.nombre;
                        TxtApellidoCl.Text = (String)cliente.apellido;
                        TxtDniCl.Text = (String)cliente.dni.ToString();
                        TxtDirCl.Text = (String)cliente.direccion;
                        TxtCiudadCl.Text = (String)cliente.ciudad;
                        TxtMailCl.Text = (String)cliente.email;
                        TxtCPCl.Text = (String)cliente.cp;

                        TxtDniCl.Enabled = false;
                        //CARGO LOS COMBO TEXT DEL FORMULARIO CLIENTE
                    
                }
                else if (cliente.id == 0)
                {
                    Response.Redirect("Default.aspx");
                }

            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex;
                //  Response.Redirect("Error.aspx");
            }




        }
        protected void BtnAplicarCanje_Click(object sender, EventArgs e)
        {

        }

      
    }
}