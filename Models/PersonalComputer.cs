using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class PersonalComputer
{
    [Key] public int Id { get; set; }

    [Required] public int Ram { get; set; }

    [Required] public int StorageCapacity { get; set; }

    [Required] public string Os { get; set; }

    [Required] public string KeyPadFormat { get; set; }

    [Required] public string ProcessorType { get; set; }

    [Required] public int NumberProcessorCores { get; set; }

    [Required] public string GraphicCardModel { get; set; }

    [Required] public int NumberPerformanceCors { get; set; }

    [Required] public float ClockFrequency { get; set; }
    
    [Required] public int NumberUsbAdapters { get; set; }
    
    [Required] public int Cache { get; set; }

    [Required] public Product Product { get; set; }
    
    [Required] public string ProductCategory { get; set; }
    
    [Required] public ProductType Type { get; set; }


}