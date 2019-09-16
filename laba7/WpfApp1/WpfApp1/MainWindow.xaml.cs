using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public class DependenctyProperty : DependencyObject
    {
        public static readonly DependencyProperty TitleProperty;
        public DependenctyProperty()
        {

        }
        static DependenctyProperty()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            TitleProperty = DependencyProperty.Register("Title",
                typeof(string),
                typeof(DependenctyProperty),
                metadata,
                new ValidateValueCallback(ValueValidate)
                );


        }
        private static bool ValueValidate(object value)
        {
            if ((string)value == "Илья")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            string currentValue = (string)baseValue;

            return "Неправильно"; // иначе возвращаем текущее значение
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_send_Click(object sender, RoutedEventArgs e)
        {
            DependenctyProperty property = (DependenctyProperty)this.Resources["Property"];
            MessageBox.Show(property.Title.ToString());
        }

        private void TextName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(sender.ToString() + " это тунельное событие");
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(sender.ToString()+Environment.NewLine);
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Закрытие приложения");
            this.Close();
        }
    }
    public class NewCustomCommand
    {
        private static RoutedUICommand pnvCommand;
        static NewCustomCommand()
        {
            InputGestureCollection inputs =
            new InputGestureCollection();
            inputs.Add
            (new KeyGesture(Key.P, ModifierKeys.Alt, "Alt+P"));
            pnvCommand =
            new RoutedUICommand("PNV", "PNV",
            typeof(NewCustomCommand), inputs);
        }
        public static RoutedUICommand PnvCommand
        {
            get { return pnvCommand; }
        }
    }

}
