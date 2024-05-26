namespace Task3
{
    public static class Program
    {
        public static void Main()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            student1.AddGrade("Raksana", new List<int> { 100, 95,80 } );
            student2.AddGrade("Samira", new List<int> { 60, 70, 70 });
            student1.GetAverageGrade();
            student2.RemoveGrade("Samira");
            student1.AddGrade("Raksana", new List<int> { 90, 100, 12 });
            student1.GetAverageGrade();
            student1.GetAllGradesByStudents("Raksana");
            student1.GetAllGradesByStudents("Samira");
            Console.ReadLine();



        }
    }
}