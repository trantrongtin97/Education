using System;

namespace Education.OOP.Events
{
    public class GridEventArg: EventArgs
    {
        public string MsgTime {  get; set; }

        public GridEventArg(string msgTime)
        {
            MsgTime = msgTime;
        }
    }
    public interface IBeforeLoadGrid
    {
        event EventHandler<GridEventArg> OnBeforeLoadGrid;
    }
    public interface IAfterLoadGrid
    {
        event EventHandler<GridEventArg> OnAfterLoadGrid;
    }
    public class TTTGrid : IAfterLoadGrid, IBeforeLoadGrid
    {
        public event EventHandler<GridEventArg> OnAfterLoadGrid;
        public event EventHandler<GridEventArg> OnBeforeLoadGrid;
        object objectLock = new Object();

        event EventHandler<GridEventArg> IBeforeLoadGrid.OnBeforeLoadGrid
        {
            add
            {
                lock (objectLock)
                {
                    OnBeforeLoadGrid += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    OnBeforeLoadGrid -= value;
                }
            }
        } 
        event EventHandler<GridEventArg> IAfterLoadGrid.OnAfterLoadGrid
        {
            add
            {
                lock (objectLock)
                {
                    OnAfterLoadGrid += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    OnAfterLoadGrid -= value;
                }
            }
        }

        public void LoadGrid()
        {
            OnBeforeLoadGrid?.Invoke(this, new GridEventArg(DateTime.Now.TimeOfDay.ToString()));
            Console.WriteLine("Grid Loaded");
            OnAfterLoadGrid?.Invoke(this, new GridEventArg(DateTime.Now.TimeOfDay.ToString()));
        }
    }
    public class SubscriberBeforeEvent
    {
        public SubscriberBeforeEvent(TTTGrid grid)
        {
            IBeforeLoadGrid d = (IBeforeLoadGrid)grid;
            d.OnBeforeLoadGrid += OnBeforeload;
        }

        void OnBeforeload(object sender, GridEventArg e)
        {
            Console.WriteLine($"Before grid load event at {e.MsgTime} !");
        }
    }

    public class SubscriberAfterEvent
    {
        public SubscriberAfterEvent(TTTGrid grid)
        {
            IAfterLoadGrid d = (IAfterLoadGrid)grid;
            d.OnAfterLoadGrid += OnAfterload;
        }

        void OnAfterload(object sender, GridEventArg e)
        {
            Console.WriteLine($"After grid load event at {e.MsgTime} !");
        }
    }
    public class EventWithInterface
    {
        static void Main(string[] args)
        {
            var tttgrid = new TTTGrid();
            var subBeforeEvent = new SubscriberBeforeEvent(tttgrid);
            var subAfterEvent = new SubscriberAfterEvent(tttgrid);

            tttgrid.LoadGrid();

            System.Console.ReadKey();
        
        }
    }
}
