using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
    class Pasta
    {
        private int id;
        private int idUsuario;
        private int idPastaPai;
        private string nome;
        private DateTime data;

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

        public int IdUsuario
        {
            get
            {
                return IdUsuario;
            }
            set
            {
                this.idUsuario = value;
            }
        }

        public int IdPastaPai
        {
            get
            {
                return idPastaPai;
            }

            set
            {
                this.idPastaPai = value;
            }
        }

        public string Nome
        {
            get
            {
                return Nome;
            }

            set
            {
                this.nome = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                this.data = value;
            }
        }
    }
}
