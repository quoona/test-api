namespace API.Models
{
    public class Feedback
    {
        public static List<Feedback> FeedbackList = new List<Feedback>() {
            new Feedback() {Name = "CongMinh", Role = "Food Specialist", Comment = "Sound Good"},
            new Feedback() {Name = "QuocNam", Role = "Food Specialist", Comment = "Really Good"},
            new Feedback() {Name = "PhuongBinh", Role = "Food Specialist", Comment = "Delicious"},
        };
        public string Name { get; set; }
        public string Role { get; set; }
        public string Comment { get; set; }
    }
}