namespace Education.OOP.Events
{
    public class CharaterArg : EventArgs
    {
        public int NewPower { get; set; }
        public CharaterArg(int power)
        {
            NewPower = power;
        }
    }
    public abstract class Charater
    {
        protected int _power;
        public int Power 
        { 
            get => _power;
            set => _power = value;
        }
        public event EventHandler<CharaterArg> PowerChanged;
        public abstract void ShowSpecificInfo();
        public void ShowPowerIndex(int powerIndex)
        {
            ShowSpecificInfo();
            Console.WriteLine($"Power now is: {powerIndex}");
            Console.WriteLine($"----------------------------");
        }
        public void CelebrationAction()
        {
            Console.WriteLine("Smileeeeeeee");
        }
        public virtual void OnPowerChanged(CharaterArg e)
        {
            PowerChanged?.Invoke(this, e);
        }
    }
    public class Gunner : Charater
    {
        private int _bullet;
        public Gunner(int bullet)
        {
            _bullet = bullet;
            _power = _bullet * 1000;
            ShowPowerIndex(_power);
        }

        public void LevelUp(int extraBullet)
        {
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("************************Gunner is level up !******************************************");
            Console.WriteLine("**************************************************************************************");
            _bullet += extraBullet;
            _power = _bullet * 1000;
            OnPowerChanged(new CharaterArg(_power));
        }
        public override void OnPowerChanged(CharaterArg e)
        {
            base.OnPowerChanged(e);
        }
        public override void ShowSpecificInfo()
        {
            Console.WriteLine($"Gunner Info: --Bullet: {_bullet}");
        }
        public new void CelebrationAction() 
        {
            Console.WriteLine("Shoot in the air !");
        }
    }

    public class Assassin : Charater
    {
        private double _criticalRate;
        private int _invisibleTime;
        public Assassin(int invisibleTime,double criticalRate)
        {
            _invisibleTime = invisibleTime;
            _criticalRate = criticalRate;
            _power = _invisibleTime * 60 + Convert.ToInt32(_criticalRate * 1000);
            ShowPowerIndex(_power);
        }

        public void LevelUp(int extraInvisibleTime, double extraCriticalRate)
        {
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("************************Assassin is level up !******************************************");
            Console.WriteLine("**************************************************************************************");
            _criticalRate += extraCriticalRate;
            _invisibleTime += extraInvisibleTime;
            _power = _invisibleTime * 60 + Convert.ToInt32(_criticalRate * 1000);
            OnPowerChanged(new CharaterArg(_power));
        }
        public override void OnPowerChanged(CharaterArg e)
        {
            base.OnPowerChanged(e);
        }
        public override void ShowSpecificInfo()
        {
            Console.WriteLine($"Assassin Info: --Invisible Time: {_invisibleTime}s | Critical Rate: {_criticalRate} %");
        }
        public new void CelebrationAction()
        {
            Console.WriteLine("Throw the knife into the air !");
        }
    }

    public class CharaterManager
    {
        private readonly List<Charater> _lsCharater;
        public CharaterManager()
        {
            _lsCharater = new List<Charater>();
        }
        public void AddCharater(Charater charater)
        {
            _lsCharater.Add(charater);
            charater.PowerChanged += HandlePowerChanged;
        }
        private void HandlePowerChanged(object sender, CharaterArg e)
        {
            if (sender is Gunner gunner)
            {
                gunner.CelebrationAction();
                gunner.ShowPowerIndex(e.NewPower);
            }
            if (sender is Assassin assassin)
            {
                assassin.CelebrationAction();
                assassin.ShowPowerIndex(e.NewPower);
            }
        }
    }

    class EventWithOOP
    {
        static void Main()
        {
            var charaterManager = new CharaterManager();

            var gunner = new Gunner(6);
            var assassin = new Assassin(2, 1);

            charaterManager.AddCharater(gunner);
            charaterManager.AddCharater(assassin);

            gunner.LevelUp(6);
            assassin.LevelUp(2,1);
        }
    }
}
