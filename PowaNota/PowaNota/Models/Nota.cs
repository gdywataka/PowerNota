using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Models
{
    public class Nota
    {
        private int id;
        private int idTipo;
        private string titulo;
        private DateTime data;
        private List<Texto> textos;
        private List<Topico> topicos;

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

        public int IdTipo
        {
            get
            {
                return idTipo;
            }
            set
            {
                this.idTipo = value;
            }
        }
  
        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                this.titulo = value;
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

        public List<Texto>Textos
        {
            get
            {
                return textos;
            }
            set
            {
                this.textos = value;
            }
        }

        public List<Topico> Topicos
        {
            get
            {
                return topicos;
            }
            set
            {
                this.topicos = value;
            }
        }


    }
}
