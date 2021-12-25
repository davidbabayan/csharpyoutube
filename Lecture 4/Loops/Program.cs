// for foreach while do-while
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number; i++)
{
    if (i == 3)
    {
        continue;
    }
    Console.WriteLine(i);
}

while (number > 0)
{
    Console.WriteLine(number);
    number--;
}

do
{
    Console.WriteLine(number);
}
while (number > 0);
