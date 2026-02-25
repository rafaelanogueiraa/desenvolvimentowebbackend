using EXEMPLO1_MVC.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
