namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Student student1 = new Student("mEhin","RaHimLI");
            Student student2 = new Student("salam", "salamov");
            Student student3 = new Student("Bob", "gilbert");
            Student student4 = new Student("ilham", "eliyev");
            Group groupA = new Group("Group A");
            groupA.AddStudent(student1);
            groupA.AddStudent(student2);
            groupA.AddStudent(student3);
            groupA.AddStudent(student4);

            Student student5 = new Student("xanim", "muradli");
            Student student6 = new Student("mehriban", "israfilova");
            Student student7= new Student("fatime", "isayeva");
            Student student8 = new Student("tuncay", "muradli");
            Group groupB = new Group("Group B");
            groupB.AddStudent(student5);
            groupB.AddStudent(student6);
            groupB.AddStudent(student7);
            groupB.AddStudent(student8);



            Group.ShowAllGroups();
        }
    }
}
