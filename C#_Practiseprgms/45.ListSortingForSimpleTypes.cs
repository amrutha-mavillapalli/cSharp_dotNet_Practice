namespace MyPractise
{
    public class ClsListSortingForSimpleTypes
    {
        public static void ListSortingForSimpleTypesExample()
        {
            //Integer Sorting
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
            Console.WriteLine("Numbers before Sorting:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Sort();
            Console.WriteLine("Numbers after Sorting:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Reverse();
            Console.WriteLine("Numbers after Sorting in descending order:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //string sorting
            List<string> alphabets = new List<string> { "B", "F", "D", "E", "A", "C" };
            Console.WriteLine("Alphabets before Sorting:");
            foreach (string i in alphabets)
            {
                Console.WriteLine(i);
            }
            alphabets.Sort();
            Console.WriteLine("Alphabets after Sorting:");
            foreach (string i in alphabets)
            {
                Console.WriteLine(i);
            }
            alphabets.Reverse();
            Console.WriteLine("Alphabets after Sorting in descending order:");
            foreach (string i in alphabets)
            {
                Console.WriteLine(i);
            }

        }

    }

}