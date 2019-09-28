using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Cliente
    {
        public int id { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string cp { get; set; }
        public DateTime fechaRegistro { get; set; }

        public Cliente() { }

        public Cliente(int id,int dni,string nom,string ape,string email,string dir,string ciu,string cp,DateTime fRegistro)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nom;
            this.apellido = ape;
            this.email = email;
            this.direccion = dir;
            this.ciudad = ciu;
            this.cp = cp;
            this.fechaRegistro = fRegistro;
        }

    }
}
