using System.Windows.Controls;

namespace Lab13.AbstractFactory
{
    public class Sword : Weapon
    {
        private readonly TextBox _box;
        public Sword(TextBox box)
        {
            _box = box;
        }
        public override void Hit()
        {
            _box.Text += "\nHit by sword.";
        }
    }
}
