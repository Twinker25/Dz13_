using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13_
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        public void Show()
        {
            Console.WriteLine($"\nAnimal characteristics:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Year: {Year}");
        }
    }

    public class Oceanarium<T> : Animal
    {
        public List<T> Animals { get; set; }

        public Oceanarium()
        {
            Animals = new List<T>();
        }
    }
}
