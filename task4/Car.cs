using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Car
    { 
        
        public string model;
        public string brand;
        public string color;
        public int price;

        public string GetInfo() 
        {
            string output = $"{model}\n" +
                $"{brand}\n" +
                $"{color}\n" +
                $"{price}₼";

            return output;
        
        
        
        
        }

    } 
    
    
    
    
}
