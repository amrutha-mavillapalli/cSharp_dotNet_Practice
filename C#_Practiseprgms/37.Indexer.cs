namespace MyPractise
{
    public class ClsIndexers
    {
        public class SampleCollection<T>
        {
            private T[] arr = new T[100];
            // Indexer to get and set values in the array
            public T this[int i]
            {
                get { return arr[i]; }
                set { arr[i] = value; }
            }
        }

        public static void IndexerExample()
        {
            SampleCollection<string> stringCollection = new SampleCollection<string>();
           //using indexer just like array
            stringCollection[0] = "Hello";
            stringCollection[1] = "World";
            Console.WriteLine(stringCollection[0] + " " + stringCollection[1]);

            SampleCollection<int> intCollection = new SampleCollection<int>();
            intCollection[0] = 10;
            intCollection[1] = 20;
            Console.WriteLine(intCollection[0] + intCollection[1]);
        }
    }
}