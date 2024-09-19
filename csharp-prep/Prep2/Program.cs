using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage? ");
        string studentAnswer = Console.ReadLine();
        // Just an additional code for completing the student if passed //
        Console.Write("Enter your first name: ");
        string studentName = Console.ReadLine();
        int percentage = int.Parse(studentAnswer);

        string gradeLetter = "";

        if (percentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (percentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (percentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (percentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");
        
        if (percentage >= 70)
        {
            Console.WriteLine($"Congratulations {studentName}, You passed!");
        }
        else
        {
            Console.WriteLine("Study harder next time:D");
        }
    }
}