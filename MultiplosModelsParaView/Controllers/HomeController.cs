using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiplosModelsParaView.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplosModelsParaView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}



        // GET: EntidadesController
        public ActionResult Index()
        {
            var model = new HomeIndex();

            model.Produtos = ObterProdutos();
            model.Marcas = ObterMarcas();
            model.Categorias = ObterCategorias();

            return View(model);
        }


        Produtos ObterProdutos()
        {
            return new Produtos
            {
                Id = 1,
                Nome = "Bola de Fut"
            };
        }

        IEnumerable<Marcas> ObterMarcas()
        {
            for (int i = 1; i < 11; i++)
            {
                yield return new Marcas
                {
                    Id = 1,
                    Nome = "Bola de Fut"
                };
            }
        }



        IEnumerable<Categorias> ObterCategorias()
        {
            for (int i = 1; i < 11; i++)
            {
                yield return new Categorias
                {
                    Id = 1,
                    Nome = "Bola de Fut"
                };
            }
        }


    }
}