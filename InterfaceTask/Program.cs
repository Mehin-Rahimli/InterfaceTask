namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Student student1 = new Student("Mehin","Rahimli");
            Student student2 = new Student("Salam", "Salamov");
            Student student3 = new Student("Bob", "Gilbert");
            Student student4 = new Student("Ilham", "Zamanov");
            Group groupA = new Group("Group A");
            groupA.AddStudent(student1);
            groupA.AddStudent(student2);
            groupA.AddStudent(student3);
            groupA.AddStudent(student4);

            Student student5 = new Student("Xanim", "Muradli");
            Student student6 = new Student("Damon", "Salvatore");
            Student student7= new Student("Fatime", "Isayeva");
            Student student8 = new Student("Tuncay", "Muradli");
            Group groupB = new Group("Group B");
            groupB.AddStudent(student5);
            groupB.AddStudent(student6);
            groupB.AddStudent(student7);
            groupB.AddStudent(student8);
           

            Group.ShowAllGroups();
        }
    }
}
