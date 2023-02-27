{
    //Declaring variables and then inicializing them

    int num1 = 0;
    int num2 = 0;


    Console.WriteLine("Welcome to Console Calculator in c# made by Donjeta\r");
    Console.WriteLine("------------------------------------------------------\n");


    //Asking user to type the first number
    Console.WriteLine("HI!. Please type a number and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    //Asking user to type the second number 
    Console.WriteLine("HI!. Please type another number and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    //Asking user to choose an option
    Console.WriteLine("Choose an option from the following list: ");
    Console.WriteLine("\ta  - ADD");
    Console.WriteLine("\ts  - SUBTRACT");
    Console.WriteLine("\tm  - MULTIPLY");
    Console.WriteLine("\td  - DIVIDE");
    Console.Write("Please type your opinion? ");

    //Let's use a switch statement to do the math

    switch (Console.ReadLine())
    {
        case "a":
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            break;
        case "s":
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            break;
        case "m":
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            break;
        case "d":
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            break;
    }
}



//Let's wait for user to respond before closing
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();

