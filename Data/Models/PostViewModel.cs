using System;

namespace AuthIdentity.Data.Models
{
    public class PostViewModel
    {
        public string Content { get; set; }
        public DateTime PublishTime { get; set; }
        public string UserId { get; set; }
        public UserIdentity User { get; set; }
    }
}
