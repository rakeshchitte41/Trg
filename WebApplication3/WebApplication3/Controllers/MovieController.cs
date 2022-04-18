using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly UserDbContext context;
        public MovieController(UserDbContext userDbContext)
        {
            context = userDbContext;
        }
        [HttpPost("add_Movie")]
        public IActionResult AddMovie([FromBody] Models.Movie movieObj)
        {
            try
            {
                if (movieObj == null)
                {
                    return BadRequest();
                }
                else
                {
                    context.movies.Add(movieObj);
                    context.SaveChanges();
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Movie Added Successfully"

                    });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        [HttpPut("update_movie")]

        public IActionResult UpdateMovie([FromBody] Models.Movie movieObj)
        {
            if(movieObj == null)

            {
                return BadRequest();
            }
            var user = context.movies.AsNoTracking().FirstOrDefault(X => X.Id == movieObj.Id);
            if(user == null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "User Not Found"
                });
            }
            else
            {
                context.Entry(movieObj).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(new
                {
                    StatusCode = 200,  
                    Message = "Movie Updated Successfully"
                });
            }

        }
        [HttpDelete("delete_movie")]
        public IActionResult DeleteMovie(int Id)
        {
            var user = context.movies.Find(Id);
            if (user == null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "User Not Found"
                });
            }
            else
            {
                context.Remove(user);
                context.SaveChanges();
                return Ok(new
                {
                    StatusCode = 200,
                    Message = "Movie Deleted"
                });
            }
        }
        [HttpGet("get_all_movies")]
        public IActionResult GetAllMovies([FromBody] Models.Movie movieObj)
        {
            var movie = context.movies.ToList();
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        MovieDetails = movie
                    });
                }
            }


     [HttpGet("get_movie")]
     public IActionResult GetMovies(int Id)
        {
            var movie = context.movies.Find(Id);
            if(movie == null)

            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "User Not Found"
                });
            }
            else
            {
                return Ok(new
                {
                    StatusCode = 200,
                    MovieDetails = movie
                });
            }
        }
        
    }
}
