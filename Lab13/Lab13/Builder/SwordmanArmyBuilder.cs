using Lab13.AbstractFactory;

namespace Lab13.Builder
{
    public class SwordmanArmyBuilder : ArmyBuilder
    {
        public override void SetWarriors()
        {
            Army.Warrior1 = new Warrior(new SwordmanFactory(Box));
            Army.Warrior2 = new Warrior(new SwordmanFactory(Box));
        }
    }
}