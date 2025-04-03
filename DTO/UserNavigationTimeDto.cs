namespace WebLab.DTO;

public class UserNavigationTimeDto
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int? FromExperimentId { get; set; }

    public int ToExperimentId { get; set; }

    public DateTimeOffset FinishedNavigation { get; set; }

    public DateTimeOffset StartedNavigation { get; set; }

    public int UserSettingId { get; set; }

    public int NumberClicks { get; set; }
}