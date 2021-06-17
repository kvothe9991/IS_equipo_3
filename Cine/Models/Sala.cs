using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Models
{
    public class Sala
    {
        public int SalaID { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
    }
}