namespace API.Models
{
    public class Feedback
    {
        public static List<Feedback> FeedbackList = new List<Feedback>() {
            new Feedback(){Name = "CongMinh", Role = "Food Specialist", Img = "img/testimonials/1.jpg",  Comment = "Sound Good"},
            new Feedback(){Name = "QuocNam", Role = "Food Specialist", Img = "img/testimonials/2.jpg", Comment = "Really Good"},
            new Feedback(){Name = "PhuongBinh", Role = "Food Specialist", Img = "img/testimonials/3.jpg", Comment = "Delicious"},
        };
        public string Name { get; set; }
        public string Role { get; set; }
        public string Img { get; set; }
        public string Comment { get; set; }
    }
}