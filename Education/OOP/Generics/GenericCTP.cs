using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Education.OOP.Generics
{
    public class GenericCTP //Constraints on type parameters
    {
        public struct Coord
        {
            public double X { get; init; } 
            public double Y { get; init; }
            public Coord(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString() => $"({X} , {Y})";
        }


        public class TestObj : System.IComparable<TestObj>
        {
            public TestObj() { }
            public TestObj(int id,string name)
            {
                Id = id;
                Name = name;
            }
            public int Id { get; set; }
            public string Name { get; set; }

            public int CompareTo(TestObj? other)
            {
                if (other == null) return 0;
                return Id.CompareTo(other.Id);
            }
        }
        public class TTTList<T> where T : class
        {
            private List<T> ls = new List<T>();
            public void Add(T value)
            {
                ls.Add(value);
            }
        }

        public class GenericStruct<T> where T : struct
        {
            public T Data { get; set; }
            public void CreateData(T data)
            {
                Data = data;
            }
            public void Print()
            {
                Console.WriteLine(Data.ToString());
            }
        }

        public static void Swap<T>(ref T a,ref T b) 
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static void PrintItem<T>(IList<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine($"{item}");
            }
        }
        public delegate void DoSomething<T>(T item);
        public static void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
        public class ListObj<T>
        {
            public delegate void ConcatObj(T[] items);
        }
        public static void ConcatAndShowString(string[] items)
        {
            Console.WriteLine(string.Join("-", items));
        }
        static void Main()
        {
            var genericStruct = new GenericStruct<Coord>();
            genericStruct.CreateData(new Coord(1, 2));
            genericStruct.Print();
    
            var genericClass = new TTTList<TestObj>();
            genericClass.Add(new TestObj(1, "Tin"));

            var a = 1;
            var b = 2;
            Swap(ref a, ref b);
            PrintItem([1, 2, 3, 4, 5, 6]);

            DoSomething<string> doST = ShowMsg;
            doST("Helloo");

            ListObj<string> lso = new ListObj<string>();
            ListObj<string>.ConcatObj concatFnc = ConcatAndShowString;
            concatFnc(["a", "b", "c"]);
        }
    }
}
