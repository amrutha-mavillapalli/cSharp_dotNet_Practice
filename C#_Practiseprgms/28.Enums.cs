namespace MyPractise
{
    // Default underlying type is int, starting from 0
    // public class ClsEnums : short // to change underlying type to short
    public class ClsEnums
    {
        enum Gender
        {
            Male,
            Female,
            Unknown
        }

        // Enum VALUES CAN BE CHANGED AS WELL, need not be sequential
        //  enum Gender : short
        // {
        //     Male = 10,
        //     Female = 202,
        //     Unknown = 30
        // }

        public static void EnumsExample()
        {

            // Explicit conversion from enum to int and vice versa
            // Gender gen = (Gender)3;
            // int num = (int)Gender.Unknown;

            int[] Values = (int[])Enum.GetValues(typeof(Gender));
            foreach (int val in Values)
            {
                Console.WriteLine("Enum Value: {0}", val);
            }

            string[] Names = Enum.GetNames(typeof(Gender));
            foreach (string name in Names)
            {
                Console.WriteLine("Enum Name: {0}", name);
            }
        }

        //Another example
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        public static void DaysExample()
        {
            Days meetingDay = Days.Wednesday;
            Console.WriteLine("Meeting Day: {0}", meetingDay);

            // Convert enum to int
            int dayValue = (int)meetingDay;
            Console.WriteLine("Meeting Day Value: {0}", dayValue);

            // Convert int to enum
            Days anotherDay = (Days)5;
            Console.WriteLine("Another Day: {0}", anotherDay);
        }

    }
}