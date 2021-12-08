using FeedBack.Data.Interfaces;
using FeedBack.Data.Models;

namespace test_api.FeedBack.Data.Repositories
{
    public class FeedBackRepository : IFeedBackRepository
    {

        public List<Feedback> FeedbackList = new List<Feedback>() {
            new Feedback(){Name = "CongMinh", Role = "Food Specialist", Img = "img/testimonials/1.jpg",  Comment = "Sound Good"},
            new Feedback(){Name = "QuocNam", Role = "Food Specialist", Img = "img/testimonials/2.jpg", Comment = "Really Good"},
            new Feedback(){Name = "PhuongBinh", Role = "Food Specialist", Img = "img/testimonials/3.jpg", Comment = "Delicious"},
        };

        public List<Feedback> GetAllFeedBack()
        {
            return FeedbackList;
        }


        Feedback IFeedBackRepository.GetFeedBackById(int id)
        {
            throw new NotImplementedException();
        }
    }
}