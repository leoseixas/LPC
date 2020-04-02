using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContaDomain.Entities;
using ContaRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private IContaRepository repository;
        private IImovelRepository repositoryImovel;
        public ContaController(IContaRepository repository, IImovelRepository repositoryImovel)
        {
            this.repository = repository;
            this.repositoryImovel = repositoryImovel;
        }
        // GET api/values   
        [HttpGet]
        public ActionResult<IEnumerable<ContaLuz>> Get()
        {
            var conta = repository.Getall();
            return Ok(new{conta});
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ContaLuz> Get(int id)
        {
            var obj = repository.GetById(id);
            return Ok(new{obj});
        }

        // POST api/values
        [HttpPost] 
        public ActionResult Post([FromBody] ContaLuz conta)
        {
            var imovel = repositoryImovel.GetById(conta.idImovel);
            if(imovel != null)
                conta.imovel = imovel;
            
            repository.Create(conta);
            return Ok(new {conta});
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ContaLuz conta)
        {
            var imovel  = repositoryImovel.GetById(conta.idImovel);
            if(imovel != null)
                conta.imovel = imovel;
            
            repository.Update(conta);
            return Ok(new {conta});
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(new {msg = "OK"});
        }
    }
}
