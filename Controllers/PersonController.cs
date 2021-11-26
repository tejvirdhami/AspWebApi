//We need this library to focus to work with assyncronus programming
using System.Threading.Tasks;

//For accessing datacontext which gives us access to CRUD of our Person Model
using api.Data;

//Responsible by the routes creation
using Microsoft.AspNetCore.Mvc;

//
using Microsoft.EntityFrameworkCore;

using api.Models;

namespace api.Controllers
{
    [Controller]
    [Route("[controller]")]

    public class PersonController : ControllerBase
    {

        private DataContext dc;

        public PersonController(DataContext context)
        {
            this.dc = context;
        }


        [HttpPost("api")]
        public async Task<ActionResult> register([FromBody] Person p )
        {
            //prepare to register data
            dc.person.Add(p);
            await dc.SaveChangesAsync();
            return Created("Person Object", p);
        }



        [HttpGet("api")]
        public async Task<ActionResult> list()
        {
            var data = await dc.person.ToListAsync();

            //return OK means this func will only list/read

            return Ok(data);
        }



        [HttpGet("api/{id}")]
        public Person search(int id)
        {
            Person p = dc.person.Find(id);

            return p;
        }





        [HttpGet("hello")]
        public string hello()
        {
            return "I need Vacations!";
        }


        
    }
}