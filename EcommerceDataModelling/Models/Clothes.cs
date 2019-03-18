using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class Clothes
    {
        private Type shirt;
        private Type dresses;
        private Type jeans;
        private Type trousers;

        public Type Shirt { get => shirt; set => shirt = value; }
        public Type Dresses { get => dresses; set => dresses = value; }
        public Type Jeans { get => jeans; set => jeans = value; }
        public Type Trousers { get => trousers; set => trousers = value; }
    }
}