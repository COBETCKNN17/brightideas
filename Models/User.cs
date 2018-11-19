using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CBeltII.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Post> Posts {get; set;}

        public List<Like> Likes {get; set;}

    }
}