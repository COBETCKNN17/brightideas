using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CBeltII.Data;
using CBeltII.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CBeltII.Controllers {
    public class HomeController : Controller {
        public DataContext _context;

        public HomeController (DataContext context) {
            _context = context;
        }
        public IActionResult Index () {
            return Redirect ("bright_ideas");
        }

        [HttpGet]
        [RouteAttribute ("bright_ideas")]
        public IActionResult bright_ideas () {
            if (HttpContext.Session.GetInt32 ("UserId") == null) {
                return RedirectToAction ("Index", "Login");
            }
            ViewBag.theUser = _context.Users.Where (u => u.UserId == (int) HttpContext.Session.GetInt32 ("UserId")).Single ();
            ViewBag.AllPosts = _context.Posts.Include (u => u.User).Include (l => l.Likes).OrderByDescending (l => l.Likes.Count).ToList ();
            return View ();

        }

        [HttpGet ("bright_ideas/{postId}")]
        public IActionResult idea_detail (int postId) {
            if (HttpContext.Session.GetInt32 ("UserId") == null) {
                return RedirectToAction ("Index", "Login");
            }
            ViewBag.currentPost = _context.Posts.Where (i => i.PostId == postId).Include (u => u.User).Include (l => l.Likes).ThenInclude (u => u.User).Single ();
            ViewBag.LikedBy = _context.Likes.Where (i => i.PostId == postId).ToList ();
            return View ();
        }

        [HttpPost ("/NewPost")]
        public IActionResult NewPost (string postText) {
            if (HttpContext.Session.GetInt32 ("UserId") == null) {
                return RedirectToAction ("Index", "Login");
            }
            if (postText.Length > 0) {
                Post newPost = new Post () {
                    UserId = (int) HttpContext.Session.GetInt32 ("UserId"),
                    PostText = postText
                };
                _context.Posts.Add (newPost);
                _context.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }

        [HttpGet("like/{postId}")]
        public IActionResult PostLike (int postId) {
            if (HttpContext.Session.GetInt32 ("UserId") == null) {
                return RedirectToAction ("Index", "Login");
            }
            Like newLike = new Like () {
                PostId = postId,
                UserId = (int) HttpContext.Session.GetInt32 ("UserId")
            };
            _context.Likes.Add (newLike);
            _context.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet("users/{userId}")]
        public IActionResult user_detail(int userId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index", "Login");
            } 
            ViewBag.theUser = _context.Users.Where(u => u.UserId == userId).Include(i => i.Posts).Include(l => l.Likes).SingleOrDefault(); 
            return View();
        }

        [HttpGet("delete/{postId}")]
        public IActionResult deletepost(int postId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index");
            } 
            Post deletedPost = new Post {PostId = postId};
            _context.Posts.Remove(deletedPost); 
            _context.SaveChanges(); 
            return RedirectToAction("Index"); 
        }

    }
}