using AuthIdentity.Data;
using AuthIdentity.Data.Entity;
using AuthIdentity.Data.Models;
using AuthIdentity.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace AuthIdentity.Controllers
{

    public class HomeController : Controller
    {

        ApplicationDbContext _ctx;
        IUserRepository userRepo;
        IMapper map;
        public HomeController(ApplicationDbContext _ctx, IUserRepository userRepository, IMapper map)
        {
            this._ctx = _ctx;
            this.userRepo = userRepository;
            this.map = map;

        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var posts = _ctx.Posts.Include(e => e.User).ToList();

            var result = map.Map<IEnumerable<Post>, IEnumerable<PostViewModel>>(posts);

            return View(result);
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(PostViewModel model)
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            userRepo.AddPost(model, userId);
            return Ok();

        }

    }
}
