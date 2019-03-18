using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class Accessories
    {
        private Type Jewellery;
        private Type Scarves;
        private Type Gloves;
        private Type Sunglasses;

        public Type Jewellery1 { get => Jewellery; set => Jewellery = value; }
        public Type Scarves1 { get => Scarves; set => Scarves = value; }
        public Type Gloves1 { get => Gloves; set => Gloves = value; }
        public Type Sunglasses1 { get => Sunglasses; set => Sunglasses = value; }
    }
}