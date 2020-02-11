/*
1(a) related, single
(b) new, existing, attributes, behaviours
 */

 /* 2 (a)
 discuss primitive types, reference tpyes, and static
  */

//2 (b) discount = 50

//2(c)(i) arguments are passed by value and swapped locally int function, nothing is returned so values remain unchanged
//(ii) pass arguments by reference

/*3(a)
 -private
 -public 
 -protected
 how do they facilitate data encapsulation
 */

/*3(b)
define inheritance and give two advantages
 */

 /* 3(c) 
 difference between method overloading and method overriding
  */

//4 (a)
int enterQtyStock(int min, int max)
{
    //data declaration
    int quantityOfStock = 0;
    
    //prompt
    Console.WriteLine("Enter quantity of stock");
    try
    {
        //does user enter a number
        quantityOfStock = ConvertToInt32(Console.ReadLine());
        //check for range
        if ( quantityOfStock < min || quantityOfStock > max){
            Console.WriteLine("Sorry value entered is outside of range");
        }
        else
        {
            return quantityOfStock;
        }
    }
    catch //any illegal characters that cannot be converted to integers are catched
    {
        Console.WriteLine("Sorry that was not a valid integer");
    }
}

//4(b)
string enterStockCode(){
    //data declaration
    string stockCode = "";
    string twoChar = "";
    string threeDigits = "";
    boolean isValid = true;
    //prompt
    Console.WriteLine("Enter the stock code");

    //input statements
    stockCode = Console.ReadLine();

    //breakdown of string entry
    twoChar = stockCode.subString(0,2);
    threeDigits = stockCode.subString(2);

    //check for a number
    foreach (char in threeDigits)
    {
        if(!char.IsDigit())
        {
            isValid = false;
        }
    }

    //check for valid letters
    switch(twoChar)
    {
        case "BL":
        case "FS":
        case "HJ":
        case "PX":
            break:
        default:
            isValid = false;
            break:
    }

    //return stockCode
    if(isValid)
    {
        return stockCode;
    }
    else 
    {
        return "Stock Code Invalid";
    }
}


//4(c)
stockCode = enterStockCode();
qtyStock = enterQtyStock(10,50);

//5(a)
int[] nums = new int[]{6,21,17,11,76,9,2,91,13,42};

/*5(b)(i)
the value 3 is returned because even though the numRequired is 4th in array
arrays are zero indexed so value returned is at index 3
*/

/*5(b)(ii)
the value -1 is returned becuase the value 50 is not a value at any index in the nums array
 */

 /*5(b)(iii) 
  Sequential search of a large array is slow as each indivdual value in the array musch be checked,
  to determine if the target value is not present.
  Improve by sorting values and including exit code in search algorithm for when value is found
 */

 //5(b)(iv)
 /*
 discuss an example of how code derived from pseudocode could be ammended to enhance
 the search for the modified array
  */

//6(a)(i)
class Album
{
    private int stockNo;
    private string artistName;
    private string albumName;
    private double price;
    private int quantityInStock;
}

//6(a)(ii)
//default constructor
public Album(){
    this.stockNo = 0;
    this.artistName = "";
    this.albumName = "";
    this.price = 0.00;
    this.quantityInStock = 0;
}

//6(a)(iii)
public Album(int stockNo, string artistName, string albumName, double price, int quantityInStock)
{
    this.stockNo = stockNo;
    this.artistName = artistName;
    this.albumName = albumName;
    this.price = price;
    this.quantityInStock = quantityInStock;
}

//6(a)(iv)
public int quantityInStock
{
    get{ return QuantityInStock;}
    set{ quantityInStock = value;}
}
public string AlbumName
{
    get{ return AlbumName;}
    set{ albumName = value;}
}

//6(a)(v)
public void increasesStock( int qty)
{
    this.quantityInStock += qty;
}

//6(b)(i)
Album alb = new Album();

//6(b)(ii)
//prompt user for input data for album and use the set methods to set
//attribute for the objects



