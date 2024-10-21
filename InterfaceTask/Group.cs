using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class Group 
    {
        public static Group[] groups = new Group[0];
        static int GroupCount = 0;
        public int GroupId { get; set; }
        public string GroupName { get; set ; }
        public Student[] students = new Student[0];
        public Group(string groupname)
        {
            GroupName = groupname;
            GroupId = ++ GroupCount;
            AddGruop(this);
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"GroupId:{GroupId},Gruop Name:{GroupName},The Number of students{students.Length} ");

        }
        public string GetStudentId(int id)
        {
            for(int i=0;i<students.Length; i++)
            {
                if (students[i]!=null && id == students[i].Id)
                {

                    return $"{students[i].Name} {students[i].Surname}";
                }
                
            }return null;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;

        }

        public void Search(string name)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (name == students[i].Name || name ==students[i]. Surname)
                {
                    Console.WriteLine($"{students[i].Name} {students[i].Surname} {students[i].Id} {students[i].CodeEmail}");
                }
            }
        }

        public void RemoveStudent(string student)
        {
            Student[] newarr = new Student[students.Length - 1];
            int j = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name != student) ;
                newarr[j] = students[i];
                j++;
            }
            students = newarr;
        }

        public void ShowStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {

                Console.WriteLine(students[i].Name + " "+students[i].Surname);
            }

        }

        public static void ShowAllGroups()
        {
            for (int i = 0; i<groups.Length; i++)
            {
                Console.WriteLine(groups[i].GroupId +" "+ groups[i].GroupName );
                groups[i].ShowStudents();
            }
        }

        public static void AddGruop(Group group)
        {
            Array.Resize(ref groups,groups.Length +1);
            groups[groups.Length - 1] = group;
        }

        public static void RemoveGroup(string group)
        {
            Group[] newarr2 = new Group[groups.Length - 1];
            int j = 0;
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].students[i].Name != group)
                {
                    newarr2[j] = groups[i];
                }
            }
            groups = newarr2;
        }
       
    }
}
