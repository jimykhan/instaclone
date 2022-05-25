using System;
using instaclone.Data.Enum;

namespace instaclone.Data.Entities
{
    public class Comments : AuditableEntity
    {
        public int PostId { get; set; }

        public Posts Post { get; set; }

        public int ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string CommentText { get; set; }

        public string FileUrl { get; set; }

        public PostType PostType { get; set; }

    }
}
