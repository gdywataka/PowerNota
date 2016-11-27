using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
    public class Nota
    {
        public int id;
        public Tipo tipo = new Tipo();
        public string titulo;
        public DateTime data = DateTime.Now.Date;
        public List<Texto> textos =  new  List<Texto>();
        public List<Topico> topicos= new  List<Topico>();

       


    }
}
