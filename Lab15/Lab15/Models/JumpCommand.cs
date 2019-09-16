using System.Windows.Controls;
using Lab15.Command;

namespace Lab15.Models
{
    public class JumpCommand : ICommand
    {
        public void Execute(TextBlock block)
        {
            Jump(block);
        }

        private void Jump(TextBlock block)
        {
            block.Text += "Jump.\n";
        }
    }
}
