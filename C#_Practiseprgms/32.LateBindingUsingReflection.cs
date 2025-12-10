using System.Reflection;

namespace MyPractise
{
    public class ClsLateBindingUsingReflection
    {
        public string Display(string id, string name)
        {
            return "Customer ID: " + id + ", Name: " + name;
        }
        public static void LateBindingUsingReflectionExample()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Type T = asm.GetType("MyPractise.ClsLateBindingUsingReflection");
            object obj = Activator.CreateInstance(T);
            MethodInfo methodInfo = T.GetMethod("Display");
            string[] param = new string[2];
            param[0] = "101";
            param[1] = "Amrutha";
            string res = (string)methodInfo.Invoke(obj, param);
            Console.WriteLine(res);
        }
    }
}