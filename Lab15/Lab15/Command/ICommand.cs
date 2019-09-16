using System.Windows.Controls;

namespace Lab15.Command
{
    public interface ICommand
    {
        void Execute(TextBlock block);
    }
}
