namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "students.csv";

            var students = File.ReadAllLines(filePath)
                .Select(line => new {
                    Name = line.Split(',')[0],
                    Grades = line.Split(',').Skip(1).Select(int.Parse)
                })
                .Select(student => new {
                    student.Name,
                    AverageScore = student.Grades.Average()
                })
                .Where(student => student.AverageScore >= 3)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} has an average score of {student.AverageScore}");
            }
        }
    }
}