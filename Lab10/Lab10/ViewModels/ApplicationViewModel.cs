using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab10.Models;

namespace Lab10.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Student _selectedStudent;

        public ObservableCollection<Student> Students { get; set; }
        public Student SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }

        public ApplicationViewModel()
        {
            Students = new ObservableCollection<Student>
            {
                new Student() {Id = 1, Name = "Vladimir", Average = 10, Course = 2, Group = 1, Profession = "ISaT"},
                new Student() {Id = 2, Name = "Ivan", Average = 8, Course = 1, Group = 6, Profession = "POIT"},
                new Student() {Id = 3, Name = "Dmitry", Average = 1, Course = 5, Group = 2, Profession = "ISaT"},
                new Student() {Id = 4, Name = "Sasha", Average = 4.5, Course = 4, Group = 1, Profession = "ISaT"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
