﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nota1.Models;
using Newtonsoft.Json;
using System.Net;
using Nota1.Util;

namespace Nota1.Controllers
{
    public class TopicoController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Topico topico = new Topico
                {
                    nome = collection["Nome"]
                };

                string jsonEnvio = JsonConvert.SerializeObject(topico);

                WebService.uploadJson("/AtributosNotas/criarTopico", jsonEnvio);

                return View();
            }

            catch (Exception e)
            {
                Response.Write(e.Message);
                return View();

            }

        }
    }
}