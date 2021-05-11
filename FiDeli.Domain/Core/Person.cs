using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

    }
}
