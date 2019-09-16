using System.Windows.Media;

namespace Lab14.Decorator
{
    public abstract class WeaponDecorator : Weapon
    {
        protected Weapon Weapon;
        public WeaponDecorator(string name, Weapon weapon) : base(name)
        {
            Weapon = weapon;
        }
    }
}
