namespace Education.OOP.Events
{
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
    class PublisherGenericWithArg
    {
        public event EventHandler<CustomEventArgs> RaiseCustomerEvent;

        public void CallEvent()
        {
            RaiseEvent(new CustomEventArgs("Customer Arg"));
        }

        protected void RaiseEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> raiseEvent = RaiseCustomerEvent;
            if (raiseEvent != null)
            {
                e.Message = $"{DateTime.Now}";
                raiseEvent(this, e);
            }

        }
    }
    class SubscriberGenericWithArg
    {
        private readonly string _msg;
        public SubscriberGenericWithArg(string msg, PublisherGenericWithArg pub)
        {
            _msg = msg;
            pub.RaiseCustomerEvent += HandlerEvent;
        }

        void HandlerEvent(object? sender, CustomEventArgs e)
        {
            Console.WriteLine($"Value : {_msg} with Arg: {e.Message}");
        }
    }
    public class GenericEventWithCustomArg
    {
        static void Main()
        {
            var pub = new PublisherGenericWithArg();
            var sub1 = new SubscriberGenericWithArg("Raise Generic Event with arg 1", pub);
            var sub2 = new SubscriberGenericWithArg("Raise Generic Event with arg 2", pub);

            pub.CallEvent();
        }
    }
}
