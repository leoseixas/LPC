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
    public class ImovelController : ControllerBase
    {
        private IImovelRepository imovelRepository;
        public ImovelController (IImovelRepository imovelRepository)
        {
            this.imovelRepository = imovelRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Imovel>> Get()
        {   
            return Ok(new{obj = imovelRepository.Getall()});
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Imovel> Get(int id)
        {
            return Ok(new{obj = imovelRepository.GetById(id)});
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Imovel imovel)
        {
            imovelRepository.Create(imovel);
            return Ok(new{obj = imovel});
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Imovel imovel)
        {
            imovelRepository.Update(imovel);
            return Ok(new{obj = imovel});
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            imovelRepository.Delete(id);
            return Ok(new{obj = new{}});
        }
    }
}
