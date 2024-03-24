namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(001, "Nimal", "Gampaha", 56);
            Student student02 new Student(002, "Nimali", "Gampola", 66);


            student1.Address = "Kandy";
            Console.WriteLine(student1.HasPassed());
            Console.WriteLine(student2.HasPassed());



            Console.ReadLine();
        }
    }
}
