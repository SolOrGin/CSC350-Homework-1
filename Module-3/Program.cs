// ** unit 2 **
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);   //a random int from 1-6
int roll2 = dice.Next(1, 7);    //a random int from 1-6
int roll3 = dice.Next(1, 7);    //a random int from 1-6

int total = roll1 + roll2 + roll3;    //adds our random ints

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");  //display



if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))  // checks if we rolled any doubles by checking if roll1,2,3 are the same and uses logical || or operater. This or this or this
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;         // adds 2 to our total
}

if ((roll1 == roll2) && (roll2 == roll3))   //now we use the and && logical operator to check for triple. If roll1 is the same as 2 and 2 is the same as three then the dice is a triple same
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;       // adds 6
}

//if (total > 14)       this is a boolean expression if the total is greater than 14 than it returns true and console displays "You win!"
if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)        //less than 15 so 14 and under returns true so displays Sorry, you lose
{
    Console.WriteLine("Sorry, you lose.");
}





string message = "The quick brown fox jumps over the lazy dog.";   //we write out a string
bool result = message.Contains("dog");    //the method Contains() searches for the parameter given within the string created message
//then turns true or false into our boolean result variable
Console.WriteLine(result);   //returns the result

if (message.Contains("fox"))         //Here we use it directly in a if statement to check if true or false   if true we go inside the code block
{
    Console.WriteLine("What does the fox say?");   //returns what does the fox say?
}

*/


/*
// ** Unit 3 **

//here we are refining the code so that if there is a triple we also do not add points from rolling a double. Intro to else

Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);


// Temp hardcoding roll
int roll1 = 6;
int roll2 = 6;
int roll = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}"); 
}

//if (total >= 15)
//{
//    Console.WriteLine("You win!");
//}
//else 
//{
//    Console.WriteLine("Sorry, you lose.");
//}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

// introduced to if esle statements but they are very similar to c++ just need to remember cout is Console.WrtieLine("statement")
*/

// ** Unit 4 **
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}

else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}