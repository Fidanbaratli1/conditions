var num1 = 12;
var num2 = 45;
var op = '*';
switch (op)
{
    case '+':
        Console.WriteLine(num1 + num2);
        break;
    case '-':
        Console.WriteLine(num1 - num2);
        break;
    case '*':
        Console.WriteLine(num1 * num2);
        break;
    case '/':
        Console.WriteLine(num1 / num2);
        break;
    default:
        Console.WriteLine("invalid input");
        break;
}