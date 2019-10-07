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
        bool isClient = false;
        Cliente cliente = new Cliente();
        NCliente negocio = new NCliente();


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                 cliente = negocio.buscarCliente((int)Session["DNI_Ingresado" + Session.SessionID]);

                if (cliente.id != 0)
                {
                        isClient = true;
                        TxtNombreCl.Text = (String)cliente.nombre;
                        TxtApellidoCl.Text = (String)cliente.apellido;
                        TxtDniCl.Text = (String)cliente.dni.ToString();
                        TxtDirCl.Text = (String)cliente.direccion;
                        TxtCiudadCl.Text = (String)cliente.ciudad;
                        TxtMailCl.Text = (String)cliente.email;
                        TxtCPCl.Text = (String)cliente.cp;

                        TxtDniCl.Enabled = false; //DESHABILITO LA EDICION DEL COMBOTEXT DNI
              
                }
                else if (cliente.id == 0)
                {
                    TxtDniCl.Text = (String)Session["DNI_Ingresado" + Session.SessionID].ToString();
                    TxtDniCl.Enabled = false; //DESHABILITO LA EDICION DEL COMBOTEXT DNI

                   
                    cliente.apellido = TxtApellidoCl.Text;
                    cliente.nombre = TxtNombreCl.Text;
                    cliente.direccion = TxtDirCl.Text;
                    cliente.ciudad = TxtCiudadCl.Text;
                    cliente.cp = TxtCPCl.Text;
                    cliente.email = TxtMailCl.Text;
                    cliente.fechaRegistro = DateTime.Now;
                    cliente.dni = Convert.ToInt32(TxtDniCl.Text);
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
            if(isClient)
            {
                negocio.actualizarCliente(cliente);
            }
            else
            {
                negocio.altaCliente(cliente);
            }
        }

      
    }
}