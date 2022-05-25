using System;
namespace instaclone.Data.Entities
{
    public class Like : AuditableEntity
    {
        public int PostId { get; set; }

        public Posts Post { get; set; }

        public int ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

    }
}
