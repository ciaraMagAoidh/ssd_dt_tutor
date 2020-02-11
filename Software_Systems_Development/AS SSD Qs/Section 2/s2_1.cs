string name;
int Hours;
double  RateOfPay, GrossPay, Tax, NI, NETTPAY;
Console.WriteLine("Enter your name");
name=Console.ReadLine();
Console.WriteLine("How many hours do you work");
Hours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your rate of pay?");
RateOfPay = Convert.ToDouble(Console.ReadLine());
GrossPay = Hours * RateOfPay;
Tax = GrossPay * 0.20;
NI = GrossPay * 0.104;
NETTPAY = GrossPay - (Tax + NI);

//output
Console.WriteLine("\n\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Name:\t\t{0}", name);
Console.WriteLine("Hours:\t\t{0}", Hours);
Console.WriteLine("Rate Of Pay:\t{0:C}", RateOfPay);
Console.WriteLine("Gross Pay:\t{0:C}", GrossPay);
Console.WriteLine("Tax:\t\t{0:C}", Tax);
Console.WriteLine("N.I:\t\t{0:C}", NI);
Console.Write("NETTPAY;\t{0:C}", NETTPAY);
Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.ReadLine();