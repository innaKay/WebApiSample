using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    ///<summary>
    ///     People class API
    ///</summary>
    
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        /// <summary>
        /// People controller sample data constructor
        /// </summary>
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName= "Thomas", Id = 1});
            people.Add(new Person { FirstName = "Dan", LastName = "Dame", Id = 2 });
            people.Add(new Person { FirstName = "Liz", LastName = "Louise", Id = 3});
        }
        /// <summary>
        /// Get returns list of type Person
        /// </summary>
        /// <returns></returns>
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }
        /// <summary>
        /// Gets first names only, of type string
        /// </summary>
        /// <returns></returns>
        //additional params for routing
        //[System.Web.Http.Route("api/People/GetFirstNames/{valueId:string}/{age:int}")]
        [System.Web.Http.Route("api/People/GetFirstNames")]
        [System.Web.Http.HttpGet] //Http protocol GET
        public List<string> GetFirstNames()
        {
            List<string> lst = new List<string>();
            foreach (var p in people)
            {
                lst.Add(p.FirstName);
            }
            return lst;
        }
    
        /// <summary>
        /// Gets type person by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/People/5
        public Person Get(int id)
        {
            Person p;
            p = people.Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                Ok("Success!");
                return p;
                
            }
            else
            {
                BadRequest("No such ID found!");
                return null;

            }
           
        }
        /// <summary>
        /// Posts from body person type 
        /// Person type : { Id = int type, FirstName = string type, LastName = string type}
        /// </summary>
        /// <param name="val"></param>
        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }
        /// <summary>
        /// Empty put
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }
        /// <summary>
        /// Empty delete
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
