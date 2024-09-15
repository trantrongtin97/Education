namespace Education.OOP.Events
{
    class Publisher
    {
        public delegate void CustomerEventHandler(object sender);
        //public delegate void CustomerEventHandler(int sender); 
        public event CustomerEventHandler RaiseCustomerEvent;

        public void CallEvent()
        {
            RaiseEvent();
        }

        //public void CallEvent(int id)
        //{
        //    RaiseEvent(id);
        //}

        protected void RaiseEvent()
        {
            CustomerEventHandler raiseEvent = RaiseCustomerEvent;
            if (raiseEvent != null)
            {
                raiseEvent(this);  
            }
            
        }
    }
    class Subscriber
    {
        private readonly string _msg;
        //private readonly List<int> lsID = new List<int>() { 1,2,3};
        public Subscriber(string msg,Publisher pub)
        {
            _msg = msg; 
            pub.RaiseCustomerEvent += HandlerEvent;
        }
        void HandlerEvent(object sender) 
        {
            Console.WriteLine($"Value : {_msg}");
        }
        //void HandlerEvent(int sender)  
        //{
        //    switch (sender)
        //    {
        //        case 1:
        //            Console.WriteLine($"Value 1 : {_msg}");
        //            break;
        //        case 2:
        //            Console.WriteLine($"Value 2 : {_msg}");
        //            break;
        //        case 3:
        //            Console.WriteLine($"Value 3 : {_msg}"); 
        //            break;
        //    }
        //}
    }
    public class BasicEvent
    {
        static void Main()
        {
            var pub = new Publisher();
            //var sub1 = new Subscriber("Raise Event 1", pub);
            //var sub2 = new Subscriber("Raise Event 2", pub);

            pub.RaiseCustomerEvent += ttt;
            pub.RaiseCustomerEvent -= ttt;
            pub.CallEvent();
        }

        static void ttt(object obj)
        {
            Console.WriteLine("herllo1");
        }
        static void ttt2(object obj)
        {
            Console.WriteLine("herllo1");
        }
    }
}
