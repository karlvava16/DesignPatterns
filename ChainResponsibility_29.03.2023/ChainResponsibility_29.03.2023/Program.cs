// Паттерн Цепочка обязанностей
//
// Назначение: Позволяет передавать запросы последовательно по цепочке
// обработчиков. Каждый последующий обработчик решает, может ли он обработать
// запрос сам и стоит ли передавать запрос дальше по цепи.

using System;
using System.Collections.Generic;

namespace ChainResponsibility
{
    // Интерфейс Обработчика объявляет метод построения цепочки обработчиков. Он
    // также объявляет метод для выполнения запроса.
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        IHandler GetHandler();
        object Handle(object request);
    }

    // Поведение цепочки по умолчанию может быть реализовано внутри базового
    // класса обработчика.
    abstract class PaymentHanlder : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Возврат обработчика отсюда позволит связать обработчики простым
            // способом, вот так:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public IHandler GetHandler()
        {
            return _nextHandler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class MoneyPaymentHandler : PaymentHanlder
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return "Payment";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class PayPalPaymentHandler : PaymentHanlder
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class BankPaymentHandler : PaymentHanlder
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        // Обычно клиентский код приспособлен для работы с единственным
        // обработчиком. В большинстве случаев клиенту даже неизвестно, что этот
        // обработчик является частью цепочки.
        public static void ClientCode(PaymentHanlder handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Другая часть клиентского кода создает саму цепочку.
            var money = new MoneyPaymentHandler();
            var paypal = new PayPalPaymentHandler();
            var bank = new BankPaymentHandler();

            money.SetNext(paypal).SetNext(bank);

            // Клиент должен иметь возможность отправлять запрос любому
            // обработчику, а не только первому в цепочке.
            Console.WriteLine("Chain: money > paypal > bank\n");
            Client.ClientCode(money);
            Console.WriteLine();

            Console.WriteLine("Subchain: paypal > bank\n");
            Client.ClientCode(paypal);
        }
    }
}
