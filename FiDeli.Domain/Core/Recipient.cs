using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Recipient : Person
    {
        public string ReceiverCode { get; set; }
        public void CollectParcel(Parcel parcel, string code)
        {

        }
    }
}
