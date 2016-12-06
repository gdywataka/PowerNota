using Newtonsoft.Json;
using Nota1.DTO;
using Nota1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using sessao = Nota1.Sessao.Session;
using Nota1.Models;
using System.Text.RegularExpressions;
using PowaNota.Util;

namespace PowaNota.Controllers
{
    public class PastaController : Controller
    {

        public ActionResult List()
        {
            if (sessao.usuarioLogado != null)
            {
                var jsonPastas = WebService.downloadJson("/Pasta/recuperarPorIdUsuario/" + sessao.usuarioLogado.id.ToString());
                GenericDTO dto = JsonConvert.DeserializeObject<GenericDTO>(jsonPastas);
                dto.payload = ((JArray)dto.payload).ToObject<List<Pasta>>();
                ViewBag.json_pastas = PastaJsonConverter.pastaConverter(((List<Pasta>)dto.payload));
            }

            ViewBag.tela = 0;
            return View();
        }
    }
}
