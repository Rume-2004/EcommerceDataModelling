using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class FaceBody
    {
        private Type Makeup;
        private Type SkinCare;
        private Type Fragrances;
        private Type BodyCare;
        private Type HairCare;

        public Type Makeup1 { get => Makeup; set => Makeup = value; }
        public Type SkinCare1 { get => SkinCare; set => SkinCare = value; }
        public Type Fragrances1 { get => Fragrances; set => Fragrances = value; }
        public Type BodyCare1 { get => BodyCare; set => BodyCare = value; }
        public Type HairCare1 { get => HairCare; set => HairCare = value; }
    }
}