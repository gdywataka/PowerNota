using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
    public class Tipo
    {
        public   int id;
        public string nome;

     

        public List<Tipo>ListaTipo()
        {
            return new List<Tipo>
            {
            new Tipo{id=1,nome="Nota"},
            new Tipo{id =2,nome ="Lista" }
            };

    }
}
}
