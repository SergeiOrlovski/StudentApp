using StudentsApp.Repository;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using StudentsApp.Commands;
using System.Reflection;
using StudentsApp.Models;
using System;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace StudentsApp.ViewModels
{
    public class StudentsMainViewModel : BaseViewModel
    {
        private StudentsRepository _repo;
        private int _index;

        public ObservableCollection<StudentsViewModel> Students { get; set; }
        public ICommand ViewStudentsCommand { get; private set; }
        public ICommand AddStudentCommand { get; private set; }
        public ICommand DeleteStudentCommand { get; private set; }
        public ICommand UpdateStudentCommand { get; private set; }


        private StudentsViewModel _selectedStudent;

        public StudentsViewModel SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }

        public StudentsMainViewModel()
        {
            Students = new ObservableCollection<StudentsViewModel>();

            AddStudentCommand = new DelegateCommand(p => true, p => AddStudentClick());
            ViewStudentsCommand = new DelegateCommand(p => true, p => ReadStudentsClick());
            DeleteStudentCommand = new DelegateCommand(p => true, p => DeleteStudentsClick());
            UpdateStudentCommand = new DelegateCommand(p => true, p => UpdateStudentsClick());

        }

        private void UpdateStudentsClick()
        {
            if (SelectedStudent != null)
            {
                var selitems = SelectedStudent;
                _repo.UpdateStudent(new Student(selitems.Id, selitems.LastName, selitems.FirstName, selitems.Age, selitems.Gender));
            }
        }

        private void DeleteStudentsClick()
        {
            if (SelectedStudent != null)
            {
                var selitems = SelectedStudent;
                var delStudent = Students.Remove(selitems);
                _repo.DeleteStudent(new Student(selitems.Id, selitems.LastName, selitems.FirstName, selitems.Age, selitems.Gender));
            }


        }

        private void ReadStudentsClick()
        {
            var xmlPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "Students.xml");
            _repo = new XmlStudentsRepository(xmlPath);
            if (Students.Count == 0)
            {
                foreach (var student in _repo.GetStudents())
                {
                    Students.Add(new StudentsViewModel(student));
                    _index++;
                }
            }
        }

        private void AddStudentClick()
        {
            if (Students.Count != 0)
            {
                var newStudent = new Student(_index++, "LastName", "FirstName", 16, "");
                _repo.AddStudent(newStudent);
                Students.Add(new StudentsViewModel(newStudent));
            }

        }
    }
}
