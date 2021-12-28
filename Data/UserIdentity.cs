using Microsoft.AspNetCore.Identity;

namespace AuthIdentity.Data
{
    public class UserIdentity : IdentityUser
    {
        [PersonalData]
        public string fullName { get; set; }
        public string FavoritColor { get; set; }

    }
}
