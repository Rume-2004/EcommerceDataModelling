﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class Staff
    {
        private string firstName;
        private string lastName;
        private int age;
        private Address address;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public Address Address { get => address; set => address = value; }
    }
}