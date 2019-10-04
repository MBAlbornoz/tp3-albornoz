using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Voucher
    {
        public Cliente cliente;
        public Producto producto;
        public int id { get; set; }
        public string codigoVoucher { get; set; }
        public bool estado { get; set; }
        public DateTime fechaRegistro { get; set; }
        
        public Voucher() {}

        public Voucher(Cliente cl, Producto pr, string cod,bool estado, DateTime fReg)
        {
            this.cliente = cl;
            this.producto = pr;
            this.codigoVoucher = cod;
            this.estado = estado;
            this.fechaRegistro = fReg;
        }
    }
}
