using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class Mail
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Sender { get; set;  }
    
    [Required] 
    public string Subject{ get; set; }
    
    [Required] 
    public string Body{ get; set; }

    [Required] 
    public string Receiver{ get; set; }

    [Required] public string Date { get; set; }
}