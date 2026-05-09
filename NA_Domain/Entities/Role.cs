using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class Role : IdentityRole<int>
    {
        #region Relations
        public ICollection<User> Users { get; set; } = new List<User>();
        #endregion Relations
    }
}
