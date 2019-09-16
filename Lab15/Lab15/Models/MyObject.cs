using System.Windows.Controls;
using Lab15.State;

namespace Lab15.Models
{
    public class MyObject
    {
        public IObjectState State => _state;

        private IObjectState _state;

        private readonly TextBlock _block;

        public MyObject(TextBlock block)
        {
            _block = block;
            _state = new FlyingState();
        }

        public void ChangeState(IObjectState state)
        {
            _state = state;
        }

        public void ShowState()
        {
            _state.HandleInput(_block);
        }
    }
}
