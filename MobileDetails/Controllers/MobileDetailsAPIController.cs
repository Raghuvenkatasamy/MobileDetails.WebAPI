using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobileDetails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileDetailsAPIController : ControllerBase
    {
        IMobileDetailsRepository _MDtl;
        public MobileDetailsAPIController()
        {
            _MDtl = new MobileDetailsRepository();
        }

        // GET: api/<MobileDetailsAPIController>
        [HttpGet]
        public IEnumerable<MobileDetail> Get()
        {
            return _MDtl.ReadSP();
        }

        // GET api/<MobileDetailsAPIController>/5
        [HttpGet("{id}")]
        public MobileDetail Get(int id)
        {
            return _MDtl.ReadbynumberSP(id);
        }

        // POST api/<MobileDetailsAPIController>
        [HttpPost]
        public void Post([FromBody] MobileDetail value)
        {
               _MDtl.InsertSP(value);
        }

        // PUT api/<MobileDetailsAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MobileDetail value)
        {
            _MDtl.UpdateSP(id,value);
        }

        // DELETE api/<MobileDetailsAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _MDtl.DeleteRecordSP(id);
        }
    }
}
