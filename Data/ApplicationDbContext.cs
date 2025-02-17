using WebLab.Models;
using Microsoft.EntityFrameworkCore;

namespace WebLab.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
    {
       
    }

     public DbSet<User> Users { get; set; }
     public DbSet<Experiment> Experiments { get; set; }
     public DbSet<UserSetting> UserSettings { get; set; }
     public DbSet<ExperimentTest> ExperimentTests { get; set; }
}