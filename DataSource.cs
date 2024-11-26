using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_3_4_WPF_CONVERT
{
    internal class DataSource
    {
    
            public static List<Coffee> Coffees;

            public static List<Coffee> CreateData()
            {
                Coffees = new List<Coffee>()
                {
                new Coffee() { BevName = "Americano", Price = 3.50, Ounces = 5.0, ABV = 0, Temperature = Temp.hot, Roast = Roast.medium, Caffinated = true, NumberOfEspressoShots = 1, Latte = false },
                new Coffee() { BevName = "Irish Coffee", Price = 7.50, Ounces = 6.5, ABV = 0.09, Temperature = Temp.hot, Roast = Roast.dark, Caffinated = true, NumberOfEspressoShots = 2, Latte = false },
                new Coffee() { BevName = "Espresso", Price = 2.50, Ounces = 1.5, ABV = 0, Temperature = Temp.hot, Roast = Roast.medium, Caffinated = true, NumberOfEspressoShots = 1, Latte = false },
                new Coffee() { BevName = "Iced Vanilla Latte", Price = 4.50, Ounces = 6.0, ABV = 0, Temperature = Temp.iced, Roast = Roast.light, Caffinated = true, NumberOfEspressoShots = 1, Latte = true },
                };
             return Coffees;
            }
    }
    
}
