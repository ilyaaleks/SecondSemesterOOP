using System.Windows.Controls;
using Lab15.Models;

namespace Lab15.State
{
    public class FlyingState : IObjectState
    {
        public void HandleInput(TextBlock block)
        {
            block.Text += $"Object is flying.\n";
        }

        public void Update(MyObject myObject)
        {
            myObject.ChangeState(this);
        }
    }
}
