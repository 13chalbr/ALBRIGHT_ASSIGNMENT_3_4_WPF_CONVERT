using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_3_4_WPF_CONVERT
{
    
        public abstract class Beverage
        {
            public string BevName { get; set; }
            public double Price { get; set; }
            public double Ounces { get; set; }
            public double ABV { get; set; }
            public Temp Temperature { get; set; }
        }
        public enum Temp { hot = 1, iced }
 }
