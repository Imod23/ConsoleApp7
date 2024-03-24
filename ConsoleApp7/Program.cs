namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student01 = new Student(001, "Nimal", "Gampaha", 56);
            Student student2 = new Student(002, "Nimali", "Gampola", 66);


            student1.Address = "Kandy";
            Console.WriteLine(student1.HasPassed());
            Console.WriteLine(student2.HasPassed());



            Console.ReadLine();
        }
    }
}
