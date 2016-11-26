using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
    public class Tipo
    {
        private int id;
        private string nome;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                this.id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }

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
