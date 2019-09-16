using Lab15.Models;
using Lab15.State;

namespace Lab15.Memento
{
    public class Memento
    {
        public IObjectState State { get; set; }
        public Memento(MyObject myObject)
        {
            State = myObject.State;
        }

        public void Restorer(ref MyObject myObject)
        {
            myObject.ChangeState(State);
        }
    }
}
