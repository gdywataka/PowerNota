using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
     public class Texto
    {
        private int id;
        private string conteudo;
        private int idTextoPai;


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

        public int IdTextoPai
        {
            get
            {
                return idTextoPai;
            }

            set
            {
                this.idTextoPai = value;
            }
        }

        public string Conteudo
        {
            get
            {
                return conteudo;
            }

            set
            {
                this.conteudo = value;
            }

        }

    }
}
