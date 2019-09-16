using System.Windows.Controls;
using Lab15.Models;

namespace Lab15.State
{
    public interface IObjectState
    {
        void HandleInput(TextBlock block);
        void Update(MyObject myObject);
    }
}
