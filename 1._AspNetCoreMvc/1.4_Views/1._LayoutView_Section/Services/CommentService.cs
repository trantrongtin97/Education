using LayoutView_Section.Models;

namespace LayoutView_Section.Services
{
    public class CommentService
    {
        public static async Task<List<Comment>> GetRecentCommentsAsync()
        {
            await Task.Delay(500); 
            return new List<Comment>
            {
                new Comment(){Text = "Ha Ha!", User= "Tint"},
                new Comment(){Text = "Hello.", User= "HuyL"},
                new Comment(){Text = "Hi Hi.", User= "PhucD"}
            };
        }
    }
}
