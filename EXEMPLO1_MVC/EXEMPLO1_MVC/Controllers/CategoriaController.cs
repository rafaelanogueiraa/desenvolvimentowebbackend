using EXEMPLO1_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace EXEMPLO1_MVC.Controllers
{
    public class CategoriaController : Controller
    {
        //cria uma pasta de Categoria 
        public static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria()
            {
                CategoriaId = 1, 
                Nome = "Vestuario"
            },
             new Categoria()
            {
                CategoriaId = 2,
                Nome = "Eletrônicos"
            },
              new Categoria()
            {
                CategoriaId = 3,
                Nome = "Utilidades Domésticas"
            },


        };
        public IActionResult Index()
        {
            //gera uma view (exibição HTML)
            // com todas as categorias classificadas por nome (Id)
            return View(categorias.OrderBy(cat => cat.CategoriaId));
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            categorias.Add(categoria); // adiciona a nova categoria á lista busca o último id e incrementa 1 para a nova categoria 
            categoria.CategoriaId = categorias.Select(categoria => categoria.CategoriaId).Max() + 1;
            return RedirectToAction("Index");

        }

        public IActionResult Details (int id)
        {
            // retorna uma view com os dados da categoria cujo id foi passado como parâmetro 
            return View(categorias.Where(cat => cat.CategoriaId == id).First());
        }
    }
}
