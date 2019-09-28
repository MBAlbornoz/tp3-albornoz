using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Producto
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string urlImagen { get; set; }

        public Producto() {}

        public Producto(int id, string titulo,string desc, string urlI)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = desc;
            this.urlImagen = urlI;
        }
      
    }
}
