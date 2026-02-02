// ** Unit 2 **

/*
string[] fraudulentOrderIDs = new string[3]; //the first set of brackets just tell the computer that fradulentOrderIDs is an array
// the second bracket with a 3 shows the number of elements that the array can hold
// the "new" operator creates a new instance of an array. This is used because we know how many we need bu not what they are yet

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
*/

/*
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ]; // the brackets display invalid expression term but I am able to run

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

// ** Unit 3 **

/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory) // foreach statement iterates through each element in an array 
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/

//. ** Unit 4. **

string[] fraudulentOrderIds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

Console.WriteLine("The fraudulent Ids that starts with 'B'!");
foreach (string ids in fraudulentOrderIds)
{
    if (ids.StartsWith("B"))        //String.StartsWith() method can search that the string starts with depending on the statement in the ()
    {
        Console.WriteLine(ids);
    }
}

