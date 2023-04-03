using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    public interface ISubscriber
    {
        void Update(IStore subject);
    }

    class PremiumSubscriber : ISubscriber
    {
        public void Update(IStore subject)
        {
            if ((subject as Store).State < 3)
            {
                Console.WriteLine("PremiumSubscriber: О, приехала новая партия товара!");
            }
        }
    }

    class DefaultSubscriber : ISubscriber
    {
        public void Update(IStore subject)
        {
            if ((subject as Store).State == 0 || (subject as Store).State >= 2)
            {
                Console.WriteLine("DefaultSubscriber: О, приехала новая партия товара!");
            }
        }
    }

    
}