Int num1, num2, num3, result;

Console.WriteLine("enter first number");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter third number");
num3 = Convert.ToInt32(Console.ReadLine());

result = num1 + num2 - num3;

Console.WriteLine("{0} and {1} minus {2} equals {3}", num1, num2, num3, result);
Console.ReadLine();