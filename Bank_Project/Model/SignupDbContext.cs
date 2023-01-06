using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Bank_Project.Model
{
    public class SignupDbContext:DbContext
    {
        public SignupDbContext(DbContextOptions<SignupDbContext> options) : base(options)
        {
        }
        public DbSet<Signup> SignUps { get; set; }
    }
}
