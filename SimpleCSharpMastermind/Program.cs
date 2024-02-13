
using System.Text;

var random = new Random();
var attempts = 10;
var enteredNumber = string.Empty;
var randomNumber = string.Empty;
var plusResult = new StringBuilder();
var minusResult = new StringBuilder();

Console.WriteLine("This is a simple version of the game MasterMind.");
Console.WriteLine("A random number will be generated with a length of 4 and each digit will be between 1 and 6.");
Console.WriteLine("Try and guess the number by entering a number with a length of 4 and each digit between 1 and 6.");
Console.WriteLine("After entering each guess a '+' will be displayed for each correct digit in the correct position");
Console.WriteLine("  and a '-' will be displayed for each correct digit in the wrong position.");
Console.WriteLine("You will have 10 tries to match the random number.");
Console.WriteLine();

//Generate random number
StringBuilder sb = new StringBuilder(); 
for (int j = 1; j < 5; j++)
{
    sb.Append(random.Next(1, 6));
}
randomNumber = sb.ToString();
Console.WriteLine("The random number is " +  randomNumber); 

//Provide 10 attempts
for (int i = 1; i <= attempts; i++)
{
    enteredNumber = string.Empty;

    //Capture user input
    while (enteredNumber?.Length != 4)
    {
        Console.WriteLine("Attempt " + i + ": Enter a 4 digit number with each number between 1 and 6:");
        enteredNumber = Console.ReadLine();
    }

    if (enteredNumber == randomNumber)
    {
        Console.WriteLine("Congradulations! You entered the matching number.");
        break;
    }
    else
    {
        for (int k = 0; k < 4; k++)
        {
           CheckNumber(k);
        }
    }
    Console.WriteLine(plusResult.ToString() + minusResult.ToString());
    plusResult = new StringBuilder();
    minusResult = new StringBuilder();
}

Console.WriteLine("Sorry. The random number was " + randomNumber);

void CheckNumber(int digitPosition)
{
    if (randomNumber[digitPosition] == enteredNumber[digitPosition])
        plusResult.Append("+");
    else if (randomNumber.Contains(enteredNumber[digitPosition]))
        minusResult.Append("-");
    else
        return;
}