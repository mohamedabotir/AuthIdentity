using AuthIdentity.Data.Models;

namespace AuthIdentity.Data.Repositories
{
    public interface IUserRepository
    {
        void AddPost(PostViewModel post, string userId);
    }
}
