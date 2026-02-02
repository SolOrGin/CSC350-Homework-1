using System;

// initialize variables - graded assignments 
int examAssignments= 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

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

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

        else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    
    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        
        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        
        else
            sumAssignmentScores += score / 10;

        // okay so the counter makes sure that each time it loops it is supposed to follow the original now changed variable examAssignments 
        // so that the 10% weighing factor happens to the extra credit before being added other wise the exam scores will be inflated
    }

    currentStudentGrade = (decimal)sumAssignmentScores/ examAssignments;  
    //so here we convert the in sophiaSum to a decimal or in c++ a float
    //moving away from sophia now and making it anyone, any student. 
    // why is it (decimal)(sumAssignmentScores)? okay I see this is optional and safe but looks like optional

    //Console.WriteLine("Student\t\tGrade\n");                    //I see we can use \t for tab and \n for new line like in c++
    //Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();