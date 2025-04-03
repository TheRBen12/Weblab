namespace WebLab.DTO;

public class UserSettingDTO
{

    public int Id { get; set; }
    public bool ProgressiveVisualizationExperiment { get; set; }

    public bool ProgressiveVisualizationExperimentTest { get; set; }

    public bool AutoStartNextExperiment { get; set; }

    public int UserID { get; set; }
}