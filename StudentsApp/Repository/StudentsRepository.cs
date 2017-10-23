using StudentsApp.Models;
using System.Collections.Generic;

namespace StudentsApp.Repository
{
    public abstract class StudentsRepository
    {
        public abstract IList<IStudent> GetStudents();
        public abstract void AddStudent(IStudent student);
        public abstract void UpdateStudent(IStudent student);
        public abstract void DeleteStudent(IStudent student);
    }
}
