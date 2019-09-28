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
            //Recorrer lista vouchers y si existe devuelve
            return existe;
        }

       
        public bool estadoVoucher(string codVoucher)
        {
            bool utilizado = false;

            //Verifico el estado del voucher, si se utilizo devuelvo true
            return utilizado;
        }

        //Cambia el estado del vocher a false
        public void canjearVoucher(Voucher voucher)
        {
            //CAMBIO EL ESTADO DEL VOUCHER SI EL CLIENTE REALIZA EL CAMBIO
        }

        public void listarVouchers() {
            //LISTA LOS VOUCHERS
        }
        
        

    }
}
