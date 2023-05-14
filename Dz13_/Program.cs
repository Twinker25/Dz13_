namespace Dz13_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.Write("\nEnter task (1 - 3): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Oceanarium<Animal> oceanarium = new Oceanarium<Animal>();
                        Console.Write("\nEnter number of animal: ");
                        int NumberAnimal = int.Parse(Console.ReadLine());
                        for (int i = 0; i < NumberAnimal; i++)
                        {
                            Console.Write("\nEnter name of animal: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter type of animal: ");
                            string type = Console.ReadLine();

                            Console.Write("Enter year of animal: ");
                            int year = int.Parse(Console.ReadLine());

                            Animal animal = new Animal { Name = name, Type = type, Year = year };
                            oceanarium.Animals.Add(animal);
                        }
                        foreach (var animal in oceanarium.Animals)
                        {
                            animal.Show();
                        }
                        break;
                    case 2:
                        Team<Footballer> team = new Team<Footballer>();
                        for (int i = 0; i < 11; i++)
                        {
                            Console.Write("\nEnter name of footballer: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter number of footballer: ");
                            int number = int.Parse(Console.ReadLine());

                            Footballer footballer = new Footballer { Name = name, Number = number };
                            team.Footballers.Add(footballer);
                        }
                        foreach (var player in team.Footballers)
                        {
                            player.Show();
                        }
                        break;
                    case 3:
                        Cafe<Employee> cafe = new Cafe<Employee>();
                        Console.Write("\nEnter number of emloyers: ");
                        int NumberEmployee = int.Parse(Console.ReadLine());
                        for (int i = 0; i < NumberEmployee; i++)
                        {
                            Console.Write("\nEnter name of employer: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter type work of employer: ");
                            string work = Console.ReadLine();

                            Employee employee = new Employee { Name = name, Work = work };
                            cafe.Workers.Add(employee);
                        }
                        foreach (var worker in cafe.Workers)
                        {
                            worker.Show();
                        }
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}