using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13_
{
    public class Footballer
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public void Show()
        {
            Console.WriteLine($"\nFootballer characteristics:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Number: {Number}");
        }
    }

    public class Team<T> : Footballer
    {
        public List<T> Footballers { get; set; }

        public Team()
        {
            Footballers = new List<T>();
        }
    }
}
