using System.Windows.Controls;
using Lab13.Builder;

namespace Lab13.Singleton
{
    public class General
    {
        private static TextBox _box;
        private static General _general;

        private General() { }
        public static General GetInstance(TextBox box)
        {
            _box = box;
            if (_general == null)
            {
                _box.Text += "\nGeneral created.";
                _general = new General();
            }
            else
            {
                _box.Text += "\nGeneral already exists.";
            }
            return _general;
        }

        public Army MoveArmy(ArmyBuilder builder)
        {
            builder.Box = _box;
            builder.CreateArmy();
            builder.SetWarriors();
            return builder.Army;
        }
    }
}
