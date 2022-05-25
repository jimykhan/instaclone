using System;
using System.Collections.Generic;
using instaclone.Data.Enum;
using Microsoft.AspNetCore.Identity;

namespace instaclone.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ProfileImagePath { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Country { get; set; }

        public bool IsDisabled { get; set; } = false;

        public string Bio { get; set; }

        public string City { get; set; }

        public List<Like> Likes { get; set; }

        public List<Posts> Posts { get; set; }

        public List<Comments> Comments { get; set; }



        //public List<RefreshToken> RefreshTokens { get; set; }

    }
}
