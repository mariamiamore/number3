namespace number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter");
            while (true)
            {
                Console.WriteLine("1. seconds to  minutes");
                Console.WriteLine("2. minutes to hours");
                Console.WriteLine("3. hours to days");
                Console.WriteLine("4. days to months");
                Console.Write("Please choose what to convert: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You chose option 1.");
                        {
                            Console.Write("\nNumber of seconds: ");
                            double seconds = Convert.ToDouble(Console.ReadLine());

                            double minutes = seconds / 60.0;
                            Console.WriteLine(minutes + " minute/s");
                        }
                        break;

                    case "2":
                        Console.WriteLine("You chose option 2.");
                        {
                            Console.Write("\nNumber of minutes: ");
                            double minutes = Convert.ToDouble(Console.ReadLine());

                            double hours = minutes / 60.0;
                            Console.WriteLine(hours + " hour/s");
                        }
                        break;

                    case "3":
                        Console.WriteLine("You chose option 3.");
                        {
                            Console.Write("\nNumber of hours: ");
                            double hours = Convert.ToDouble(Console.ReadLine());

                            double days = hours / 24.0;
                            Console.WriteLine(days + " day/s");
                        }
                        break;

                    case "4":
                        Console.WriteLine("You chose option 4.");
                        {
                            Console.Write("\nNumber of days: ");
                            double days = Convert.ToDouble(Console.ReadLine());

                            double months = days / 30.0;
                            Console.WriteLine(months + " month/s");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. Please choose again.");
                        continue;
                }
                break;

            }
            Console.ReadLine();
        }
    }
}