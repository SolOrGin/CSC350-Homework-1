
//         ** Unit 3 ** 
Random dice = new Random();  //creating an instance of a class (Random) using new operator to create an object called "dice"
int roll = dice.Next(1, 7);    //the (1, 7) shows our dice from 1-6 and this is inside our Next method which capture the time to create an illusion of a random roll
Console.WriteLine(roll);

//To be more precise the dice.Next(1, 7) method assigns a random value to integer named roll. Inside the () we have two arguements the 
// first one "1" is the lower boundary which is inclusive while the second argument is "7" the upper boundry and it is exclusive
// the arguments have to be the same data type as the parameters defined by the method. 


//        ** Unit 4 **
int number = 7;
string text = "seven";

Console.WriteLine(number);   //int
Console.WriteLine();         // no parameter
Console.WriteLine(text);      //string



Random dice2 = new Random();
int roll1 = dice2.Next();        // this method has no boundaries so the method returns values ranging from 0 to 2,147,483,647 which is the max value an int can store
int roll2 = dice2.Next(101);    // this method only specifies upper boundary of 100. this will return values ranging from 0 - 100
int roll3 = dice2.Next(50, 101);   //this method has lower and upper boundaries and it ranges from 50 - 100

Console.WriteLine($"First roll: {roll1}");  
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


//     **Unit 5 **
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);  //Math.Max is the method to find the max, just remember to write the parameters


Console.WriteLine(largerValue);

