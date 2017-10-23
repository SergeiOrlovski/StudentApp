using StudentsApp.Models;
using System;

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

        protected override string GetColumnError(string columnName)
        {
            string error = null;

            switch (columnName)
            {
                case "Age":
                    if (Age < 16 || Age > 100)
                    {
                        error = "Age should be in range from 16 to 100!";
                    }
                    break;
                case "FirstName":
                    if (String.IsNullOrEmpty(FirstName))
                    {
                        error = "First name should not be empty!";
                    }
                    break;
                case "LastName":
                    if (String.IsNullOrEmpty(LastName))
                    {
                        error = "Last name should not be empty!";
                    }
                    break;
                case "Gender":
                    if (String.IsNullOrEmpty(Gender))
                    {
                        error = "Gender should not be empty!";
                    }
                    else
                    {
                        if (Gender!="Муж"&&Gender!="Жен")
                        {
                            error = "Gender should be 'Муж' or 'Жен'!";
                        }
                    }
                    break;
            }

            Error = error;
            return error;
        }
    }
}
