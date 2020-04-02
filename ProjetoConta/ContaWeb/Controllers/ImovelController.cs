using ContaDomain.Entities;
using ContaRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContaWeb.Controllers
{
    public class ImovelController : Controller
    {
        private IImovelRepository repositoryImovel;
        
        public ImovelController(IImovelRepository repositoryImovel)
        {
            this.repositoryImovel = repositoryImovel;
        }
        public IActionResult Index()
        {
            var imoveis = repositoryImovel.Getall();
            return View(imoveis);
        }

        public IActionResult CreateImovel()
        {
            return View();
        }
            
        [HttpPost]
        public IActionResult CreateImovel(Imovel imovel)
        {
            repositoryImovel.Create(imovel);
             return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var imovel = repositoryImovel.GetById(id);
            return View(imovel);
        }

        [HttpPost]
        public IActionResult Edit(Imovel imovel)
        {
           
            repositoryImovel.Update(imovel);
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            repositoryImovel.Delete(id);
            return RedirectToAction("Index");
        }

    }
}