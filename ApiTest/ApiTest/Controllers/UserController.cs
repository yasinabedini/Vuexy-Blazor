using ApiTest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public List<User> Users { get; set; } = new List<User>
        {
            new User(1,"Yasin Abedini","09106966244"),
            new User(2,"user test 1","09106966244"),
            new User(3,"user test 2","09130258974"),
            new User(4,"user test 3","09134569874"),
            new User(5,"user test 4","09132587496"),
        };

        
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Users;
        }
        
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return Users.FirstOrDefault(t=>t.Id==id);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            return Ok("User Cerated SuccessFully...");
        }
        
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]User user)
        {
            return Ok("User Updated SuccessFully...");
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("User Deleted SuccessFully...");
        }
    }
}
