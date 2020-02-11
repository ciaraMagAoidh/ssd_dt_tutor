int option;

label:

Console.WriteLine("Press 1 for Monday");
Console.WriteLine("Press 2 for Tuesday");
Console.WriteLine("Press 3 for Wednesday");
Console.WriteLine("Press 4 for Thursday");
Console.WriteLine("Press 5 for Friday");
Console.WriteLine("Press 6 for Saturday");
Console.WriteLine("Press 7 for Sunday");

Console.WriteLine("\n\nEnter a number:\t\t");
option = Convert.ToInt32(Console.ReadLine());

switch(option)
{
	case 1:
		Console.WriteLine("Monday");
		break;
	case 2:
		Console.WriteLine("Tuesday");
		break;
	case 3:
		Console.WriteLine("Wednesday");
		break;
	case 4:
		Console.WriteLine("Thursday");
		break;
	case 5:
		Console.WriteLine("Friday");
		break;
	case 6:
		Console.WriteLine("Saturday");
		break;
	case 7:
		Console.WriteLine("Sunday");
		break;
	default:
		Console.WriteLine("\nInvalid option. Enter a number between 1 and 7");
		goto label;
}
Console.ReadLine();

