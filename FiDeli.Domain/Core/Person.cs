using FiDeli.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Person : Localisable
    {
        public Person(string firstName, string surname, string phoneNumber, string emailAddress)
        {
            FirstName = firstName;
            Surname = surname;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            OpenedLockers = new List<Locker>();
        }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public List<Locker> OpenedLockers { get; set; }

        
    }
}
