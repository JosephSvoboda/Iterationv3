

int[] myArray = null;

int[] otherArray = new int[0];

var userInput = "";
int age;
bool proceed;
int number = 0;
int num1 = 0;
int num2 = 0;
int num = 0;
var num3 = 0;

do
{

    Console.WriteLine($"How old is the potential voter?");
    userInput = Console.ReadLine();
    proceed = int.TryParse(userInput, out age);

} while (!proceed);


LotsOfNumbers();
RandomNumbers();
VotingAge(age);
EvenOrOdd(number);
IsItPositive(num1);
PlusThree();
AreTheySameNumbers(num1, num2);
IsRangeOfTen(num);





/// <summary>
/// Write a method
/// that takes a number from the user
/// and returns an array with that many indexes.
/// The values shall be random numbers.
///
/// 
/// </summary>
/// <returns></returns>
static int[] RandomNumbers()
{
    Console.WriteLine($"How many items would you like in your array?");

    var userInput = int.Parse(Console.ReadLine());

    var newArray = new int[userInput];

    for (int i = 0; i < newArray.Length; i++)
    {
        var random = new Random();

        newArray[i] = random.Next(1, 100);
    }

    return newArray;
}



/// <summary>
/// Write a method to read the age of a candidate
/// and determine whether they can vote.
/// Hint: use Parse()... or the safer TryParse() for an extra challenge!!
///
/// pseudo code:
/// the way I'll go about this is
///  if age >= 18 - yes they can vote
///
/// converted pseudo into actual code
/// if(age >= 18)
/// {
///   return true;</summary>
/// }<param name="age"></param>
/// <returns></returns>
static bool VotingAge(int age)
{
    if (age >= 18)
    {
        Console.WriteLine($"You are of voting age!");
        return true;
    }
    else
    {
        Console.WriteLine($"You are too young to vote by {18 - age} years");
        return false;
    }
}

//Write a method
//to check whether a given number is even or odd.

//where do i write this method?
//outside the main method and inside the scope of the Program class - DONE!
static void EvenOrOdd(int number)
{
    Console.Write("Type a number to see if it is EVEN or ODD: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.WriteLine($"That number is even!");
    }
    else
    {
        Console.WriteLine($"That number is odd!");
    }

}

/// <summary>
/// Write a method to check whether a given number is positive or negative.
/// </summary>
/// <param name="num1"></param>
/// <returns></returns>
//
//need to write a method, but how?
//access modifier
//static keyword
//return type
//method name
//parameters
//scope
static bool IsItPositive(int num1)
{
    //need to determine if its negative or positive - DONE!
    Console.Write("Type a number to see if it is positive or negative: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 > 0)
    {
        Console.WriteLine("That number is Positive!");
        return true;
    }
    Console.WriteLine("That number is Negative!");
    return false;

}

//Write a method that will print to the console numbers 3 through 999 by 3 each time.

//step 1: where do I write this method?
// outside the scope of the main method - but inside the scope of the Progam class

//step 2: How do I define a method?
//2a: access modifier
//2b: static keyword
//2c: return type - void: lack of a return type
//2d: name of method
//2e: parameters - and do we need any?
//2f: scope - this is where the method will do what our end goal is

static void PlusThree()
{
    //i need code execute a certain number of times - how can i do this?
    // with a for loop
    //how do I a write a for loop
    for (int i = 3; i <= 999; i += 3)
    {
        //what will i do in the scope of the for loop?
        //console writeline
        Console.WriteLine($"{i}");
    }
}
static void LotsOfNumbers()
{
    for (int i = 1000; i >= -1000; i--)
        Console.WriteLine($"{i}");
}


//step 1: find out where I can write my method
//right here
//if you dont know - try it somewhere - come back to this later

//step 2: find out how to define the method
//step 2a: remember the pieces that make a method
//1b.access modifier
//public
//2b.static keyword
//static
//3b.return type
//ask myself - what is the result of this method?  Lets find a type for that result
//bool - true or false: are these 2 numbers the same? (yes or no)
//4b.name of the method
//AreTwoNumbersTheSame
//5b.parameters
//i know there will be 2 parameters
//i know that they will be integers
//I just need to name them - they can be named whatever I want
//int num1, int num2
//6b.scope
//starts with curly braces / ends with curly braces
//this is what my method will do!
//this is where the result will occur - bool value (return type)

static bool AreTheySameNumbers(int num1, int num2)
{
    
    //we want to compare the 2 numbers - how do we do that?
    //num1 != num2
    //found our way of comparing to numbers but now we need a structure to use that comparison - DONE!
    Console.Write("Write 2 numbers to see if they are the same number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 != num2)
    {
        Console.WriteLine("These are NOT the same numbers.");
        return false;
    }
    else
    {
        Console.WriteLine("These ARE the same numbers.");
        return true;
    }
}


//Write a method to check if an integer (from the user) is in the range -10 to 10 - DONE!
static bool IsRangeOfTen(int num)
{
    Console.Write("Type a number to see if it is between -10 and 10: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num <= 10 && num >= -10)
    {
        Console.WriteLine("That number is within -10 and 10!");
        return true;
    }
    Console.WriteLine("That number is NOT within -10 and 10!");
    return false;
}