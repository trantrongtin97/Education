using Education.OOP.Abstract_Virtual_Seal;
using Education.OOP.Abstract_Virtual_Seal_Partial;

namespace Education.OOP
{
    public class EducationOOP
    {
        static void Main()
        {
            //LessonBasic1();

            //Console.WriteLine("\n===================================================\n");

            //LessonBasic2();

            //Console.WriteLine("\n===================================================\n");

            LessonAbstractVirtualSeal();
        }

        static void LessonBasic1()
        {
            Person ps = new Person();
            Men m = new Men();
            Person psm = new Men();

            //ps.Talk();
            //ps.Fuck();
            m.Talk();
            m.Fuck();
            m.SetMoney(1);
            m.PrintMoney();
            m.SetMoney(4);
            m.PrintMoney();
            //psm.Talk();
            //psm.Fuck();
        }

        static void LessonBasic2()
        {
            //Car c = new Car();
            //Toyota t = new Toyota();
            //Mercedes m = new Mercedes();

            //c.ShowInfo();
            //t.ShowInfo();
            //m.ShowInfo();

            var cars = new List<Car>() {new Car(),new Toyota(),new Mercedes() };
            cars.ForEach(car => { car.ShowInfo(); });
        }

        public static void LessonAbstractVirtualSeal() 
        {
            //Shinobi snb = new Shinobi();  //can not because abstract class
            FirstHokage first = new FirstHokage();
            IHuman sinobi = new Naruto();
            first.Chakra();
            first.Attack();
            first.Skill();
            first.WoodArt();
            Console.WriteLine("*******");
            SecondHokage second = new SecondHokage();
            second.Chakra();
            second.Attack();
            second.Skill();
            second.WaterArt();
            second.WoodArt();
            Console.WriteLine("*******");
            ThirdHokage third = new ThirdHokage();
            third.Chakra();
            third.Attack();
            third.Skill();
            third.WaterArt();
            third.WoodArt();
            Console.WriteLine("*******");
            Obito obito = new Obito();
            obito.Chakra();
            obito.Attack();
            obito.Skill();
            obito.WoodArt();
            ((FirstHokage)obito).WoodArt(); //can not -> call wood art in obito
            Console.WriteLine("*******");
            Madara madara = new Madara();
            madara.Chakra();
            madara.Attack();
            madara.Skill();
            madara.WoodArt();
            Console.WriteLine("*******");
            Naruto naruto = new Naruto();
            naruto.Chakra();
            naruto.Attack();
            naruto.Skill();
            naruto.Skill2();
        }
    }
}
