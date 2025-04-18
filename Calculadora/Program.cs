/* Está em inglês porque eu estava usando para estudar C#.
Calculator app for study

It must include just the base arithmetics, sum, subtraction, division and multiplication

1. take input from the user
2. make the mathematics
3. output the result of the problem he gave

everything should be decimal for maximum precision
easier to be separated like so:

first number input
input the desired operation (+, -, /, or *)
second number input

but would be nice if I could find a way to input everything in a single line

PC:

declare variables

decimal first number

string operation

decimal second number

function OperatorDecider 

switch
    case '+':
        decimal result = firstNumber + secondNumber;
        Console.WriteLine(result);

    case '-':
        decimal result = firstNumber - secondNumber;
        Console.WriteLine(result);
    
    case '/':
        decimal result = firstNumber / secondNumber;
        Cons
    case '*':
        decimal result = firstNumber * secondNumber;

return result;
*/


decimal firstNumber = 0;
decimal secondNumber = 0;
decimal result = 0;

string? operation = "";

Calculator();

void Calculator()
{
    Console.WriteLine("Please Insert the first number: ");
    firstNumber = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Now, insert the operator (+, -, *, /): ");
    operation = Console.ReadLine();
    
    Console.WriteLine("And lastly, insert the second number: ");
    secondNumber = Convert.ToDecimal(Console.ReadLine());

    GetResult();

    Console.WriteLine($"The result of your operation is {result}.");
}

decimal GetResult()
{
    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;

        case "-":
            result = firstNumber - secondNumber;
            break;

        case "*":
            result = firstNumber * secondNumber;
            break;

        case "/":
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Divisions by zero are not allowed!");
                return 0;
            }
            break;    

        default:
            Console.WriteLine("Please input a valid operator!");
            break;
    }

    return result;    
}

