using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataModel;
using KnowledgeShare.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DiagnosticAdapter.Internal;

namespace KnowledgeShare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IPodDbManager PodDbManager { get; set; }

        public ValuesController(IPodDbManager podDbManager)
        {
            PodDbManager = podDbManager;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var pod = PodDbManager.GetPod();
            return Ok(pod);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] ApiPod value)
        {
            try
            {
                PodDbManager.AddPod(PodMapper.PodApi2Pod(value));
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] ApiPod value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
