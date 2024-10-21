namespace AbstractionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("ulvi rasulov", "ulvi@mail.com", "password123");
            user.ShowInfo();

            Group group = new Group("AB107", 10);

            Student student1 = new Student("student studentov", 85);
            Student student2 = new Student("studentka studentova", 92);
            Student student3 = new Student("telebe telebezade", 78);

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            Student foundStudent = group.GetStudent(2);
            if (foundStudent != null)
            {
                Console.WriteLine(foundStudent.FullName);
            }
            else
            {
                Console.WriteLine("tapilmadi!!!!!!");
            }
        }
    }
}
