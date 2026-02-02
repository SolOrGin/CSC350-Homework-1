using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScore = new int[] {92, 89, 81, 96, 90};
int[] emmaScore = new int[] {90, 85, 87, 98, 68};
int[] loganScore = new int[] {90, 95, 87, 88, 96};

int sophiaSum = 0;
decimal sophiaScore;

foreach (int score in sophiaScores)
{
    sophiaSum += score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;  //so here we convert the in sophiaSum to a decimal or in c++ a float

Console.WriteLine("Student\t\tGrade\n");                    //I see we can use \t for tab and \n for new line like in c++
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();