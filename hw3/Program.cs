//question1
List<double> grades = new List<double>();
Console.WriteLine("Enter grades one by one.Enter -1 to finish.");
while(true)
{
    Console.Write("Enter your grades: ");
    string input = Console.ReadLine();
    int grade = int.Parse(input);
    if (double.TryParse(input, out double gradeDouble))
    {
        if (grade == -1)
        {
            break;
        }
        if (grade < 0)
        {
            Console.WriteLine("Grade cannot be negative. Please enter a valid grade.");
            continue;
        }
        grades.Add(grade);
    }
    else
    {
        Console.WriteLine("Invalid input.Please enter a valid grade.");
    }
}
if (grades.Count == 0)
{
    Console.WriteLine("no grades were entered.");
    return;
}
int count = grades.Count;
double sum = grades.Sum();
double average = sum / count;
double highest = grades.Max();
double lowest = grades.Min();

Console.WriteLine("\n-------  Grade Statistics -------");
Console.WriteLine($"Count: {count}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average:F2}");
Console.WriteLine($"Highest: {highest}");
Console.WriteLine($"Lowest: {lowest}");

/*question2
int n = 0;
while (true)
{
    Console.WriteLine("Enter a number between 1 and 10: ");
    string input = Console.ReadLine();
    if (int.TryParse(input,out n) && n >= 1 && n <= 10)
    {
        break;
    }
    Console.WriteLine("Invalid input. Please enter a number between 1 and 10: ");
}
Console.WriteLine($"\n---------- Multiplication Table for {n} ----------");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}
*/