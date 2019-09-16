using Lab13.Prototype;

namespace Lab13.AbstractFactory
{
    public class Warrior : IWarrior
    {
        private readonly Weapon _weapon;
        private readonly WarriorsFactory _factory;

        public Warrior(WarriorsFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _factory = factory;
        }

        public void Hit()
        {
            _weapon.Hit();
        }

        public IWarrior Clone()
        {
            return new Warrior(_factory);
        }
    }
}
