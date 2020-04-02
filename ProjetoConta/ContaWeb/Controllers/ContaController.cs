using ContaDomain.Entities;
using ContaRepository.Interfaces;
using ContaRepository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ContaWeb.Controllers
{
    public class ContaController : Controller
    {
        private IContaRepository repositoryConta;

        private IImovelRepository repositoryImovel;

        public ContaController(IContaRepository repositoryConta, IImovelRepository repositoryImovel)
        {
            this.repositoryConta = repositoryConta;
            this.repositoryImovel = repositoryImovel;
        }
        public IActionResult Index()
        {        
            var contas = repositoryConta.Getall();
            ViewBag.maiorConsumo = repositoryConta.GetMaiorConsumo();
            ViewBag.menorConsumo = repositoryConta.GetMenorConsumo();
            return View(contas);
        }

        public IActionResult Imovel()
        {
            var imoveis = repositoryImovel.Getall();
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.ImoveisConta = repositoryImovel.Getall();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContaLuz conta)
        {
            conta.imovel = repositoryImovel.GetById(conta.imovel.id);
            repositoryConta.Create(conta);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.ImoveisConta = repositoryImovel.Getall();
            var conta = repositoryConta.GetById(id);
            return View(conta);
        }

        [HttpPost]
        public IActionResult Edit(ContaLuz conta)
        {
            conta.imovel = repositoryImovel.GetById(conta.imovel.id);
            repositoryConta.Update(conta);
            return RedirectToAction("Index");
        }   

        public IActionResult Delete(int id)
        {
            repositoryConta.Delete(id);
            return RedirectToAction("Index");
        }
    }
}