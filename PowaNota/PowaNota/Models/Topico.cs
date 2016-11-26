using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
     public class Topico
    {
        private int Id;
        private string Nome;

        public int id
        {
            get
            {
                return Id;
            }

            set
            {
                this.Id = value;
            }
        }

        public string nome
        {
            get
            {
                return Nome;
            }

            set
            {
                this.Nome = value;
            }
        }
        public List<Topico> ListaTopico()
        {
            return new List<Topico>
            {
            new Topico{id=1,nome="Faculdade"},
            new Topico{id=2,nome ="Jogos" }
            };

        }
    }
}
