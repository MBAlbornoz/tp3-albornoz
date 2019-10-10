using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class NVoucher
    {
        public Boolean existeVoucher(string codVoucher) {
            Boolean existe = false;
            Voucher aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "select Id,CodigoVoucher,Estado from Vouchers";
                datos.seterQuery(query);
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Voucher();
                    aux.codigoVoucher = (String)datos.SqlDataReader["CodigoVoucher"].ToString();
                    if (aux.codigoVoucher == codVoucher)
                    {
                        existe = true;
                      
                    }
                }
                datos.CerrarConexionDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return existe;
        }

       
        public bool estadoVoucher(string codVoucher)
        {
            bool utilizado = false;
            Voucher aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "select Id,CodigoVoucher,Estado from Vouchers";
                datos.seterQuery(query);
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Voucher();
                    aux.codigoVoucher = (String)datos.SqlDataReader["CodigoVoucher"].ToString();

                    if (aux.codigoVoucher == codVoucher)
                    {
                        aux.estado = (bool)datos.SqlDataReader["Estado"];
                        if(aux.estado==true)
                        {
                            utilizado = true;
                   
                        }
                    }
                }
                datos.CerrarConexionDB();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return utilizado;
        }

        //Cambia el estado del vocher a false
        public void canjearVoucher(Voucher voucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterQuery("UPDATE Vouchers SET Estado = 1, IdCliente=@IdCliente, IdProducto = @IdProducto, FechaRegistro = GETDATE() WHERE Id = @Id AND CodigoVoucher = @CodigoVoucher");
                datos.agregarParametro("@IdCliente", voucher.cliente.id);
                datos.agregarParametro("@IdProducto", voucher.producto.id);
                datos.agregarParametro("@Id", voucher.id);
                datos.agregarParametro("@CodigoVoucher", voucher.codigoVoucher);

                datos.ejecutarAccion();
                datos.CerrarConexionDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Voucher> listarVouchers() {
            //LISTA LOS VOUCHERS
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "select Id,CodigoVoucher,Estado from Vouchers";
                datos.seterQuery(query);
                List<Voucher> listarVouchers = new List<Voucher>();
                Voucher aux;
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Voucher();
                    aux.id = (int)datos.SqlDataReader["Id"];
                    aux.codigoVoucher = (string)datos.SqlDataReader["CodigoVoucher"];
                    aux.estado = (bool)datos.SqlDataReader["Estado"];

                    //Me faltan cliente y producto
                    listarVouchers.Add(aux);
                }
                datos.CerrarConexionDB();
                return listarVouchers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
