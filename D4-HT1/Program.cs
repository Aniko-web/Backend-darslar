string[] student = new string[10];
int[] ball = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"\n{i + 1}-student ismini kiriting: ");
    student[i] = Console.ReadLine();

    Console.Write("Test ballini kiriting: ");
    ball[i] = Convert.ToInt32(Console.ReadLine());
}

int maxGrade = ball.Max();
int minGrade = ball.Min();
int afterall = 0;
int son80 = 0;
int son90 = 0;

for (int i = 0; i <= student.Length; i++)
{
    if (ball[i] == maxGrade)
    {
        Console.WriteLine($"\nEng yuqori ball: {maxGrade} - {student[i]}");
    }

    double ortacha = (double)afterall / student.Length;
    Console.WriteLine($"O'rtacha ball: {ortacha}");

    if (ball[i] == minGrade)
    {
        Console.WriteLine($"Eng past ball: {minGrade} - {student[i]}");
    }
    if (ball[i] > 80)
    {
        son80++;
    }

    if (ball[i] > 90)
    {
        son90++;
    }
}

Console.WriteLine($"80 dan baland olganlar soni: {son80}");
Console.WriteLine($"90 dan baland olganlar soni: {son90}");


Console.WriteLine("\nStudentlar kamayish tartibida:");

for (int i = 0; i <= student.Length; i++)
{
    if (ball[i] > 90)
    {
        Console.WriteLine(student[i] + " - Top");
    }
    else if (ball[i] > 80)
    {
        Console.WriteLine(student[i] + " - Good");
    }
    else if (ball[i] < 70)
    {
        Console.WriteLine(student[i] + " - Fail");
    }
}