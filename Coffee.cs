using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_3_4_WPF_CONVERT
{
   
        public class Coffee : Beverage
        {
            public Roast Roast { get; set; }
            public bool Caffinated { get; set; }
            public int NumberOfEspressoShots { get; set; }
            public bool Latte { get; set; } //With milk?
        }
        public enum Roast { light = 1, medium, dark }
    
}
