using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class UserExperimentProgressState
{
    [Key] public int Id;
    public Experiment Experiment;
    

}