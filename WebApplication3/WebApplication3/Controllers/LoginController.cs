using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Data.UserDbContext context;
        private object a;

        public LoginController(Data.UserDbContext userDbContext)
        {
            context = userDbContext;
        }
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var userdetails = context.users.AsQueryable();
            return Ok(userdetails);
        }
        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] Models.User userObj)
        {
            if (userObj == null)
            {
                return BadRequest();
            }
            else
            {
                context.users.Add(userObj);
                context.SaveChanges();
                return Ok(new
                {
                    Message = "User Added Successfully",
                });

            }
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] Models.User userObj)
        {

            if (userObj == null)
            {
                return BadRequest();
            }
            else
            {
                var user = context.users.Where(a =>
               a.firstname == userObj.firstname
               && a.pwd == userObj.pwd).FirstOrDefault();
                if (user != null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Logged in Successfully",
                        UserData = userObj.username
                    });
                }
                else
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        Message = "User Not Found"
                    });
                }


            }
        }
    }
}
