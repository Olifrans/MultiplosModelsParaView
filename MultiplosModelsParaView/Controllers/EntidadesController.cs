using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiplosModelsParaView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplosModelsParaView.Controllers
{
    public class EntidadesController : Controller
    {

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