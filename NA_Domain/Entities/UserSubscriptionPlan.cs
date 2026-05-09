using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Domain.Entities
{
    public class UserSubscriptionPlan
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SubscriptionPlanId { get; set; }
        #region Relations
        public User User { get; set; }
        public SubscriptionPlan SubscriptionPlan { get; set; }
        #endregion Relations
    }
}
