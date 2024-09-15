using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Education.ColletionExp
{
    //https://learn.microsoft.com/vi-vn/dotnet/csharp/language-reference/operators/member-access-operators
    public class EducationCollection
    {
        static void Main()
        {
            int[] xs = [0, 10, 20, 30, 40];
            NameCollection lsName = new NameCollection(["Tran", "Trong", "Tin"]);
            //NameCollection lsName = ["Tran", "Trong", "Tin"];
            foreach (var item in lsName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Value Last Index: {xs[^1]}");
            Console.WriteLine($"Value First Index: {xs[^xs.Length]}");

            int[] temp1 = xs[1..(1 + 3)];
            Display(temp1);

            string line = "Tran Trong Tin";
            int amountToTakeFromEnd = 3;
            Range endIndices = ^amountToTakeFromEnd..^0;
            string end = line[endIndices];
            Console.WriteLine(end);
        }
        static void Display<T>(IEnumerable<T> xs) => Console.WriteLine(string.Join(" ", xs));
    }
}
