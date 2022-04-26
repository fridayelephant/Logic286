using System;
using System.Collections.Generic;
using System.Text;

namespace Hari04
{
    public class ListSingleValue
    {
        public ListSingleValue()
        {
            List<string> ListName = new List<string>()
            {
                "Andrata Ganesha",
                "Robby Meliala",
                "Arva Prasetio",
            };

            foreach (var item in ListName)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
