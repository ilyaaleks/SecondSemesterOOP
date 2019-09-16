using Lab13.AbstractFactory;
using Lab13.Builder;
using Lab13.Singleton;

namespace Lab13
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateObjects(object sender, System.Windows.RoutedEventArgs e)
        {
            var swordman = new Warrior(new SwordmanFactory(BattleLog));
            swordman.Hit();
            var bower = new Warrior(new BowerFactory(BattleLog));
            bower.Hit();
            var general = General.GetInstance(BattleLog);
            ArmyBuilder armyBuilder = new BowerArmyBuilder();
            general.MoveArmy(armyBuilder);
        }
    }
}
