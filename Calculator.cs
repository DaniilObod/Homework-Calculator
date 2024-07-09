bool continueCalculation = true;

while (continueCalculation)
{
    Console.WriteLine("Enter the First Number");
    double number1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Choose an operation (+, -, *, /):");
    string operation = Console.ReadLine();
    Console.WriteLine("Enter the second number:");
    double number2 = Convert.ToDouble(Console.ReadLine());

    double result = 0;

    if (operation == "+")
    {
        result = number1 + number2;
    }
    else if (operation == "-")
    {
        result = number1 - number2;
    }
    else if (operation == "*")
    {
        result = number1 * number2;
    }
    else if (operation == "/")
    {
        if (number2 != 0)
        {
            result = number1 / number2;
        }
        else
        {
            Console.WriteLine("Error");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Error");
        continue; 
    }

    Console.WriteLine($"The Result is {result}");

    Console.WriteLine("Do you want to perform another calculation? (yes/no):");
    string continueResponse = Console.ReadLine().ToLower();

    if (continueResponse != "yes")
    {
        continueCalculation = false;
    }
}
