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
        public static List<Student> studlist = new List<Student>();
        //Student stud = new Student();
        //public static List<Student> stli = new List<Student>();
        public Student(string sur, string name, int year, string faculty)
        {            
            Sur = sur;
            Name = name;
            Year = year;
            Faculty = faculty;          
        }

        public Student()
        {
        }

        public static void AddToList(string surnamep, string namep, int year, string facultyp)
        {
            List<Student> lilist = new List<Student>();
            Student stud = new Student(surnamep, namep, year, facultyp);
            //Student.AddToList(studsur, studname, studyear, studfaculty);
            lilist.Add(stud);
        }
       
        public static List<Student> AddSt()
        {
            List<Student> studlist = new List<Student>();
            studlist.Add(new Student() { Sur = "Иванов", Name = "Иван", Year = 16, Faculty = "Программист" });
            studlist.Add(new Student() { Sur = "Смирнов", Name = "Иван", Year = 17, Faculty = "Программист" });
            studlist.Add(new Student() { Sur = "Иванова", Name = "Марина", Year = 18, Faculty = "Программист" });
            studlist.Add(new Student() { Sur = "Кушин", Name = "Александр", Year = 16, Faculty = "Программист" });
            studlist.Add(new Student() { Sur = "Рожкова", Name = "Мария", Year = 17, Faculty = "Программист" });
            //studlist.Add(stud);
            //st.Add(stud);
            return studlist;
           
        }
        public static List<Student> AddLili()
        {
            List<Student> lilist = new List<Student>();
            lilist.Add(new Student() { Sur = "Иванов", Name = "Иван", Year = 16, Faculty = "Программист" });
            lilist.Add(new Student() { Sur = "Смирнов", Name = "Иван", Year = 17, Faculty = "Программист" });
            lilist.Add(new Student() { Sur = "Иванова", Name = "Марина", Year = 18, Faculty = "Программист" });
            lilist.Add(new Student() { Sur = "Кушин", Name = "Александр", Year = 16, Faculty = "Программист" });
            lilist.Add(new Student() { Sur = "Рожкова", Name = "Мария", Year = 17, Faculty = "Программист" });
            //studlist.Add(stud);
            //st.Add(stud);
            return lilist;

        }


    }
}

    
