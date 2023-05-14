using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13_
{
    public class Employee
    {
        public string Name { get; set; }
        public string Work { get; set; }

        public void Show()
        {
            Console.WriteLine($"\nEmployee characteristics:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type of work: {Work}");
        }
    }

    public class Cafe<T> : Employee
    {
        public List<T> Workers { get; set; }

        public Cafe()
        {
            Workers = new List<T>();
        }
    }
}
