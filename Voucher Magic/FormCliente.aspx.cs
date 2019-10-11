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

        Boolean ingreso = false;
        Boolean isClient = false;
        Cliente cliente;
      


        protected void Page_Load(object sender, EventArgs e)
        {
            NCliente negocioCliente = new NCliente();
           // cliente = new Cliente()
            cliente = negocioCliente.buscarCliente((int)Session["DNI_Ingresado" + Session.SessionID]);
            
            if(!IsPostBack)
            {
                try
                {
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
                }
                catch (Exception ex)
                {
                    Session["Error" + Session.SessionID] = ex;
                    //  Response.Redirect("Error.aspx");
                }
            }
                if(cliente.id!=0)
                {
                isClient = true;
                cliente.apellido = TxtApellidoCl.Text;
                cliente.nombre = TxtNombreCl.Text;
                cliente.direccion = TxtDirCl.Text;
                cliente.ciudad = TxtCiudadCl.Text;
                cliente.cp = TxtCPCl.Text;
                cliente.email = TxtMailCl.Text;
                cliente.fechaRegistro = DateTime.Now;

                TxtDniCl.Enabled = false; //DESHABILITO LA EDICION DEL COMBOTEXT DNI
            }

        }
        protected void BtnAplicarCanje_Click(object sender, EventArgs e)
        {
            // Producto producto;
            Voucher voucher = new Voucher();
            NCliente negocioCliente = new NCliente();
            NProducto negocioProducto = new NProducto();
            NVoucher negocioVoucher = new NVoucher();

            if (!ingreso)
            {
                try
                {
                    int idProducto = Convert.ToInt32(Session["idProducto" + Session.SessionID]);
                    String codVoucher = (String)Session["NumeroVoucher" + Session.SessionID];
                    
                     //producto = negocioProducto.elegirProducto(idProducto);
                    //voucher = negocioVoucher.obtenerVoucher(codVoucher);

                    if (isClient)
                    {
                        negocioCliente.actualizarCliente(cliente);
                        voucher= negocioVoucher.obtenerVoucher(codVoucher);
                        voucher.cliente = cliente;
                        voucher.producto = negocioProducto.elegirProducto(idProducto);
                        voucher.codigoVoucher = codVoucher;
                        voucher.estado = true;
                        voucher.fechaRegistro = DateTime.Now;
                        negocioVoucher.canjearVoucher(voucher);
                    }
                    else
                    {
                        cliente.apellido = TxtApellidoCl.Text;
                        cliente.nombre = TxtNombreCl.Text;
                        cliente.direccion = TxtDirCl.Text;
                        cliente.ciudad = TxtCiudadCl.Text;
                        cliente.cp = TxtCPCl.Text;
                        cliente.email = TxtMailCl.Text;
                        cliente.fechaRegistro = DateTime.Now;

                        negocioCliente.altaCliente(cliente);
                        // voucher.id = negocioVoucher.obtenerVoucher(voucher.codigoVoucher).id;
                        voucher.cliente = cliente;
                        voucher.producto = negocioProducto.elegirProducto(idProducto);
                        // voucher.producto = negocioProducto.elegirProducto(producto.id);
                        voucher.codigoVoucher = codVoucher;
                        voucher.estado = true;
                        voucher.fechaRegistro = DateTime.Now;
                        negocioVoucher.canjearVoucher(voucher);
                        isClient = true;
                    }

                    ingreso = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }
    }
}