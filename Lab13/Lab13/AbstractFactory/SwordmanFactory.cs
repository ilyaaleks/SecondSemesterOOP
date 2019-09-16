using System.Windows.Controls;

namespace Lab13.AbstractFactory
{
    public class SwordmanFactory : WarriorsFactory
    {
        private readonly TextBox _box;
        public SwordmanFactory(TextBox box)
        {
            _box = box;
            _box.Text += "\nSwordman created.";
        }
        public override Weapon CreateWeapon()
        {
            return new Sword(_box);
        }
    }
}
