using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class Shoes
    {
        private Type Boots;
        private Type Trainers;
        private Type Loafers;
        private Type Sandals;

        public Type Boots1 { get => Boots; set => Boots = value; }
        public Type Trainers1 { get => Trainers; set => Trainers = value; }
        public Type Loafers1 { get => Loafers; set => Loafers = value; }
        public Type Sandals1 { get => Sandals; set => Sandals = value; }
    }
}