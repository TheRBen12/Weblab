using cyclefriends.Models;
using Microsoft.EntityFrameworkCore;
using WebLab.Models;

namespace WebLab.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
    {
       
    }

     public DbSet<User> Users { get; set; }
     public DbSet<Experiment> Experiments { get; set; }
}