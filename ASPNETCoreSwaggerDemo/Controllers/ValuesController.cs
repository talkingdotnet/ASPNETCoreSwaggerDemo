using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreSwaggerDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// Get API Values.
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Get API values by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">Type of Value</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id, ValueType type)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Post API Value
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        //[HttpPost]
        //[Route("upload")]
        //public void PostFile(IFormFile uploadedFile)
        //{
        //    //TODO: Save file
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE api/values/5
        /// <summary>
        /// Delete API Value
        /// </summary>
        /// <remarks>This API will delete the values.</remarks>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public enum ValueType
        {
            Number,
            Text
        }
    }
}
