using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
    class Pasta
    {
        public int id;
        private Usuario usuario;
        public List<Nota> notas;
        public Int32? pastaPai;
        public string nome;
        public DateTime data =DateTime.Now.Date;

        
    }
}
