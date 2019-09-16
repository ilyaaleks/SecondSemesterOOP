using System.Windows.Controls;
using Lab15.Models;

namespace Lab15.State
{
    public class JumpingState : IObjectState
    {
        public void HandleInput(TextBlock block)
        {
            block.Text += $"Object is jumping.\n";
        }

        public void Update(MyObject myObject)
        {
            myObject.ChangeState(this);
        }
    }
}
