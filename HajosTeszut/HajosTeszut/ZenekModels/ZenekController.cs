using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszut.ZenekModels
{
    [Route("api/zenek")]
    [ApiController]
    public class ZenekController : ControllerBase
    {
        // api/zenek/count
        [HttpGet]
        [Route("count")]
        public int Szamol()
        {
            jzt65nAdatbazisContext context = new jzt65nAdatbazisContext();
            int szamokSzama = context.HálóBeoKedvencZeneszámoks.ToList().Count;
            return szamokSzama;
        }


        // GET: api/zenek
        [HttpGet]
        public IEnumerable<HálóBeoKedvencZeneszámok> Get()
        {
            jzt65nAdatbazisContext context = new jzt65nAdatbazisContext();
            return context.HálóBeoKedvencZeneszámoks.ToList();
        }

        // GET api/zenek/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            jzt65nAdatbazisContext context = new jzt65nAdatbazisContext();
            var keresettSzám = (from x in context.HálóBeoKedvencZeneszámoks
                                where x.Id == id
                                select x.Cím).FirstOrDefault();
            return keresettSzám;
        }

        // POST api/zenek
        [HttpPost]
        public void Post([FromBody] HálóBeoKedvencZeneszámok újSzám)
        {
            jzt65nAdatbazisContext context = new jzt65nAdatbazisContext();
            context.HálóBeoKedvencZeneszámoks.Add(újSzám);
            context.SaveChanges();


            /*List<string> tmp = new List<string>();
            tmp.Add(előadó);
            tmp.Add(cím);

            List<HálóBeoKedvencZeneszámok> átalakított = new List<HálóBeoKedvencZeneszámok>();

            átalakított = tmp.Cast(HálóBeoKedvencZeneszámok);

            context.HálóBeoKedvencZeneszámoks.Add((HálóBeoKedvencZeneszámok)tmp);*/
        }

        // PUT api/<ZenekController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/zenek/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            jzt65nAdatbazisContext context = new jzt65nAdatbazisContext();
            var törlendőSzám = (from x in context.HálóBeoKedvencZeneszámoks
                                where x.Id == id
                                select x).FirstOrDefault();
            context.Remove(törlendőSzám);
            context.SaveChanges();
        }
    }
}
