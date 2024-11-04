using System;

Console.Write("Enter an number: ");
string num1 = Console.ReadLine();

Console.Write("Enter a second number: ");
string num2 = Console.ReadLine();
int num1_int = Convert.ToInt32(num1);
int num2_int = Convert.ToInt32(num2);

Console.WriteLine("1: Addition");
Console.WriteLine("2: Subtraction");
Console.WriteLine("3: Multiplication");
Console.WriteLine("4: Division");
Console.WriteLine("5: Modulo");
Console.WriteLine("6: Exponent");

Console.Write("Enter an operation: ");
string operationStr = Console.ReadLine();
int operation = Convert.ToInt32(operationStr);

if (operation >= 1 && operation <= 6)
{
  if (operation == 1) {
    Console.WriteLine($"The result is: {num1_int + num2_int}");
  }
  if (operation == 2) {
    Console.WriteLine($"The result is {num1_int - num2_int}");
  }
  if (operation == 3) {
    Console.WriteLine($"The result is {num1_int * num2_int}");
  }
  if (operation == 4) {
    Console.WriteLine($"The result is {num1_int / num2_int}");
  }
  if (operation == 5) {
    Console.WriteLine($"The result is {num1_int % num2_int}");
  }
  if (operation == 6) {
    Console.WriteLine($"The result is {Math.Pow(num1_int, num2_int)}");
  }
}
else
{
  Console.WriteLine("Invalid input");
}
