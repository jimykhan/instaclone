using System;
namespace instaclone.Dtos
{
    public class UserDto
    {
        public string AppUserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public int Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ProfileImagePath { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Country { get; set; }

        public bool IsDisabled { get; set; } = false;

        public string Bio { get; set; }

        public string City { get; set; }
    }
}
