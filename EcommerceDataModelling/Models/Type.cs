using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceDataModelling.Models
{
    public class Type
    {
        private string Men;
        private string Women;
        private string Boys;
        private string Girls;
        private string babies;

        public string Men1 { get => Men; set => Men = value; }
        public string Women1 { get => Women; set => Women = value; }
        public string Boys1 { get => Boys; set => Boys = value; }
        public string Girls1 { get => Girls; set => Girls = value; }
        public string Babies { get => babies; set => babies = value; }
    }
}