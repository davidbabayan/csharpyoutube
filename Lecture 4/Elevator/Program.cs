// փոփոխականներ
int maxFloor = 10;
int currentFloor = 1;
int orderedFloor = 0;
bool isOrder = false;

Console.WriteLine("Welcome to elevator program!");
Console.WriteLine("Our building have 10 floors!");
Console.WriteLine("The elevator is on 1st floor!");

asking_floor:
isOrder = false;
Console.Write("Enter your floor: ");
orderedFloor = int.Parse(Console.ReadLine());

moving_elevator:
if(orderedFloor > maxFloor)
{
    Console.WriteLine($"Our building have only {maxFloor}!\nPlease enter correct floor!");
    if (isOrder)
    {
        goto order_move;
    }
    goto asking_floor;
}

for (; currentFloor != orderedFloor;)
{
    Console.WriteLine($"The elevator is on {currentFloor}!");
    if(currentFloor > orderedFloor)
    {
        currentFloor--;
    }
    else
    {
        currentFloor++;
    }
}

Console.WriteLine("The elevator is here!");
Console.Beep();
isOrder = !isOrder;
if(!isOrder)
{
    goto asking_floor;
}

order_move:
isOrder = true;
Console.Write("Which floor you want to go? ");
orderedFloor = int.Parse(Console.ReadLine());

goto moving_elevator;
