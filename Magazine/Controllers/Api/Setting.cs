using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Magazine.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Setting : ControllerBase
    {
        ISetLinks setting;
        public Setting(ISetLinks setting)
        {

            this.setting = setting;

        }
        // GET: api/<Setting>
        [HttpGet]
        public TbSetting Get()
        {
            
            return setting.Get();
        }

        // GET api/<Setting>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Setting>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Setting>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Setting>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
