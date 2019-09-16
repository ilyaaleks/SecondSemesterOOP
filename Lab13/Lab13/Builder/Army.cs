using Lab13.AbstractFactory;
using System.Windows.Controls;

namespace Lab13.Builder
{
    public class Army
    {
        public Warrior Warrior1 { get; set; }
        public Warrior Warrior2 { get; set; }

        private readonly TextBox _box;

        public Army(TextBox box)
        {
            _box = box;
            _box.Text += "\nArmy created.";
        }
    }
}
