using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Recipient : Person
    {
        public Recipient(string firstName, string surname, string phoneNumber, string emailAddress) : base(firstName, surname, phoneNumber, emailAddress)
        {
            ReceiverCodes = new List<string>();
        }

        public List<string> ReceiverCodes { get; set; }
        public void CollectParcel(Parcel parcel, string code)
        {

        }
    }
}
