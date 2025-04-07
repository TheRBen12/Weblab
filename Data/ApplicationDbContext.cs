using WebLab.Models;
using Microsoft.EntityFrameworkCore;
using WebLab.DTO;

namespace WebLab.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Experiment> Experiments { get; set; }
    public DbSet<UserSetting> UserSettings { get; set; }
    public DbSet<ExperimentTest> ExperimentTests { get; set; }

    public DbSet<Notebook> Notebooks { get; set; }

    public DbSet<PersonalComputer> PersonalComputers { get; set; }

    public DbSet<Product> Products { get; set; }
    public DbSet<KeyPad> KeyPads { get; set; }

    public DbSet<ProductType> ProductTypes { get; set; }

    public DbSet<Mixer> Mixers { get; set; }
    
    public DbSet<ProductProperty> ProductProperties { get; set; }
    
    public DbSet<ProductSpecification> ProductSpecifications { get; set; }
    
    public DbSet<DeletedMail> DeletedMails { get; set; }
    public DbSet<Mail> Mails { get; set; }
    
    public DbSet<UserBehaviour> UserBehaviours { get; set; }

    public DbSet<ExperimentTestExecution> ExperimentTestExecutions { get; set; }

    public DbSet<RecallRecognitionExperimentExecution> RecallRecognitionExperimentExecutions { get; set; }
    
    public DbSet<NavigationSelection> NavigationSelections { get; set; }


    public DbSet<HicksLawExperimentExecution> HicksLawExperimentExecutions { get; set; }

    public DbSet<ErrorCorrectionExperimentExecution> ErrorCorrectionExperimentExecutions { get; set; }
    
    public DbSet<MentalModelExperimentExecution> MentalModelExperimentExecutions { get; set; }

    public DbSet<MentalModelNavigationConfig> MentalModelNavigationConfigs { get; set; }

    public DbSet<UserNavigationTime> UserNavigationTimes { get; set; }

    public DbSet<FormAndFeedbackExperimentExecution> FormAndFeedbackExperimentExecutions { get; set; }
    
    public DbSet<FittsLawExperimentExecution> FittsLawExperimentExecutions { get; set; }
    
    public DbSet<RestorffExperimentExecution> RestorffExperimentExecutions { get; set; }


}