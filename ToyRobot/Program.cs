using System;
using ToyRobot;
{
    int option = 0;
    Robot r = new Robot();

prompt: Console.WriteLine("Select an operation by entering the number");
    Console.WriteLine("Place - 1");
    Console.WriteLine("Move - 2");
    Console.WriteLine("Left - 3");
    Console.WriteLine("Right - 4");
    Console.WriteLine("Report - 5");
    Console.WriteLine("Exit - 6");
    try
    {
        option = Convert.ToInt32(Console.ReadLine());
        if (option < 1 && option > 6)
            Console.WriteLine("Invalid selection");
        if (option == 1)
        {
            Place(r);
            goto prompt;
        }
        if (option == 2)
        {
            r.Move();
            goto prompt;
        }
        if (option == 3)
        {
            r.Left();
            goto prompt;
        }
        if (option == 4)
        {
            r.Right();
            goto prompt;
        }
        if (option == 5)
        {
            r.Report();
            goto prompt;
        }
        if (option == 6)
            Environment.Exit(0);
    }
    catch
    {
        Console.WriteLine("Invalid selection");
    }


}

static void Place(Robot r)
{
    int x = 0;
    int y = 0;

    try
    {
        Console.WriteLine("Enter initial x position as integer");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter initial y position as integer");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter initial facing direction from the below list");
        Console.WriteLine("North");
        Console.WriteLine("East");
        Console.WriteLine("South");
        Console.WriteLine("West");
        var isValid = Enum.TryParse(Console.ReadLine(), true, out Facing f);
        if (!isValid)
        {
            Console.WriteLine("Invalid Inputs");
        }
        r.Place(x, y, f);
    }
    catch
    {
        Console.WriteLine("Invalid Inputs");
    }

}
