using System;
namespace instaclone.Data.Entities
{
    public class Follwers :  AuditableEntity
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
