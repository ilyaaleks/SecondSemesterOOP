using System.Windows.Controls;

namespace Lab13.AbstractFactory
{
    public class Bow : Weapon
    {
        private readonly TextBox _box;

        public Bow(TextBox box)
        {
            _box = box;
        }

        public override void Hit()
        {
            _box.Text += "\nHit by bow.";
        }
    }
}
