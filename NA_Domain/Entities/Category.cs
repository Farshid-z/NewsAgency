using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        #region Relations
        public ICollection<NewsCategory> NewsCategories { get; set; } = new List<NewsCategory>();
        #endregion Relations
    }
}
