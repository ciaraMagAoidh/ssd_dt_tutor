 int year;
 bool isLeap = false;
 Console.WriteLine("Enter a year:");
 year = Convert.toInt32(Console.ReadLine());

 if( year % 4 == 0){
     if(year % 100 == 0 && year % 400 > 0)
        isLeap = false;
    isLeap = true
 }

 Console.WriteLine(year + " is a leap year: " + isLeap);
 