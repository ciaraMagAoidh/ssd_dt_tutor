int num1, num2;

Console.WriteLine("Enter number 1:");
num1 = Convert.toInt32(Console.ReadLine());

Console.WriteLine("Enter number 2:");
num2 = Convert.toInt32(Console.ReadLine());

if(num1 == num2)
    Console.WriteLine(num1 + " is equal to " + num2);
else 
    Console.WriteLine(num1 + " is not equal to " + num2);
