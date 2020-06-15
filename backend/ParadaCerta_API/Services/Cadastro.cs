using ParadaCerta_API.DataLayer;
using ParadaCerta_API.Migrations;
using ParadaCerta_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.Services
{
    public class Cadastro
    {
        public string CadastrarUsuario(Pessoas usuario, Credencial credencial, string session_id)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            retorno.Add("session", session_id);

            using (ParadaCertaContexto con = new ParadaCertaContexto())
            {

                var validaEmail = con.Pessoa.Where(x => x.Email == usuario.Email).Any();
                if(!validaEmail)
                {
                    var validaPessoa = con.Credencial.Where(x => x.Usuario == credencial.Usuario).Any();
                    if (!validaPessoa) 
                    {
                        con.Credencial.Add(credencial);
                        con.SaveChanges();

                        usuario.Id_Credencial =  con.Credencial.Where(x => x.Usuario == credencial.Usuario).Select(x => x.Id).FirstOrDefault();
                        
                        con.Pessoa.Add(usuario);
                        con.SaveChanges();
                        
                        retorno.Add("type", "success");
                        
                    }
                    else
                    {
                        retorno.Add("type", "fail");
                        retorno.Add("message", "Nome de usuário indisponível");
                    }
                    
                }
                else
                {
                    retorno.Add("type", "fail");
                    retorno.Add("message", "Email já cadastrado");
                }

            }
            
            var js = new RetornoJSON();
            return js.RetornarJson(retorno);
          
        }

        public string CadastroPerceiro(Pessoas pessoa, Credencial credencial, Parceiros parceiro, string session_id)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            retorno.Add("session", session_id);

            using (ParadaCertaContexto con = new ParadaCertaContexto())
            {
                var validaEmail = con.Pessoa.Where(x => x.Email == pessoa.Email).Any();
                if (!validaEmail)
                {
                    var validaPessoa = con.Credencial.Where(x => x.Usuario == credencial.Usuario).Any();
                    if (!validaPessoa)
                    {
                        con.Credencial.Add(credencial);
                        con.SaveChanges();

                        var id_credencial = con.Credencial.Where(x => x.Usuario == credencial.Usuario).Select(x => x.Id).FirstOrDefault();
                        pessoa.Id_Credencial = id_credencial;
                        parceiro.Id_Credencial = id_credencial;

                        con.Pessoa.Add(pessoa);
                        con.SaveChanges();

                        parceiro.Id_Pessoa = con.Pessoa.Where(x => x.Id_Credencial == id_credencial).Select(x => x.Id).FirstOrDefault();
                        con.Parceiros.Add(parceiro);
                        con.SaveChanges();


                        retorno.Add("type", "success");
                    }
                    else
                    {
                        retorno.Add("type", "fail");
                        retorno.Add("message", "Nome de usuário indisponível");
                    }

                }
                else
                {
                    retorno.Add("type", "fail");
                    retorno.Add("message", "Email já cadastrado");
                }

            }

            var js = new RetornoJSON();
            return js.RetornarJson(retorno);

        }
    }
}