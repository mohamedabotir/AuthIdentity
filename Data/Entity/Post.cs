using System;

namespace AuthIdentity.Data.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PublishTime { get; set; }
        public string UserId { get; set; }
        public UserIdentity User { get; set; }
    }
}
