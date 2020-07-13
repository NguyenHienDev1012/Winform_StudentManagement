using System;
using System.Collections.Generic;

namespace QuanLySinhVien.Properties.Model
{
    public class ClassRoom
    {
        private string id;
        private string name;
        private List<Student> _listStudent= new List<Student>();

        public ClassRoom(string id, string name, List<Student> listStudent)
        {
            this.id = id;
            this.name = name;
            _listStudent = listStudent;
        }
        
        public ClassRoom()
        {
            
        }
        public ClassRoom(string id, string name)
        {
            this.id = id;
            this.name = name;
            _listStudent = new List<Student>();
        }
        public void addStudent(Student student)
        {
            this._listStudent.Add(student);
            
        }

        public  bool editStudent(Student student)
        {
            bool isOK=false;
            foreach (var s in _listStudent)
            {
                if (s.Id.Equals(student.Id))
                {
                    s.Name = student.Name;
                    s.Gender = student.Gender;
                    s.Address = student.Address;
                   // s.ClassId = student.ClassId;
                    s.Phone = student.Phone;
                    isOK = true;
                    return isOK;
                }
                
            }
            return isOK;
        }

        public Student getStudent(string idStudent)
        {
            foreach (var s in _listStudent)
            {
                if (s.Id.Equals(idStudent))
                {
                    return s;
                }
                
            }
            return null;
        }
        public bool deleteStudent(string idStudent)
        {
            bool isOK = false;
            for (int i = 0; i <this. _listStudent.Count; i++)
            {
                Student student = _listStudent[i];
                if (student.Id.Equals(idStudent))
                {
                    this._listStudent.Remove(_listStudent[i]);
                }

                isOK = true;
            }
            return isOK;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Student> ListStudent
        {
            get => _listStudent;
            set => _listStudent = value;
        }

        public string printStudent()
        {
            string values = "  ";
            foreach (var student in _listStudent)
            {
               values+= student.ToString();
            }
            return values;
        }
        public override string ToString()
        {
            return "Id" +this.id + "name"+this.name +"listStudent" +this.printStudent();
        }
    }
  
    
}