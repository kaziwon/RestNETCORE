using Microsoft.AspNetCore.Mvc;
using RestNETCORE.Model;
using RestNETCORE.Business;

namespace RestNETCORE.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BooksController : ControllerBase
    {


        //private IBookBusiness _bookBusiness;

        //public BooksController(IBookBusiness bookBusiness)
        //{
        //    _bookBusiness = bookBusiness;
        //}
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(_personBusiness.FindAll());
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //var person = _personBusiness.FindById(id);
            //if (person == null) return NotFound();
            //return Ok(person);
            return Ok();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            //if (person == null) return BadRequest();
            //return new ObjectResult(_personBusiness.Create(person));
            return Ok();
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            //if (person == null) return BadRequest();
            //var updatedPerson = _personBusiness.Update(person);
            //if (updatedPerson == null) return NoContent();
            //return new ObjectResult(updatedPerson);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_personBusiness.Delete(id);
            //return NoContent();
            return Ok();
        }
    }
}
