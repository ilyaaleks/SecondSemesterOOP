using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Lab10.Models;
using Lab10.ViewModels;

namespace Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public ApplicationViewModel Model { get; set; }
        private static ObservableCollection<Student> def;

        public MainWindow()
        {
            InitializeComponent();
            Model = new ApplicationViewModel();
            def = Model.Students;
            DataContext = Model;
        }

        private void Selector_OnSelected(object sender, RoutedEventArgs e)
        {
            Model.Students = def;
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem item = (ComboBoxItem)comboBox.SelectedItem;
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            var tempS = Model.Students.Where(s => s.Group.ToString().Equals(item.Content)).Select(s => s).ToList();
            Model.Students.Clear();
            for (int i = 0; i < tempS.Count; i++)
            {
                Model.Students.Add(tempS[i]);
            }
            Model.Students = students;
        }
    }
}
