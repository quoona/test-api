using FeedBack.Data.Models;

namespace FeedBack.Data.Interfaces
{
    public interface IFeedBackRepository
    {
        List<Feedback> GetAllFeedBack();
        Feedback GetFeedBackById(int id);
    }
}