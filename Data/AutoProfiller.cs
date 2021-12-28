using AuthIdentity.Data.Entity;
using AuthIdentity.Data.Models;
using AutoMapper;

namespace AuthIdentity.Data
{
    public class AutoProfiller : Profile
    {
        public AutoProfiller()
        {
            CreateMap<Post, PostViewModel>().ReverseMap();
        }
    }
}
