using Lab15.Command;
using Lab15.Models;
using Lab15.State;

namespace Lab15
{
    public partial class MainWindow
    {
        private readonly MyObject _myObject;

        private bool _flag;
        public MainWindow()
        {
            InitializeComponent();
            _myObject = new MyObject(ExampleBlock);
            _flag = false;
        }

        private void ShowWork(object sender, System.Windows.RoutedEventArgs e)
        {
            ICommand command = new FlyCommand();
            command.Execute(ExampleBlock);
            command = new JumpCommand();
            command.Execute(ExampleBlock);
        }

        private void ShowObjectState(object sender, System.Windows.RoutedEventArgs e)
        {
            _myObject.ShowState();
        }

        private void ChangeObjectState(object sender, System.Windows.RoutedEventArgs e)
        {
            IObjectState objectState;
            if (_flag)
                objectState = new FlyingState();
            else
            {
                objectState = new JumpingState();
            }

            _flag = !_flag;
            _myObject.ChangeState(objectState);
            ExampleBlock.Text += "State changed.\n";
        }
    }
}
