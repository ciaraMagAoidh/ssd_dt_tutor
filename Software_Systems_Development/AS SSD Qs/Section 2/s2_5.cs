char input;

Console.Write("Enter character");
char = Console.ReadLine();

if(input.toLower() == 'a'||input.toLower() == 'e' || input.toLower() == 'i' || input.toLower() == 'o'
	||input.toLower() == 'u')
		{
			Console.WriteLine("input character is a vowel")
		}
else
{
	Console.WriteLine("input character is not a vowel");
}

Console.ReadLine();