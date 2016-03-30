using AutoMapper;
using lojavirtualFsmsousa.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace lojavirtualFsmsousa.Controllers
{
    public class ProdutoController : Controller
    {
        
        public ActionResult Lista()
        {
            var produtos = new Produtos();

            var ListaProdutos = produtos.Lista();

            var lista = Mapper.Map<IList<ProdutoViewModel>>(ListaProdutos);
          
            return View(lista);
        }
    }
}