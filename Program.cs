// See https://aka.ms/new-console-template for more information


int currentAssignments = 5;


// First Plan
//int[] sophiaScores = new int[5];


// Second Plan
int[] sophiaScores = new int[] { 85, 90, 78, 92, 88 };

int sophiaSum = 0;

foreach (int score in sophiaScores)
{
    // add the exam score to the sum
    sophiaSum += score;    
}

decimal sophiaScore =  (decimal)sophiaSum / currentAssignments;


Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();