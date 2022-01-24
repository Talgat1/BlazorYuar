using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorYuar.Data
{
    public class Student
    {
        
        public string Sur { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Faculty { get; set; }
        public static List<Student> st = new List<Student>();

        public Student(string sur, string name, int year, string faculty)
        {            
            Sur = sur;
            Name = name;
            Year = year;
            Faculty = faculty;          
        }

        public static void AddToList(string surnamep, string namep, int year, string facultyp)
        {
            Student std = new Student(surnamep, namep, year, facultyp);
            st.Add(std);
        }
        public Student()
        {
        }

        public static List<Student> AddSt()
        {
            //List<Student> st = new List<Student>();
            st.Add(new Student() { Sur = "Иванов", Name = "Иван", Year = 16, Faculty = "Программист" });
            st.Add(new Student() { Sur = "Смирнов", Name = "Иван", Year = 17, Faculty = "Программист" });
            st.Add(new Student() { Sur = "Иванова", Name = "Марина", Year = 18, Faculty = "Программист" });
            st.Add(new Student() { Sur = "Кушин", Name = "Александр", Year = 16, Faculty = "Программист" });
            st.Add(new Student() { Sur = "Рожкова", Name = "Мария", Year = 17, Faculty = "Программист" });
            return st;            
        }
    }
}

    
