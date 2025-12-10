namespace MyPractise
{
    public class ClsStaticAndInstanceCircleExample
    {
         // Static member
        static float _PI;

        // Instance member
        int _Radius;

        static ClsStaticAndInstanceCircleExample()
        {
            Console.WriteLine("Static Constructor called");
            ClsStaticAndInstanceCircleExample._PI = 3.14f;
        }

        public ClsStaticAndInstanceCircleExample(int radius)
        {
            Console.WriteLine("Instance Constructor called");
            this._Radius = radius;
        }

        public float CalculateArea()
        {
            return ClsStaticAndInstanceCircleExample._PI * this._Radius * this._Radius;
        }   

        public static void StaticAndInstanceCircleExample()
        {
            ClsStaticAndInstanceCircleExample circle1 = new ClsStaticAndInstanceCircleExample(5);
            Console.WriteLine("Area of circle with radius {0} is: {1}", 5, circle1.CalculateArea());

            ClsStaticAndInstanceCircleExample circle2 = new ClsStaticAndInstanceCircleExample(10);
            Console.WriteLine("Area of circle with radius {0} is: {1}", 10, circle2.CalculateArea());
        }
    }
}