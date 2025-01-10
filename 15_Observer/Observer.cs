using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Observer
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;


        public ConcreteObserver(
            ConcreteSubject subject,
            string name
            )
        {
            this.subject = subject;
            this.name = name;
        }


        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine($"Observer {name} new state is {observerState}");
        }

        public ConcreteSubject Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }
    }
}
