namespace WebLab.Data;

public static class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Mails.Any()) // Falls keine E-Mails existieren
        {
            var emails = SeedMails.GetEmails();
            context.Mails.AddRange(emails);
            context.SaveChanges();
        }
    }
}