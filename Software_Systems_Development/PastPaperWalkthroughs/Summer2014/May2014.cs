/* 1.
behaviour, instantiation, encapsulation, implements, characteristics, related, single, multiple, reuses
 */

 /* 2(a)
 -public method declarations so method can be accessed outside the class in which they are written
 - static the method belong to the class and not individual objects
 -int and void are return types, int says return and int, void days not looking to return anyhting specific
 -enter_No_of_items and displayMessage are method names, methods are called using their names
 -inside the brackets are parameter (int min, int max) -> primitive types 
 (int row, int col, String message)-> two primitive types and one reference type
  */

//2(b)
public static int enter_No_Of_Items(int min, int max)
{
    //data declaration
    int noOfItems = 0;

    //prompt
    Console.WriteLine("Enter number of items bought");
    //input
    noOfItems = Convert.ToInt32(Console.ReadLine());

    //range check
    if(noOfItems < min || noOfItems > max)
    {
        Console.WriteLine("Value is outside of range");
        return -1;
    } 
    return noOfItems;
}

//2(c)
public static bool validTelephoneNo(String telNo)
{
    //data declaration
    bool isValid = true;
    int start = 0;

    //length check
    if (telNo.length < 9)
    {
        isValid = false;
    }

    // + character check
    if( telNo.charAt[0] == '+')
    {
        start = 1
    }

    //digit check
    for( int i = start; i < telNo.length; i++)
    {
        if(!Character.isDigit(telNo.charAt[i]))
        {
            isValid = false;
        }
    }
    
    //return true/false
    return isValid;
}

//2(d)
noOfItems = enter_No_Of_Items(10, 50);
validTelNo = validTelephoneNo(telNo);


//3(a)
//field constructor
public Hamper(double weight, char nextDayDelivery){
    this.weight = weight;
    this.nextDayDelivery = nextDayDelivery;
}

//GET and SET methods
public double getWeight(){
    return this.getWeight;
}
public char getNextDayDelivery(){
    return this.nextDayDelivery;
}
public void setWeight(double weight){
    this.weight = weight;
}
public void setNextDayDelivery(char nextDayDelivery){
    this.nextDayDelivery = nextDayDelivery;
}

//method to determine delivery cost
public double getCost()
{
    double cost = 0.00;

    if(weight < 5){
        cost = 2.5;
    } else if (weight >= 5 && weight <= 9.99){
        cost = 4.25;
    } else if (weight >= 10 && weight <= 15){
        cost = 10;
    } else {
        cost = 16;
    }

    if (nextDayDelivery == 'Y'){
        cost *= 1.3;
    }

    return cost;
}

/* 4(a)
-three key aspects of array
-how can array be instantiated
-how first item can be instantiated
 */

 //4(b)
 int total = 0;
 double average = 0.00;
 int count = 0;

 for( int i = 0; i < rainfall.length; i++)
 {
     total += rainfall[i];
 }

 average = Convert.toDouble(total) / rainfall.length;

 for (int i = 0; i < rainfall.length; i++)
 {
     if(rainfall[i] < average)
     {
         count++;
     }
 }

 Console.WriteLine("Days with below average rainfall: {0}", count);

 //4(c)(i)
 //Check if the current number is greater than the target number, if it is exit the loop.

 /* 4(c)(ii)
  Linear search would be slow as each value need to be compared to target value.
  Number of comparision would be large if target value is towards the end of the array.
  Binary search cuts the number of values to be checked by half each iteration.
  */

  //4(c)(iii)
  /*
  (1)
  i 3
  ii 6
  iii 4
  iv 5
  v 6
  (2)
  last < start (start would be 0 and then last would be -1)
   */

   /*
   5 explain how enccapsulation, overloading, overriding facilitate inheritance
    
    give 3 advantages of inheritance
    
    */

//6 (a)
class Sculpture : Artwork
{
    private string material;
    private double height;
    private double weight;

    public Sculpture():base()
    {
        this.material = "";
        this.height = 0.00;
        this.weight = 0.00;
    }

    public Sculpture(int artWorkNo, string title, double price, string artist, string material, double height, double weight)
        : base(int artWorkNo, string title, double price, string artist)
    {
        this.material = material;
        this.height = height;
        this.weight = weight;
    }    

    public string getMaterial(){
        return this.material;
    }
    public double getHeight(){
        return this.height;
    }
    public double getWeight(){
        return this.weight;
    }

    public void setMaterial(string material){
        this.material = material;
    }
    public void setHeight(double height){
        this.height = height;
    }
    public void setWeight(double weight){
        this.weight = weight;
    }

    @Override
    public string toString(){
        return (base.toString + "\nMaterial:{0}\nHeight:{1}\nWeight:{2}", this.material, this.height, this.weight);
    }
}

//6(b)(i)
Artwork[] artWorksArray = new Artwork[50];

//6(b)(ii)
artWorksArray[0] = (102, "a cool sculpture", 45.03, "Ciara", "Stone", 34.5, 23.9);



