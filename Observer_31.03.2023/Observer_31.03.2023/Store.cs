using System.Collections.Generic;
using System;


namespace Observer
{

    public interface IStore
    {
        void Attach(ISubscriber subscriber);

        void Detach(ISubscriber subscriber);

        void Notify();
    }
    public class Store : IStore
    {
        public int State { get; set; } = -0;

        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Attach(ISubscriber subscriber)
        {
            Console.WriteLine($"Store теперь оповестит подписчика {subscriber}");
            this._subscribers.Add(subscriber);
        }

        public void Detach(ISubscriber subscriber)
        {
            this._subscribers.Remove(subscriber);
            Console.WriteLine("Store: отписали");
        }

        public void Notify()
        {
            Console.WriteLine("Store: Уведомление подписчиков...");

            foreach (var sub in _subscribers)
            {
                sub.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            this.State = new Random().Next(0, 10);
            Console.WriteLine("\nStore: В магазин приехало " + this.State + " телефонов");
            this.Notify();
        }
    }
}
