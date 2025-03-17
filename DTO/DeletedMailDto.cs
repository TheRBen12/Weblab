namespace WebLab.DTO;

public class DeletedMailDto
{
    public int Id { get; set; }

    public string Sender { get; set; }
    
    public string Receiver { get; set; }


    public int User { get; set; }

    public string Date { get; set; }
    public string Subject { get; set; }
    
    public string Body { get; set; }
}