using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class NProducto
    {
        public void listarProductos() { }

        public Producto elegirProducto(int id)
        {
            Producto producto = new Producto();
            //BUSCA EL ID DEL PRODUCTO Y CARGA EL PRODUCTO PARA DEVOLVERLO, 
            //ESTO LO VOY A USAR CUANDO EL CLIENTE SELECCIONE 
            //EL PRODUCTO PARA CARJEAR EL VOUCHER
            return producto;
        }
    }
}
