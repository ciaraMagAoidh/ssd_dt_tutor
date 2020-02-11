int i = 0;

Console.Write("Enter a number");
i = Convert.ToInt32(Console.ReadLine());

if((i % 2) == 0)
{
	Console.WriteLine("Even number");
}
else
{
	Console.WriteLine("Odd number");
}

Console.ReadLine();