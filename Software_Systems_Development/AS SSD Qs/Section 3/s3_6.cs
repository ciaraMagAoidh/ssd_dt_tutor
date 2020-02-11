double celsius, fahrenheit, kelvin;

Console.WriteLine("Enter a temperature in Celsius:");
celsius = Convert.toDouble(Console.ReadLine());

fahrenheit  = (celsius * 9/5) + 32;
kelvin = celsius + 273.15;

Console.WriteLine("{0:2} in celsius is {1:2} in fahrenheit and {2:2} in kelvin");