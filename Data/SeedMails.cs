using WebLab.Models;

namespace WebLab.Data;

public static class SeedMails
{
    public static List<Mail> GetEmails()
    {
        return new List<Mail>
        {
            new Mail { Id = 1, Sender = "alice@example.com", Receiver = "bob@example.com", Date = "2024-03-10", Subject = "Meeting Reminder", Body = "Don't forget our meeting tomorrow." },
            new Mail { Id = 2, Sender = "charlie@example.com", Receiver = "alice@example.com", Date = "2024-03-09", Subject = "Project Update", Body = "The project is on track for delivery." },
            new Mail { Id = 3, Sender = "bob@example.com", Receiver = "charlie@example.com", Date = "2024-03-08", Subject = "Invoice Request", Body = "Please send me the latest invoice." },
            new Mail { Id = 4, Sender = "david@example.com", Receiver = "alice@example.com", Date = "2024-03-07", Subject = "Happy Birthday!", Body = "Wishing you a great year ahead!" },
            new Mail { Id = 5, Sender = "eve@example.com", Receiver = "bob@example.com", Date = "2024-03-06", Subject = "Security Alert", Body = "Unusual login detected. Please check your account." },
            new Mail { Id = 6, Sender = "frank@example.com", Receiver = "david@example.com", Date = "2024-03-05", Subject = "Dinner Plans", Body = "Are we still on for dinner this weekend?" },
            new Mail { Id = 7, Sender = "grace@example.com", Receiver = "eve@example.com", Date = "2024-03-04", Subject = "New Job Offer", Body = "Check out this new job opportunity I found." },
            new Mail { Id = 8, Sender = "alice@example.com", Receiver = "frank@example.com", Date = "2024-03-03", Subject = "Re: Weekend Trip", Body = "Sounds great! Let's finalize the details." },
            new Mail { Id = 9, Sender = "bob@example.com", Receiver = "grace@example.com", Date = "2024-03-02", Subject = "Tech Conference", Body = "The conference next week looks interesting." },
            new Mail { Id = 10, Sender = "charlie@example.com", Receiver = "eve@example.com", Date = "2024-03-01", Subject = "Software Update", Body = "New update available. Please review." },
            new Mail { Id = 11, Sender = "david@example.com", Receiver = "alice@example.com", Date = "2024-02-28", Subject = "Document Submission", Body = "Have you submitted the document yet?" },
            new Mail { Id = 12, Sender = "eve@example.com", Receiver = "bob@example.com", Date = "2024-02-27", Subject = "Weekend Plans", Body = "Want to catch up this weekend?" },
            new Mail { Id = 13, Sender = "frank@example.com", Receiver = "charlie@example.com", Date = "2024-02-26", Subject = "Team Meeting", Body = "Agenda for the team meeting is attached." },
            new Mail { Id = 14, Sender = "grace@example.com", Receiver = "david@example.com", Date = "2024-02-25", Subject = "Feedback Request", Body = "Can you review this report and provide feedback?" },
            new Mail { Id = 15, Sender = "alice@example.com", Receiver = "eve@example.com", Date = "2024-02-24", Subject = "Flight Booking", Body = "I booked my flight. Let me know your schedule." },
            new Mail { Id = 16, Sender = "bob@example.com", Receiver = "frank@example.com", Date = "2024-02-23", Subject = "Training Session", Body = "Training session details attached." },
            new Mail { Id = 17, Sender = "charlie@example.com", Receiver = "grace@example.com", Date = "2024-02-22", Subject = "Bug Report", Body = "A new bug has been found in the system." },
            new Mail { Id = 18, Sender = "david@example.com", Receiver = "bob@example.com", Date = "2024-02-21", Subject = "Partnership Inquiry", Body = "Let's discuss potential collaboration." },
            new Mail { Id = 19, Sender = "eve@example.com", Receiver = "alice@example.com", Date = "2024-02-20", Subject = "Discount Offer", Body = "Exclusive discount for our premium members." },
            new Mail { Id = 20, Sender = "frank@example.com", Receiver = "charlie@example.com", Date = "2024-02-19", Subject = "Job Application", Body = "I have applied for the position. Hoping for good news." },
            new Mail { Id = 21, Sender = "grace@example.com", Receiver = "david@example.com", Date = "2024-02-18", Subject = "Happy New Year!", Body = "Wishing you success and happiness this year!" },
            new Mail { Id = 22, Sender = "alice@example.com", Receiver = "bob@example.com", Date = "2024-02-17", Subject = "Subscription Renewal", Body = "Your subscription is about to expire. Renew now!" }
        };
    }
}
