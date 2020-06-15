using Newtonsoft.Json;
using ParadaCerta_API.DataLayer;
using ParadaCerta_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace ParadaCerta_API.Services
{
    public class Autenticacao
    {
        public string ValidarCredencial(Credencial credencial, string session_number)
        {
            try 
            {
                Dictionary<string, string> retorno = new Dictionary<string, string>();
                retorno.Add("session", session_number);

                using (ParadaCertaContexto con = new ParadaCertaContexto())
                {
                   var verificado = con.Credencial.Where(x => x.Usuario == credencial.Usuario && x.Senha == credencial.Senha).Any();
                    if (verificado)
                    {
                        retorno.Add("type", "success");
                    }
                    else
                    {
                        retorno.Add("type", "fail");
                        retorno.Add("message", "Usuário ou Senha inválidos");
                    }

                    RegistrarLogin(credencial, retorno);
                }
                var js = new RetornoJSON();
                return js.RetornarJson(retorno);

            }
            catch(Exception err) { return err.Message; }
            
        }

        public void RegistrarLogin(Credencial credencial, Dictionary<string, string> retorno)
        {
            var sucesso = false;
            if (retorno["type"] == "success")
            {
                sucesso = true;
            }
            using (ParadaCertaContexto con = new ParadaCertaContexto())
            {
                con.RegistroLogin.Add(new RegistroLogin()
                {
                    Usuario = credencial.Usuario,
                    Senha = credencial.Senha,
                    DataLogin = DateTime.Now,
                    Session = retorno["session"],
                    Successful = sucesso
                });

                con.SaveChanges();
            }
        }
    }
}