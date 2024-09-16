namespace Education.OOP.Events
{
    class PublisherGeneric
    {
        public event EventHandler RaiseCustomerEvent;
        //public event EventHandler<int> RaiseCustomerEvent;

        public void CallEvent()
        {
            RaiseEvent(new EventArgs());
        }

        //public void CallEvent(int id)
        //{
        //    RaiseEvent(id);
        //}

        protected void RaiseEvent(EventArgs e) // EventArgs.Empty
        {
            EventHandler raiseEvent = RaiseCustomerEvent;
            if (raiseEvent != null)
            {
                raiseEvent(this, e);
            }

        }

        //protected void RaiseEvent(int id)
        //{
        //    EventHandler<int> raiseEvent = RaiseCustomerEvent;
        //    if (raiseEvent!=null)
        //    {
        //        raiseEvent(this,id);
        //    }
            
        //}
    }
    class SubscriberGeneric
    {
        private readonly string _msg;
        public SubscriberGeneric(string msg, PublisherGeneric pub)
        {
            _msg = msg;
            pub.RaiseCustomerEvent += HandlerEvent;
        }

        void HandlerEvent(object? sender, EventArgs e)
        {
            Console.WriteLine($"Value 1 : {_msg}"); 
        }

        //void HandlerEvent(object? sender, int id)
        //{
        //    switch (id)
        //    {
        //        case 1:
        //            Console.WriteLine($"Value 1 : {_msg}"); //, sender {sender}
        //            break;
        //        case 2:
        //            Console.WriteLine($"Value 2 : {_msg}"); //, sender {sender}
        //            break;
        //        case 3:
        //            Console.WriteLine($"Value 3 : {_msg}"); //, sender {sender}
        //            break;
        //    }
        //}
    }
    public class GenericEvent
    {
        static void Main()
        {
            var pub = new PublisherGeneric();
            var sub1 = new SubscriberGeneric("Raise Generic Event 1", pub);
            var sub2 = new SubscriberGeneric("Raise Generic Event 2", pub);

            pub.CallEvent();
            //pub.CallEvent(1);
        }
    }
}
