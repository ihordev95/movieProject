using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Team3_Project.Controllers
{
    public class ListsController : ApiController
    {
        // GET api/<controller>
        public object Get()
        {
            return NotFound();
        }

        // GET api/<controller>/5
        public object Get(int id)
        {
            Databases.memdixyp_film.list list = Databases.memdixyp_film.list.get_list_by_id(id);
            if (list.identifier.value == 0 || list.hidden.value == true)
            {
                return NotFound(); // The list doesn't exist or is hidden, so a not found response is given
            }
            return list;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
