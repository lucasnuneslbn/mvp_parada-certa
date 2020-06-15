using ParadaCerta_API.Models;
using ParadaCerta_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParadaCerta_API.Controllers
{
    public class LoginController : ApiController
    {
        [ActionName("Login")]
        [HttpPost]
        public string Login(string login_infos)
        {
            var dados = login_infos.Replace("{", "").Split(',');

            var auth = new Autenticacao();
            return auth.ValidarCredencial(new Credencial() { Senha = dados[0], Usuario = dados[1] }, dados[2]);
            
        }

        [ActionName("Autenticar")]
        [HttpGet]
        public string Autenticar()
        {
            return "teste";
        }
    }
}
