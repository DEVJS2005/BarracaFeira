using BarracaDeFeira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarracaDeFeira.Controllers
{
    public class PessoaController : Controller
    {
        BarracaFeiraEntities bd = new BarracaFeiraEntities();
        // GET: Pessoa
        public ActionResult ListaPessoa()
        {
            return View(bd.Pessoa.ToList());
        }

        public ActionResult CadastroPessoa()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CadastroPessoa(string nome, string cpf, string senha)
        {
            Pessoa p = new Pessoa();
            p.nome = nome;
            p.cpf = cpf;
            p.senha = senha;
            p.idSetor = 1;

            bd.Pessoa.Add(p);
            bd.SaveChanges();

            return View();
        }
    }
}