using Bank_Project.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bank_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupsController : ControllerBase
    {
        private readonly SignupDbContext _context;

        public SignupsController(SignupDbContext context)
        {
            _context = context;
        }

        // GET: api/Signups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Signup>>> GetSignUps()
        {
            return await _context.SignUps.ToListAsync();
        }

        // GET: api/Signups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Signup>> GetSignup(int id)
        {
            var signup = await _context.SignUps.FindAsync(id);

            if (signup == null)
            {
                return NotFound();
            }

            return signup;
        }

        // PUT: api/Signups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSignup(int id, Signup signup)
        {
            if (id != signup.Id)
            {
                return BadRequest();
            }

            _context.Entry(signup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SignupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Signups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Signup>> PostSignup(Signup signup)
        {
            _context.SignUps.Add(signup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSignup", new { id = signup.Id }, signup);
        }
        [HttpPost("LoginUser")]


        public IActionResult Login(Login user)
        {
            var userAvailableEmail = _context.SignUps.Where(u => u.Email == user.Email).FirstOrDefault();
            var userAvailablePass = _context.SignUps.Where(u => u.Password == user.Password).FirstOrDefault();

            if (userAvailableEmail != null && userAvailablePass != null)
            {
                return Ok("Success");
            }

            return Ok("Failure");
        }


        [HttpPost("AdminLogin")]


        public IActionResult Admin(Admin user)

        {
            var userAvailableEmail = _context.SignUps.Where(u => "admin@gmail.com" == user.Email).FirstOrDefault();
            var userAvailablePass = _context.SignUps.Where(u => "admin123" == user.Password).FirstOrDefault();

            if (userAvailableEmail != null && userAvailablePass != null)
            {
                return Ok("Success");
            }

            return Ok("Failure");
        }


        // DELETE: api/Signups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSignup(int id)
        {
            var signup = await _context.SignUps.FindAsync(id);
            if (signup == null)
            {
                return NotFound();
            }

            _context.SignUps.Remove(signup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SignupExists(int id)
        {
            return _context.SignUps.Any(e => e.Id == id);
        }
    }
}
