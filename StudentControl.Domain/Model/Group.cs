using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControl.Domain.Model
{
    public enum Formofstudy
    {
        Full_time,
        Part_time
    }
    public class Group
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;
        public int NumberOfPeople { get; set; } = 0;
        public Formofstudy Formofstudy { get; set; }
        public string StudyProfile { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new List<Student>();

        public bool AddStudent(Student student)
        {
            if(Students.Contains(student)) return false;
            student.SetGroup(this);
            Students.Add(student);
            NumberOfPeople++;
            return true;

        }

        public bool RemoveStudent(Student student)
        {
            if (Students.Contains(student))
            {
                Students.Remove(student);
                NumberOfPeople--;
                return true;
            }
            return false;
        }
    }
}
