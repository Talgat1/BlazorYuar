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
        public int Kurs { get; set; }
        public string Post { get; set; }
        
        public Student(string sur, string name, int year, int kurs, string post)
        {            
            sur = Sur;
            name = Name;
            year = Year;
            kurs = Kurs;
            post = Post;

        }

        public Student()
        {
        }

        public static List<Student> AddSt()
        {
            List<Student> st = new List<Student>();
            st.Add(new Student() { Sur = "Иванов", Name = "Иван", Year = 16, Kurs = 1});
            st.Add(new Student() { Sur = "Смирнов", Name = "Иван", Year = 17, Kurs = 2});
            st.Add(new Student() { Sur = "Иванова", Name = "Марина", Year = 18, Kurs = 3});
            st.Add(new Student() { Sur = "Кушин", Name = "Александр", Year = 16, Kurs = 1});
            st.Add(new Student() { Sur = "Рожкова", Name = "Мария", Year = 17, Kurs = 2});
            return st;
            
        }
        /*public Task<Student[]> GetListSt()
        {
            
            return List<Student>();
        }

        private Task<Student[]> List<Student>()
        {
            throw new NotImplementedException();
        }*/
    }

}

    
