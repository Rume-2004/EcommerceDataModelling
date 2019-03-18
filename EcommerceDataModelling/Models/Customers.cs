using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class Customers
    {
        private string firstName;
        private string lastName;
        private DateTime dateofBirth;
        private string emailAddress;
        private Address address;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateofBirth { get => dateofBirth; set => dateofBirth = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public Address Address { get => address; set => address = value; }
    }
}