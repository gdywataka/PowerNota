using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nota1.Models;
using Nota1.Sessao;
using Newtonsoft.Json;
using System.Net;
using Nota1.DTO;
using Newtonsoft.Json.Linq;
using Nota1.Util;

namespace Nota1.Controllers
{
    public class NotaController : Controller
    {
        static List<Nota> listaNota = new List<Nota>();
        static List<Topico> listaTopico = new List<Topico>();
        static List<Tipo> listaTipo = new List<Tipo>();
      
        // GET: Nota
        public ActionResult Index()
        {
            Usuario usuario = (Usuario)Session["session"];
            ViewBag.LoginUsuario = usuario.login;
            return View();
        }
        //Metodo de criar 

        public ActionResult Create()
        {
            //Recuperar Lista de Topicos
            //Recuperar Lista de Tipos

            try
            {
                #region WsTopicos

                String jsonRecebido = WebService.downloadJson("/AtributosNotas/recuperarTopico");

                GenericDTO dto = JsonConvert.DeserializeObject<GenericDTO>(jsonRecebido);
                dto.payload = ((JArray)dto.payload).ToObject<List<Topico>>();

                if (dto.operacaoSucedida)
                {
                    listaTopico = (List<Topico>)dto.payload;
                }
                else
                {
                    Response.Write(dto.mensagemErro);
                    return new EmptyResult();
                }
                #endregion

              
            }
            catch (Exception e)
            {
                Response.Write("Erro!:" + e.Message);
                throw;
            }
    

            ViewBag.ListaTipo = listaTipo;
            ViewBag.ListaTopico = listaTopico;
       
            

            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Nota nota = new Nota()
                {
                    Titulo = collection["Titulo"],
                    IdTipo = Convert.ToInt32(collection["IdTipo"])

                };
                nota.Textos = new List<Texto>();
                nota.Textos.Add(new Texto
                { 
                    Conteudo = collection["Textos"]
                });

                nota.Topicos = new List<Topico>();
                nota.Topicos.Add(new Topico
                {
                    nome = collection["Topicos"]
                });

                    string jsonEnvio = JsonConvert.SerializeObject(nota);

                    WebClient webCliente = new WebClient();

                    string jsonRecebido = webCliente.UploadString("http://13.65.36.147/doutorama.backend/pessoas/SalvarLogin", jsonEnvio);

                    Response.Write(jsonRecebido);
            }

            catch(Exception e)
            {
                Response.Write(e.Message);
            }
            return RedirectToAction("Index","Nota");
        }
    }
}