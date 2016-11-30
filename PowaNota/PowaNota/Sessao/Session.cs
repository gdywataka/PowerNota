using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nota1.DTO;
using Nota1.Models;
using Nota1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota1.Sessao
{
    public class Session
    {
        public Session()
        {
            
        }

        public static Usuario usuarioLogado;

        public  static bool logado = false;

        public static bool logar(string usuario, string senha, out string erro)
        {
            try
            {
                erro = "";
                var json = WebService.downloadJson("/Usuario/recuperar");
                GenericDTO dto = JsonConvert.DeserializeObject<GenericDTO>(json);
                dto.payload = ((JArray)dto.payload).ToObject<List<Usuario>>();
                foreach (Usuario user in (List<Usuario>)dto.payload)
                {
                    if (user.login.Equals(usuario) && user.senha.Equals(senha))
                    {
                        logado = true;
                        usuarioLogado = user;
                        return logado;
                    }
                    else
                    {
                        erro = "Login ou Senha Inválidos!";
                    }
                }
            }
            catch (Exception e)
            {
                erro = e.Message;
            }
            return false;
        }
    }
}
