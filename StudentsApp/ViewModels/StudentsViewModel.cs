using GalaSoft.MvvmLight;
using StudentsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.ViewModels
{
    public class StudentsViewModel : BaseViewModel
    {
        private readonly IStudent _student;

        public StudentsViewModel(IStudent student)
        {
            _student = student;
        }

        public int Id
        {
            get { return _student.Id; }
            set
            {
                _student.Id = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get { return _student.FirstName; }
            set
            {
                _student.FirstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _student.LastName; }
            set
            {
                _student.LastName = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get { return _student.Age; }
            set
            {
                _student.Age = value;
                OnPropertyChanged();
            }
        }

        public string Gender
        {
            get { return _student.Gender; }
            set
            {
                _student.Gender = value;
                OnPropertyChanged();
            }
        }
    }
}
