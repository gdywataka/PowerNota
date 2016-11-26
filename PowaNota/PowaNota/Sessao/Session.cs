using Nota1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Sessao
{
    class Session
    {
        public Session()
        {
            usuarioLogado = new Usuario
            {

            };
        }

        public Usuario usuarioLogado;

        public bool logado = false;
    }
}
