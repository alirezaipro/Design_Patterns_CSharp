using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Memento
{
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string State
        {
            get { return _state; }
        }
    }

    public class Originator
    {
        string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"Originator state is : {_state}");
            }

        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine($"Set memento is called");
            State = memento.State;
        }   
    }

    public class Caretaker
    {
        Memento memento;

        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}

