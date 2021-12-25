Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if_start:
if (number < 0)
{
    Console.WriteLine("The number is negative!");
}
else if (number > 0)
{
    Console.WriteLine("The number is positive!");
    number--;
}
else
{
    Console.WriteLine("The number is zero!");
}

switch (number)
{
    case 1: goto if_start;
    case 2: Console.WriteLine("Number 2"); break;
    default: Console.WriteLine("Default"); break;
}

switch(number)
{
    case int when number > 0: Console.WriteLine("Positive"); break;
    case int: break;
    default: break;
}

string result = number switch
{
    int num when num > 0 => $"Positive, {num}",
    int num when number < 0 => "Negative"
};
Console.WriteLine(result);
