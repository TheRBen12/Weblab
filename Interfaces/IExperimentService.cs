using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Interfaces;

public interface IExperimentService
{
    ExperimentTestExecution SaveExperimentExecution(ExperimentTestExecution experimentTestExecution);
}