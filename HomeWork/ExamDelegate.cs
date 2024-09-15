using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace ZZZZHomeWork
{
    //#region Exam1
    //public abstract class Animal
    //{
    //    public string? Lang { get; set; }
    //    public delegate void Eat();
    //    public delegate void Run();
    //    public delegate void Skill();
    //    public abstract void ActionAll();
    //}
    //public class Dog : Animal
    //{
    //    public Eat d_eat;
    //    public Run d_run;
    //    public Skill d_skill;
    //    public Dog()
    //    {
    //        d_eat = DogEat;
    //        d_run = DogRun;
    //        d_skill = DogSkill;
    //    }
    //    private void DogEat()
    //    {
    //        Console.WriteLine($"Dog Eat: {Lang}");
    //    }
    //    private void DogRun()
    //    {
    //        Console.WriteLine("Dog Run");
    //    }
    //    private void DogSkill()
    //    {
    //        Console.WriteLine("Dog Skill");
    //    }
    //    public override void ActionAll()
    //    {
    //        d_eat();
    //        d_run();
    //        d_skill();
    //    }
    //}
    //public class Chicken : Animal
    //{
    //    public Eat c_eat;
    //    public Run c_run;
    //    public Skill c_skill;
    //    public Chicken()
    //    {
    //        c_eat = ChickenEat;
    //        c_run = ChickenRun;
    //        c_skill = ChickenSkill;
    //    }
    //    private void ChickenEat()
    //    {
    //        Console.WriteLine("Chicken Eat");
    //    }
    //    private void ChickenRun()
    //    {
    //        Console.WriteLine("Chicken Run");
    //    }
    //    private void ChickenSkill()
    //    {
    //        Console.WriteLine("Chicken Skill");
    //    }
    //    public override void ActionAll()
    //    {
    //        c_eat();
    //        c_run();
    //        c_skill();
    //    }
    //}
    //public class Exam1
    //{
    //    public void DogRun2()
    //    {
    //        Console.WriteLine("Dog Run 2");
    //    }
    //    public void ChickenSkill2()
    //    {
    //        Console.WriteLine("Chicken Run 2");
    //    }
    //    public void DoExam1()
    //    {
    //        Dog dog = new Dog();
    //        dog.Lang = "Gaau gaau";
    //        dog.d_eat = DogRun2;
    //        dog.d_eat();

    //        //Chicken chicken = new Chicken();
    //        //chicken.c_skill = ChickenSkill2;
    //        //chicken.ActionAll();
    //    }
    //}
    //#endregion

    //#region Exam2
    //public abstract class ManagerMoney
    //{
    //    public abstract double Money { get; set; }
    //    public delegate void In(double num);
    //    public delegate void Out(double num);
    //    public delegate double Calculate();
    //    public abstract void Report();
    //}

    //public class Fund : ManagerMoney
    //{
    //    public override double Money { get; set; }
    //    public In d_in;
    //    public Out d_out;
    //    public Calculate d_calculate;
    //    public Fund()
    //    {
    //        Money = 0;
    //        d_in = FundIn;
    //        d_out = FundOut;
    //        d_calculate = FundCalculate;
    //    }
    //    public Fund(ManagerMoney mng)
    //    {
    //        Money = mng.Money;
    //        mng.Money = 0;
    //        d_in = FundIn;
    //        d_out = FundOut;
    //        d_calculate = FundCalculate;
    //    }

    //    public void FundIn(double num) => Money += num;

    //    public void FundOut(double num) => Money -= (num + d_calculate());

    //    public double FundCalculate() => 10;
    //    public override void Report()
    //    {
    //        Console.WriteLine($"Remainning Sum: {Money}");
    //    }
    //}
    //public class Exam2
    //{
    //    public double Fund2Calculate()
    //    {
    //        return 20;
    //    }
    //    public void DoExam2()
    //    {
    //        Fund fund1 = new Fund();
    //        fund1.d_in(3000);
    //        fund1.d_out(1000);
    //        fund1.Report();

    //        Fund fund2 = new Fund(fund1);
    //        fund2.d_calculate = Fund2Calculate;
    //        fund2.d_out(1000);
    //        fund1.d_out(1000);

    //        fund2.Report();
    //        fund1.Report();
    //    }
    //}
    //#endregion

    #region Exam4
    public delegate void InMoney(decimal num);
    public delegate void OutMoney(decimal num);
    public delegate void ReportFund();
    public interface IFund
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<IFund> Funds { get; set; }
        public InMoney in_m { get; set; }
        public OutMoney out_m { get; set; }
        public ReportFund rp_m { get; set; }
        public void InMoney(decimal num);
        public void OutMoney(decimal num);
        public void ReportMoney();
        public void ShareMoneyToFund(string name, decimal num);
        public void MoveMoneyFundToFund(string fromFund, string toFund, decimal num);
    }
    public class Fund : IFund
    {
        public string Name { get; set; }
        public List<IFund> Funds { get; set; }
        public decimal Money { get; set; }
        public InMoney in_m { get; set; }
        public OutMoney out_m { get; set; }
        public ReportFund rp_m { get; set; }

        public Fund(string name)
        {
            Name = name;
            Money = 0;
            Funds = new List<IFund>();
            in_m = InMoney;
            out_m = OutMoney;
            rp_m = ReportFund;
        }
        public void InMoney(decimal num)
        {
            if (num < 0) return;
            Money += num;
        }
        public void OutMoney(decimal num)
        {
            if (num < 0) return;
            if (Money < num) return;
            Money -= num;
        }
        public void ReportFund()
        {
            ReportMoney();
            if (Funds != null && Funds.Count > 0)
            {
                foreach (IFund f in Funds)
                {
                    f.rp_m();
                }
            }
        }
        public void ReportMoney()
        {
            Console.WriteLine($"{Name} Hien co: {Money}");
        }
        public virtual void ShareMoneyToFund(string name, decimal num)
        {
            if (Funds != null && Funds.Count > 0)
            {
                foreach (IFund f in Funds)
                {
                    if (f.Name == name)
                    {
                        this.out_m(num);
                        f.in_m(num);
                    }
                }
            }
        }
        public virtual void MoveMoneyFundToFund(string fromFund, string toFund, decimal num)
        {
            if (Funds != null && Funds.Count > 0)
            {
                foreach (IFund f in Funds)
                {
                    if (f.Name == fromFund)
                    {
                        f.out_m(num);
                        this.Funds.FirstOrDefault(t => t.Name == toFund)?.in_m(num);
                    }
                }
            }
        }
    }
    public class Exam4
    {
        public void DoExam4()
        {
            IFund masterFund = new Fund("Master Fund");
            IFund fund1 = new Fund("Fund 1");
            IFund fund2 = new Fund("Fund 2");
            masterFund.in_m(10000);
            masterFund.Funds.AddRange(new[] { fund1, fund2 });
            masterFund.ShareMoneyToFund("Fund 1", 2000);
            masterFund.MoveMoneyFundToFund("Fund 1", "Fund 2", 1500);
            fund1.in_m(1000);
            fund2.out_m(1000);
            masterFund.rp_m();
        }
    }
    #endregion

    public class ExamDelegate
    {
        //static void Main()
        //{
        //    //Exam1 exam1 = new();
        //    //exam1.DoExam1();

        //    //Exam2 exam2 = new();
        //    //exam2.DoExam2();

        //    Exam4 exam4 = new();
        //    exam4.DoExam4();
        //}
    }
   
}
