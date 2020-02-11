int side1, side2, side3;

Console.WriteLine("Enter the value of the first side:");
side1 = Convert.toInt32(Console.ReadLine());

Console.WriteLine("Enter the value of the second side:");
side2 = Convert.toInt32(Console.ReadLine());

Console.WriteLine("Enter the value of the third side:");
side3 = Convert.toInt32(Console.ReadLine());

if(side1 == side2 && side1 == side3){
    Console.WriteLine("This is an equilateral triangle");
} 
else if (side1 == side2 || side1 == side3 || side2 == side3){
    Console.WriteLine("This is an isosceles triangle");
}
else {
    Console.WriteLine("This is a scalene triangle");
}