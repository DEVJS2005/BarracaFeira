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
        BdBarracaDeFeiraEntities bd = new BdBarracaDeFeiraEntities();
        // GET: Pessoa
        public ActionResult ListaPessoa()
        {
            return View(bd.Pessoa2.ToList());
        }

        public ActionResult CadastroPessoa()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CadastroPessoa(string nome, long cpf, string senha)
        {
            Pessoa2 p = new Pessoa2();
            p.nome = nome;
            p.cpf = cpf;
            p.senha = senha;
            p.idSetor = 1;

            bd.Pessoa2.Add(p);
            bd.SaveChanges();

            return View();
        }
    }
}