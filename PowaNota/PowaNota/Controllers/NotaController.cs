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
            ViewBag.LoginUsuario =usuario;
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

                GenericDTO dtoTopico = JsonConvert.DeserializeObject<GenericDTO>(jsonRecebido);
                dtoTopico.payload = ((JArray)dtoTopico.payload).ToObject<List<Topico>>();

                jsonRecebido = WebService.downloadJson("/AtributosNotas/recuperarTipo");
                GenericDTO dtoTipo = JsonConvert.DeserializeObject<GenericDTO>(jsonRecebido);
                dtoTipo.payload = ((JArray)dtoTipo.payload).ToObject<List<Tipo>>();

                if (dtoTopico.operacaoSucedida && dtoTipo.operacaoSucedida)
                {
                    listaTopico = (List<Topico>)dtoTopico.payload;
                    listaTipo = (List<Tipo>)dtoTipo.payload;
                }
                else
                {
                    Response.Write(dtoTopico.mensagemErro);
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
                    titulo = collection["Titulo"],
                };

                foreach (Tipo t in listaTipo)
                {
                    if(t.id == int.Parse(collection["tipo"]))
                    {
                        nota.tipo = t;
                    }
                }
                nota.textos = new List<Texto>();
                nota.textos.Add(new Texto
                {
                    conteudo = collection["Textos"]
                });

                string topicosStr = collection["topicos"];
                string[] listTopicoStr = topicosStr.Split(',');
                nota.topicos = new List<Topico>();
                
                foreach(Topico t in listaTopico) {
                    foreach(string topico in listTopicoStr) {
                        if (t.id.Equals(int.Parse(topico)))
                            nota.topicos.Add(t);
                        }
                };

                string jsonEnvio = JsonConvert.SerializeObject(nota);

                WebService.uploadJson("/Nota/criar", jsonEnvio);

                Response.Write(jsonEnvio);

                return RedirectToAction("Index", "Nota");
            }

            catch(Exception e)
            {
                Response.Write(e.Message);
            }
            return RedirectToAction("Index","Nota");
        }
    }
}