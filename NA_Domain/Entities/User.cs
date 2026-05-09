using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class User : IdentityUser<long>
    {
        public int RoleId { get; set; }
        #region Relations
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public Role Role { get; set; }
        public ICollection<UserSubscriptionPlan> UserSubscriptionPlans { get; set; } = new List<UserSubscriptionPlan>();
        #endregion Relations
    }
}
