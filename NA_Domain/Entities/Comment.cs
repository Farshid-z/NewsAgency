using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class Comment
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long NewsId { get; set; }
        public bool IsApproved { get; set; }
        #region Relations
        public User User { get; set; }
        public News News { get; set; }
        #endregion Relations

    }
}
