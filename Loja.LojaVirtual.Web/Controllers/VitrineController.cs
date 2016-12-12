﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loja.LojaVirtual.Dominio.Repositorio;

namespace Loja.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;

        public ActionResult ListaProdutos(int pagina =1)
        {
            _repositorio = new ProdutosRepositorio();
            var Produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);
                
            
            return View(Produtos);
        }
    }
}