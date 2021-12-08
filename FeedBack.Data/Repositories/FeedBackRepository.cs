using FeedBack.Data.Interfaces;
using FeedBack.Data.Models;

namespace test_api.FeedBack.Data.Repositories
{
    public class FeedBackRepository : IFeedBackRepository
    {

        public List<Feedback> FeedbackList = new List<Feedback>() {
            new Feedback() {Name = "CongMinh", Role = "Food Specialist", Comment = "Sound Good"},
            new Feedback() {Name = "QuocNam", Role = "Food Specialist", Comment = "Really Good"},
            new Feedback() {Name = "PhuongBinh", Role = "Food Specialist", Comment = "Delicious"},
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