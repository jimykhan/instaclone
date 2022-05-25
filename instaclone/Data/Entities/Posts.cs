using System;
using System.Collections.Generic;
using instaclone.Data.Enum;

namespace instaclone.Data.Entities
{
    public class Posts : AuditableEntity
    {
        public int Id { get; set; }

        public string PostCaption { get; set; }

        public string FileUrl { get; set; } 

        public PostType PostType { get; set; }

        public int ApplicationUserIdv { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public List<Like> Likes { get; set; }

        public List<Comments> Comments { get; set; }

    }
}
