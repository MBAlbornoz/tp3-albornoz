using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class NCliente
    {
        public List<Cliente> listarClientes() {
            
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "SELECT Id,DNI,Nombre, Apellido,Email,Direccion,Ciudad,SELECT Id,DNI,Nombre, Apellido,Email,Direccion,Ciudad,CodigoPostal,FechaRegistro FROM Clientes";
                datos.seterQuery(query);
                List<Cliente> listarClientes = new List<Cliente>();
                Cliente aux;
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Cliente();
                    aux.id = (int)datos.SqlDataReader["Id"];
                    aux.dni = (int)datos.SqlDataReader["DNI"];
                    aux.apellido = (String)datos.SqlDataReader["Apellido"].ToString();
                    aux.nombre = (String)datos.SqlDataReader["Nombre"].ToString();
                    aux.email = (String)datos.SqlDataReader["Email"].ToString();
                    aux.direccion = (String)datos.SqlDataReader["Direccion"].ToString();
                    aux.ciudad = (String)datos.SqlDataReader["Ciudad"].ToString();
                    aux.cp = (String)datos.SqlDataReader["CodigoPostal"].ToString();
                    aux.fechaRegistro = (DateTime)datos.SqlDataReader["FechaRegistro"];

                    //Me faltan cliente y producto
                    listarClientes.Add(aux);
                }
                datos.CerrarConexionDB();
                return listarClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente buscarCliente(int dni)
        {
            Cliente datosCliente=new Cliente();
            //Busco el cliente, en caso de encontrarlo, debo devolver el cliente//ESTO LO VOY A USAR CUANDO EL CLIENTE QUIERA REALIZAR EL CANJE DEL VOUCHER
            //EN CASO DE NO EXISTIR DEVUELVE UN REGISTRO NULL
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "SELECT Id,DNI,Nombre, Apellido,Email,Direccion,Ciudad,SELECT Id,DNI,Nombre, Apellido,Email,Direccion,Ciudad,CodigoPostal,FechaRegistro FROM Clientes";
                datos.seterQuery(query);
                Cliente aux;
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Cliente();
                    aux.dni = (int)datos.SqlDataReader["DNI"];
                    if(aux.dni==dni)
                    {
                        aux.id = (int)datos.SqlDataReader["Id"];
                        aux.apellido = (String)datos.SqlDataReader["Apellido"].ToString();
                        aux.nombre = (String)datos.SqlDataReader["Nombre"].ToString();
                        aux.email = (String)datos.SqlDataReader["Email"].ToString();
                        aux.direccion = (String)datos.SqlDataReader["Direccion"].ToString();
                        aux.ciudad = (String)datos.SqlDataReader["Ciudad"].ToString();
                        aux.cp = (String)datos.SqlDataReader["CodigoPostal"].ToString();
                        aux.fechaRegistro = (DateTime)datos.SqlDataReader["FechaRegistro"];

                        datosCliente = aux;

                        datos.CerrarConexionDB();

                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return datosCliente;
        }
        public void altaCliente(Cliente cliente)
        {
            AccesoDatos bDatos = new AccesoDatos();
            try
            {
                string query = "INSERT INTO ARTICULOS VALUES()";

                bDatos.seterQuery(query);
                bDatos.ejecutarAccion();
                bDatos.CerrarConexionDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
