namespace MyPractise
{
    public class ClsMultipleInterfaceInheritance
    {
        public interface IA
        {
            void AMethod();
        }

        class A : IA
        {
            public void AMethod()
            {
                Console.WriteLine("AMethod implementation in class A");
            }
        }
        public interface IB
        {
            void BMethod();
        }

        class B : IB
        {
            public void BMethod()
            {
                Console.WriteLine("BMethod implementation in class B");
            }
        }

       class C : IA, IB
        {
            A a = new A();
            B b = new B();
            public void AMethod()
            {
                a.AMethod();
            }

            public void BMethod()
            {
                b.BMethod();
            }
        }


        public static void MultipleInterfaceInheritanceExample()
        {
            C c = new C();
            c.AMethod();
            c.BMethod();
        }
    }
}