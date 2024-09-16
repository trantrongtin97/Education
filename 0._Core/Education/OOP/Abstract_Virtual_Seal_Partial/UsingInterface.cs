using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.OOP.Abstract_Virtual_Seal_Partial
{
    public delegate void ShowName(IHuman human);
    public class Human1 : IHuman
    {
        public int Blood { get; set; }
    }
    public class Human2 : IHuman
    {
        public int Blood { get; set; }
        public string name { get; set; }
    }
    public class Human3 : Human2
    {

    }
    public class UsingInterface
    {
        public void CallBlood(IHuman hm2)
        {
            Console.WriteLine(hm2.Blood);
        }
        public void Main()
        {
            l
            IHuman hm1 = new Human1();
            IHuman hm2 = new Human2();
            IHuman hm3 = new Human3();
            ShowName sn = CallBlood;
            sn(hm3);
        }
    }
}
