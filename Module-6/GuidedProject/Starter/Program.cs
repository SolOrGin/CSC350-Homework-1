using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[] emmaScores = new int[] {90, 85, 87, 98, 68};
int[] loganScores = new int[] {90, 95, 87, 88, 96};

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

foreach (string name in studentNames)
{
    string currentStudent = name;    // so by creating a new variable currentStudent it makes it easier to follow the logic in the code
    // name will loop through the array and currentStudent will make it easy to think about the current student in the looped array
    // as well as checking if the current student follows the if statement(s) (else if)
    
    //Console.WriteLine($"{name}");     //so I noticed that in c++ you do endl; for a new line but in c# you dont need to do that it does it automatically
    
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;  // so we dont need the curly brackets?  okay we do need them but just like c++ we dont need them if one statement is inside the anf if statement
    
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    
    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    
    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)sumAssignmentScores/ currentAssignments;  
    //so here we convert the in sophiaSum to a decimal or in c++ a float
    //moving away from sophia now and making it anyone, any student. 
    // why is it (decimal)(sumAssignmentScores)? okay I see this is optional and safe but looks like optional

    //Console.WriteLine("Student\t\tGrade\n");                    //I see we can use \t for tab and \n for new line like in c++
    //Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();