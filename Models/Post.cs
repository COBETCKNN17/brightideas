using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CBeltII.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostText {get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User User {get; set;}
        public int UserId {get; set;}
        public List<Like> Likes {get; set;}
    }
}