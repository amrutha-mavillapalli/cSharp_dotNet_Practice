namespace MyPractise
{
    public class ClsIfAndSwitch
    {
        public static void IfAndSwitch()
        {
            int number = 10;

            // If-else statement
            if (number > 0)
            {
                Console.WriteLine("{0} is a positive number.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("{0} is a negative number.", number);
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // Switch statement
            int day = 3;
            string dayName;

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }

            Console.WriteLine("Day {0} is {1}.", day, dayName);

            //Multiple case labels
            int fruit = 2;
            switch (fruit)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("You selected an apple, banana, or cherry.");
                    break;
                case 4:
                    Console.WriteLine("You selected a date.");
                    break;
                default:
                    Console.WriteLine("Unknown fruit selection.");
                    break;
            }


            int TotalcoffeeCost = 0;
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
            int choice = int.Parse(Console.ReadLine() ?? string.Empty);
        start:
            switch (choice)
            {
                case 1:
                    TotalcoffeeCost += 1;
                    break;
                case 2:
                    TotalcoffeeCost += 2;
                    break;
                case 3:
                    TotalcoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice { 0} is invalid , choice");
                    goto start;
            }
        decide:
            Console.WriteLine("Do You want to buy another coffee - Yes or No");
            string decision = Console.ReadLine() ?? string.Empty;
            switch (decision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice { 0} is invalid.Please try again, decision");
                    goto decide;

            }
            Console.WriteLine("Total Coffee Cost is : {0}", TotalcoffeeCost);
        }
    }
}