int a, b, c;

Console.WriteLine("Enter the first number:");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number:");
c = int.Parse(Console.ReadLine());

int getLargest(){
    if( a > b ){
        if( a > c){
            return a;
        }
        else {
            return c;
        }
    } else {
        if(b > c){
            return b;
        } 
        else {
            return c;
        }
    }
}


Console.WriteLine(getLargest() + "is the largest number");