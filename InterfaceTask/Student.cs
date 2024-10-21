using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class Student:ICodeAcademy
    {
        private static int s_count = 0;
        public int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
            Id = ++s_count;
            CodeEmail =GenerateEmail();
        }
        public static string Capitalize(string name, string surname)
        {
            return name.Trim().Substring(0, 1).ToUpper() + name.Substring(1).ToLower() + surname.Trim().Substring(0, 1).ToUpper() + surname.Substring(1).ToLower();
        }
        public static bool CheckName(string name)
        {
            if (name.Length >= 3 && name.Length <= 25)
            {
                return true;
            }
            return false;
        }

        public  string GenerateEmail()
        {
            return $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az"; 
        }

       
    }
}
