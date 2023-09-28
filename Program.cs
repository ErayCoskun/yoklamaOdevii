namespace yoklamaOdevi;

internal class Program
{
    static void Main()
    {
        List<string> students = new List<string>
        {
            "1.Alpha",
            "2.Bravo",
            "3.Charlie",
            "4.Delta",
            "5.Echo"
        };

        Console.WriteLine("Hi, this is my students!");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        while (true)
        {
            Console.WriteLine("Enter student number for attendance :");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int studentNumber))
            {
                Console.WriteLine("Error: You must enter a valid integer.");
                continue;
            }

            if (studentNumber < 1 || studentNumber > students.Count)
            {
                Console.WriteLine("Error: You must enter a valid student number.");
                continue;
            }

            string student = students[studentNumber - 1];
            if (student.StartsWith("X"))
            {
                Console.WriteLine("Error: This student is already marked in the class.");
            }
            else
            {
                students[studentNumber - 1] = "X" + student.Substring(1);
                Console.WriteLine(student + " marked as in class.");
            }

            if (students.TrueForAll(s => s.StartsWith("X")))
            {
                Console.WriteLine("All students are marked as in class.");
                break;
            }
        }
    }
}