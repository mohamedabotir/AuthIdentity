using AuthIdentity.Data.Entity;
using AuthIdentity.Data.Models;
using System;

namespace AuthIdentity.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        ApplicationDbContext _ctx;
        public UserRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public void AddPost(PostViewModel model, string userId)
        {
            var post = new Post
            {
                Content = model.Content,
                PublishTime = DateTime.UtcNow,
                UserId = userId
            };
            _ctx.Posts.Add(post);
            _ctx.SaveChanges();
        }
    }
}
