using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class Author
    {
        public long Id { get; set; }
        public long UserId { get; set; }

        #region Relations
        public User User { get; set; }
        #endregion Relations
    }
}
