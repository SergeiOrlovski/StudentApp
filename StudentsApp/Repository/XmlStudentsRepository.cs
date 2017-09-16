using StudentsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace StudentsApp.Repository
{
    public class XmlStudentsRepository: StudentsRepository
    {
        private readonly XDocument _doc;
        private readonly string _fileName;
        
        public XmlStudentsRepository(string fileName)
        {
            _fileName = fileName;
            _doc = XDocument.Load(fileName);
        }

        public override IList<IStudent> GetStudents()
        {
            var result = new List<IStudent>();

            if (_doc.Root != null)
            {
                var students = _doc.Root.Elements();
                foreach (var student in students)
                {
                    int id;
                    var _id = student.Attribute("Id").Value ?? "Unknown";
                    id = Convert.ToInt32(_id);
                    var fname = student.Elements("FirstName").FirstOrDefault()?.Value ?? "Unknown";
                    var lname = student.Elements("Last").FirstOrDefault()?.Value ?? "Unknown";
                    var ageStr = student.Elements("Age").FirstOrDefault()?.Value ?? "Unknown";
                    int age;
                    if (!int.TryParse(ageStr, out age))
                    {
                        age = 20;
                    }
                    var genderStr = student.Elements("Gender").FirstOrDefault()?.Value ?? "Unknown";
                    int gender;
                    if(!int.TryParse(genderStr, out gender))
                    {
                        gender = 1;
                    }
                    string _gender;
                    if (gender == 0)
                    {
                        _gender = "Муж";
                    }
                    else { _gender = "Жен"; }
                    result.Add(new Student(id, fname, lname, age, _gender));
                }
            }
            return result;
        }

        public override void AddStudent(IStudent student)
        {
            var newStudentElement = new XElement("Student");
            newStudentElement.Add(new XAttribute("Id", student.Id));
            newStudentElement.Add(new XElement("FirstName", student.FirstName));
            newStudentElement.Add(new XElement("Last", student.LastName));
            newStudentElement.Add(new XElement("Age", student.Age));
            if (student.Gender == "Муж")
            {
                newStudentElement.Add(new XElement("Gender", 0));
            }
            else
            {
                newStudentElement.Add(new XElement("Gender", 1));
            }

            _doc.Root?.Add(newStudentElement);
            _doc.Save(_fileName);
        }

        public override void UpdateStudent(IStudent student)
        {
            XElement xroot = _doc.Root;
            foreach (XElement xr in xroot.Elements("Student"))
            {
                string id = xr.Attribute("Id").Value;
                if (id == student.Id.ToString())
                {
                    xr.Attribute("Id").Value = student.Id.ToString();
                    xr.Element("FirstName").Value = student.FirstName;
                    xr.Element("Last").Value = student.LastName;
                    xr.Element("Age").Value = student.Age.ToString();
                    if(student.Gender == "Муж")
                    {
                        xr.Element("Gender").Value = String.Format("0");
                    }
                    else { xr.Element("Gender").Value = String.Format("1"); }
                    break;
                }
            }
            _doc.Save(_fileName);
        }

        public override void DeleteStudent(IStudent student)
        {
            XElement xroot = _doc.Root;
            foreach(XElement xr in xroot.Elements("Student"))
            {
                string id = xr.Attribute("Id").Value;
                if(id == student.Id.ToString())
                {
                    xr.Remove();
                    break;
                }
            }
            _doc.Save(_fileName);
        }
    }
}
