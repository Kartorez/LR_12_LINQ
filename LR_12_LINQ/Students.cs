using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_12_LINQ
{
    internal class Students
    {
        
            public string Name;
            public string Surname;
            public int[] Rating = new int[5];
            public Students(string name, string surname, params int[] rating)
            {
                Name = name;
                Surname = surname;
                Rating = rating;
            }
        
    }
}
