using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.OOP.Delegate
{
    public delegate void ShowMessage(string msg);
    public delegate void PrintDelegate(Calculator cal,int a, int b);
    public delegate int Calculator(int a, int b);
    public class EducationDelegate
    {
        public static void ConsoleWriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void ConsoleContentDelegate(Calculator cal,int a,int b)
        {
            Console.WriteLine(cal(a,b));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main()
        {
            Lesion1();
            Console.WriteLine("====================");
            Lesion2();
            Console.WriteLine("====================");
            Lesion3();
        }
        
        public static void Lesion1()
        {
            ShowMessage show = ConsoleWriteLine;
            show("Hello");

            PrintDelegate print = ConsoleContentDelegate;

            Calculator cal = Add;
            show($"{cal(1, 2)}");

            cal = new Calculator(Subtract);
            print(cal, 3, 2);

            Calculator calLambda = (a, b) => a * b;
            show($"{calLambda(2, 3)}");

            Func<int, int, int> calculateFunc = Add;
            show($"{calculateFunc(5, 5)}");
        }

        public static void Lesion2()
        {
            SayHelloWithName("TTT", ConsoleWriteLine);
        }
        private static void SayHelloWithName(string name, ShowMessage callBack)
        {
            Console.Write("Hello ");
            callBack(name);
        }
        
        public static void Lesion3()
        {
            Calculator cal, calAdd, calSub;
            calAdd = Add;
            calAdd -= Add;
            calSub = Subtract;
            cal = calSub + calAdd;
            Console.WriteLine(cal(1,2));
            //cal = cal - calAdd;
            //Console.WriteLine(cal(1, 2));
        }
    }
}
