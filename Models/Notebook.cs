using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class Notebook
{
    [Key] public int Id { get; set; }

    [Required] public int Arbeitsspeicher { get; set; }

    [Required] public int Festplatte { get; set; }

    [Required] public string Os { get; set; }

    [Required] public string KeyPadFormat { get; set; }

    [Required] public string ProcessorType { get; set; }

    [Required] public int NumberProcessorCores { get; set; }

    [Required] public string GraphicCardModel { get; set; }

    [Required] public int NumberPerformanceCors { get; set; }

    [Required] public int MaxBatteryTime { get; set; }
    
    [Required] public int NumberUsbAdapters { get; set; }

    [Required] public Product Product { get; set; }
    
    

    

}