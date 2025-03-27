using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Interfaces;

public interface IExperimentService
{
    Task<ExperimentTestExecution?> SaveExperimentExecution(ExperimentTestExecution experimentTestExecution);
}