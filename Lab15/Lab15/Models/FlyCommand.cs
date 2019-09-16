using System.Windows.Controls;
using Lab15.Command;

namespace Lab15.Models
{
    public class FlyCommand : ICommand
    {
        public void Execute(TextBlock block)
        {
            Fly(block);
        }

        private void Fly(TextBlock block)
        {
            block.Text += "Fly.\n";
        }
    }
}
