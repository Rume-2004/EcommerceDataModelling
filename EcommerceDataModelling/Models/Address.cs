using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class Address
    {
        private int HouseNumber;
        private string StreetName;
        private string City;
        private string PostCode;

        public int HouseNumber1 { get => HouseNumber; set => HouseNumber = value; }
        public string StreetName1 { get => StreetName; set => StreetName = value; }
        public string City1 { get => City; set => City = value; }
        public string PostCode1 { get => PostCode; set => PostCode = value; }
    }
}