namespace WebLab.DTO;

public class ExperimentFeedbackDto
{
    public int UserId { get; set; }
    public string Text { get; set; }
    public int Consistency { get; set; }
    public int CognitiveStress { get; set; }
    public int Learnability { get; set; }
    public int MentalModel { get; set; }
}