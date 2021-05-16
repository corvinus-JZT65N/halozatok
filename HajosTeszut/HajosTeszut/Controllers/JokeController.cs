using HajosTeszut.JokeModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajosTeszut.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        // GET api/jokes/5
        [HttpGet("{id}")]
        public Joke Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var keresettVicc = (from x in context.Jokes
                               where x.JokeSk == id
                               select x).FirstOrDefault();
            return keresettVicc;
        }

        // POST api/jokes
        [HttpPost]
        public void Post([FromBody] Joke újVicc)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            context.Jokes.Add(újVicc);
            context.SaveChanges();
        }

        // DELETE api/jokes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var törlendőVicc = (from x in context.Jokes
                                where x.JokeSk == id
                                select x).FirstOrDefault();
            context.Remove(törlendőVicc);
            context.SaveChanges();
        }
    }
}