using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Models
{
    public class Entrada
    {
        public int EntradaID { get; set; }
        public int SocioID { get; set; }
        public virtual Socio Socio { get; set; }
        public int FilmeID { get; set; }
        public virtual Filme Filme { get; set; }
        public int Calificacion { get; set; }

        public int Precio { get; set; }
        public DateTime HoraCompra { get; set; }
        public DateTime Horario { get; set; }
        public int Sala { get; set; }
        public int Butaca { get; set; }
    }
}
