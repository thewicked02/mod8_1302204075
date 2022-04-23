using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204126.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        private static readonly string[] Titles = new[]
                {
            "The Matrix", " Goodfellas", " Interstellar"
        };

        private static readonly string[] Directors = new[]
                {
            " Lana Wachowski", "Martin Scorsese", "Christopher Nolan"
        };

        private static readonly string[] Descriptions = new[]
                {
            "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.", "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival."
        };

        // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, 3).Select(index => new Movie
            {
                Title = Titles[index],
                Director = Directors[index],
                Stars = new List<string> { "" },
                Description = Descriptions[index]
            })
            .ToArray();
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private readonly ILogger<Movies> _logger;

        public Movies(ILogger<Movies> logger)
        {
            _logger = logger;
        }
    }
}