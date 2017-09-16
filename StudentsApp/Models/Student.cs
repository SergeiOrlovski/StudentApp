namespace StudentsApp.Models
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Student(int id,string fname, string lname, int age, string gender)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Age = age;
            Gender = gender;
        }
    }
}
