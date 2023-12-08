using Microsoft.AspNetCore.Mvc;
using WebApiSignalR.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiSignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        public OfferController()
        {
            
        }
        // GET: api/<OfferController>
        [HttpGet]
        public double Get()
        {
            return FileHelper.Read();
        }

        // GET: api/<OfferController>
        [HttpGet("/Increase")]
        public void Increase(double data)
        {
            var result=FileHelper.Read()+data;
            FileHelper.Write(result);   
        }

        // GET api/<OfferController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OfferController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OfferController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OfferController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
