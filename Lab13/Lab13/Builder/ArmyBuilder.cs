using System.Windows.Controls;

namespace Lab13.Builder
{
    public abstract class ArmyBuilder
    {
        public Army Army { get; private set; }

        public TextBox Box { get; set; }
        public void CreateArmy()
        {
            Army = new Army(Box);
        }

        public abstract void SetWarriors();
    }
}
