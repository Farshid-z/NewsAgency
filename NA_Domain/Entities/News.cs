using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class News
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string? Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishTime { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public NewsStatus Status { get; set; }

        #region Relations
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<NewsCategory> NewsCategories { get; set; } = new List<NewsCategory>();
        #endregion Relations

        public enum NewsStatus
        {
            Draft,
            Published,
            Archived
        }

    }
}

