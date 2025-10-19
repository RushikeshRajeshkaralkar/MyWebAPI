using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class MasterIndexController : ApiController
    {

        static List<string> _masters = new List<string>()
        {
            "Value1","Value2","Value3"
        };
        

        // GET: api/MasterIndex
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MasterIndex/5
        public string Get(int id)
        {
            return "masterIndex";
        }

        // POST: api/MasterIndex
        public void Post([FromBody]string value)
        {
            _masters.Add(value);
        }

        // PUT: api/MasterIndex/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MasterIndex/5
        public void Delete(int id)
        {
        }
    }
}
