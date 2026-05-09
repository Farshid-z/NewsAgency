using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class NewsCategory
    {
        public long Id { get; set; }
        public long NewsId { get; set; }
        public int CategoryId { get; set; }
        #region Relations
        public News News { get; set; }
        public Category Category { get; set; }
        #endregion Relations
    }
}
