using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public enum DeliveryStatus
    {
        NotStarted,
        SubmittedByCommissioner,
        Traveling,
        InTargetParcelLocker
    }
}
