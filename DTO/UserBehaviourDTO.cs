namespace WebLab.DTO;

public class UserBehaviourDTO
{
    public int Id { get; set; }
    
    public bool ?ClickedOnHelp { get; set; }
    
    public int ?NumberClickedOnHelp { get; set; }
    
    public int? User { get; set; }
    
    public bool ?ClickedOnSettings { get; set; }
    
    public int ?NumberClickedOnSettings { get; set; }

    public int ?TimeReadingWelcomeModal { get; set; }

    public bool ?ClickedOnHint { get; set; }
    
    public int ?NumberClickedOnHint { get; set; }
    
    public bool? ClickedOnSettingsAfterHintDisplayed { get; set; } = false;
    
    public int? WelcomeModalTipIndex { get; set; }
    
    public  DateTimeOffset? LastUpdatedAt { get; set; }
    
    public  DateTimeOffset? ClickedOnSettingsAt { get; set; }
}