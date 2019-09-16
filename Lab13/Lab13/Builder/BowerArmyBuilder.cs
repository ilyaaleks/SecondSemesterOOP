using Lab13.AbstractFactory;

namespace Lab13.Builder
{
    public class BowerArmyBuilder : ArmyBuilder
    {
        public override void SetWarriors()
        {
            Army.Warrior1 = new Warrior(new BowerFactory(Box));
            Army.Warrior2 = new Warrior(new BowerFactory(Box));
        }
    }
}