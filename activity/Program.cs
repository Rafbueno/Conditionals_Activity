namespace activity;

class Program
{
    static void Main(string[] args)
    {
       // Larger number

       Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine()!);

       Console.Write("Enter second number: ");
             int second = int.Parse(Console.ReadLine()!);

            int larger = Math.Max(first, second);

            if (first == second)
    {
     Console.WriteLine("Both numbers are equal.");
}
             else
    {
     Console.WriteLine($"The larger number is: {larger}");
    }

    // Discount calculator

    Console.Write("Enter total order price: £");
string input = Console.ReadLine();        // get input as string
double total = double.Parse(input);       // convert string to number

if (total > 100)
{
    double discounted = total * 0.90;     // apply 10% discount
    Console.WriteLine("Discount applied! New total: £" + discounted);
}
else
{
    Console.WriteLine("No discount applied. Total: £" + total);
}

// traffic ligth system

Console.Write("Enter traffic light colour (red/amber/green): ");
string light = Console.ReadLine().ToLower();

if (light == "red")
    Console.WriteLine("STOP");
else if (light == "amber")
    Console.WriteLine("Slow down");
else if (light == "green")
    Console.WriteLine("GO");
else
    Console.WriteLine("Invalid colour");


    // student grade

    Console.Write("Enter student's exam score (0–100): ");
int score = int.Parse(Console.ReadLine()); // read and convert in one line

if (score < 0 || score > 100)
    Console.WriteLine("Invalid score entered.");
else if (score < 50)
    Console.WriteLine("Grade: Fail");
else if (score <= 69)
    Console.WriteLine("Grade: Pass");
else if (score <= 89)
    Console.WriteLine("Grade: Merit");
else
    Console.WriteLine("Grade: Distinction");

Console.WriteLine("\n=== SWITCH STATEMENT CHALLENGES ===");


// vowels

Console.Write("\nEnter a letter: ");
char letter = char.Parse(Console.ReadLine()); // read input

letter = char.ToLower(letter); // convert to lowercase

switch (letter)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("It's a vowel.");
        break;

    case 'b': case 'c': case 'd': case 'f': case 'g':
    case 'h': case 'j': case 'k': case 'l': case 'm':
    case 'n': case 'p': case 'q': case 'r': case 's':
    case 't': case 'v': case 'w': case 'x': case 'y': case 'z':
        Console.WriteLine("It's a consonant.");
        break;

    default:
        Console.WriteLine("Not a letter.");
        break;
}



    }
}
