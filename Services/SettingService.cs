using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Services;

public class SettingService : ISettingService
{
    public UserSettingDTO CreateDefaultSetting(User user)
    {
        return user.Group switch
        {
            "A" => new UserSettingDTO()
            {
                ProgressiveVisualizationExperiment = false,
                ProgressiveVisualizationExperimentTest = false,
                AutoStartNextExperiment = false,
                UserID = user.Id
            },

            "B" => new UserSettingDTO()
            {
                ProgressiveVisualizationExperiment = false,
                ProgressiveVisualizationExperimentTest = false,
                AutoStartNextExperiment = false,
                UserID = user.Id
            },

            "C" => new UserSettingDTO()
            {
                ProgressiveVisualizationExperiment = false,
                ProgressiveVisualizationExperimentTest = false,
                AutoStartNextExperiment = false,
                UserID = user.Id
            },

            _ => throw new ArgumentException("Invalid day number! Must be between 1 and 7.")
        };
    }
}