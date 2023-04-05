using System;
using System.Collections.Generic;

namespace VisitorNS
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }

    public class HouseComponent : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitHouseComponent(this);
        }

        public string ExclusiveMethodOfHouseComponent()
        {
            return "House Component";
        }
    }

    public class BankComponent : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "BankComponent";
        }
    }
    public interface IVisitor
    {
        void VisitHouseComponent(HouseComponent element);

        void VisitConcreteComponentB(BankComponent element);
    }
    class ConcreteVisitor1 : IVisitor
    {
        public void VisitHouseComponent(HouseComponent element)
        {
            Console.WriteLine(element.ExclusiveMethodOfHouseComponent() + " + ConcreteVisitor1");
        }

        public void VisitConcreteComponentB(BankComponent element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
        }
    }

    class ConcreteVisitor2 : IVisitor
    {
        public void VisitHouseComponent(HouseComponent element)
        {
            Console.WriteLine(element.ExclusiveMethodOfHouseComponent() + " + ConcreteVisitor2");
        }

        public void VisitConcreteComponentB(BankComponent element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2");
        }
    }

    public class Client
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }

   
}
