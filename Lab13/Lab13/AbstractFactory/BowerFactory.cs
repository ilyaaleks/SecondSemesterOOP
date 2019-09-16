using System.Windows.Controls;

namespace Lab13.AbstractFactory
{
    public class BowerFactory : WarriorsFactory
    {
        private readonly TextBox _box;
        public BowerFactory(TextBox box)
        {
            _box = box;
            _box.Text += "\nBower created";
        }
        public override Weapon CreateWeapon()
        {
            return new Bow(_box);
        }
    }
}
