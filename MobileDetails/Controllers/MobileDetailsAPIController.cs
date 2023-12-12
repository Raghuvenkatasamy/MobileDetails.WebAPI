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
        IMobileDetailsRepository _mDtl;
        public MobileDetailsAPIController()
        {
            _mDtl = new MobileDetailsRepository();
        }

        // GET: api/<MobileDetailsAPIController>
        [HttpGet]
        public IEnumerable<MobileDetail> Get()
        {
            return _mDtl.ReadSP();
        }

        // GET api/<MobileDetailsAPIController>/5
        [HttpGet("{id}")]
        public MobileDetail Get(int id)
        {
            return _mDtl.ReadbynumberSP(id);
        }

        // POST api/<MobileDetailsAPIController>
        [HttpPost]
        public void Post([FromBody] MobileDetail value)
        {
               _mDtl.InsertSP(value);
        }

        // PUT api/<MobileDetailsAPIController>/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MobileDetail value)
        {
            _mDtl.UpdateSP(id,value);
        }

        // DELETE api/<MobileDetailsAPIController>/5

        /// <summary>
        ///  Thi sis used to delete ther product using its ID value 
        /// </summary>
        /// <param name="id"> Id of the product</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mDtl.DeleteRecordSP(id);
        }
    }
}
