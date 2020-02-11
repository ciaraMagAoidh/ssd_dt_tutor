/*
q1
instantiation - the creation of an object (term)
 
inheritance - the creation of a new class that reuses, extends, and modified the behaviour
    that is defined in another class (term)

explain derived classes - a class which inherits the visible properties, methods, and events of
    the super/base class and can be customised with additional properties, methods, and extends
    (definition)

explain polymorphism - a primary concept of object-orientated programming which allows sub/derived class
    methods to be invoked through a super/base class reference during runtime. enabled through
    late binding and overriding
    (definition)

explain late binding - the connection by a polymorphic base object to an overriding method during runtime
    when the object type is known. used in polymorphism
    (definition)
*/

/*
q2
2(a)(i) field types
*/
class Client
{
    private int clientNo;
    private string companyName;
    private DateTime dateJoined;
    private string telNo;
    private string passWord;
    private char rating; //this one is given
}
/* 
2(a)(ii) field constructor
*/
public Client(clientNo, companyName, dateJoined, telNo, passWord){
    this.clientNo = clientNo;
    this.companyName = companyName;
    this.dateJoined = dateJoined;
    this.telNo = telNO;
    this.passWord = password
    this.rating = 'A';
}

/* 
2(a)(iii) get and set
*/

//Method 1
public char getRating(){
    return this.rating;
}
public void setRating(char rating){
    this.rating = rating;
}
//Method 2
public char Rating {
    get{ return rating;}
    set { rating = value;}
}



/* 
2(b) method + conditional statement
 */
public double MaximumCredit(){
    double maximumCredit = 0.;
    switch(this.rating){
        case 'A':
            maximumCredit = 2500.0;
            break;
        case 'B':
            maximumCredit = 7500.0;
            break;
        case 'C':
            maximumCredit = 10000.00;
            break;
        case 'X':
            break;
        default:
            break;    
    }
}
 /*
 3(a)(i) public in a method, static in a method
 */
 //public -> an access modifier. the most permissive access level. 
 //     there are no restrictions on accessing public members
//      -> visibility, allows access by all classes
 //static -> used to declare a static member which belongs to the 
 //     type itself rather than a specific object
 //      -> single instance - use class name to access


 /* 
 3(a)(ii) call to a public method (not string)
 */
  Math.Pi(); Char.IsDigit();
 /* 
 3(b) password validation with string functions
  */
 public boolean validPassword(string password){
     int countUpper = 0, countDigit = 0, countSpace = 0;

     for(int i=0; i<password.Length; i++){
         if(Char.IsDigit(password[i]))
            countDigit++;
        else
        {
            if(Char.IsUpper(password[x]))
            //or
            //if((Iny16)password[x] >= 65 && (Int16)password[x] <= 90)
            //ASCII 65 - 90 is the upper case characters. 
            //Int16 because hexadecimal and each hex value is a bytes ( 8 bits)
                countUpper++;
            else{
                if(Char.IsWhiteSpace(password[x]))
                    countSpace++;
            }
        }
     }

     if(countDigit > 1 && countUpper > 0 && password.Length >=7 && countSpace==0)
        return true;
    else
        return false;


 }

  /*
  4(a) error trapping class and type of error caught
    IOException - Trap any Input Error such as unavailable file
 
  4(b)(i)  explain exception
    Base Class for Exception Handling, handles all exceptiond
    Places last in catch sequence

  4(b)(ii) error trapping for invalid telephone no
   */
   if(!validTelNo(value)){
       throw new Exception("Error - invalid telephone number");
   }
   else{
       telNo = value;
   }

  /*
  4(b)(iii) how to implement error trap for invalid number in field constructor
    Use property setting to implement the check

  4(c) how should a new telephone number be handled to ensure program won't crash
     - loop around data entry
    - use try catch
    - try around set of new telNo
    - catch Exception
    - output returned exception message in the catch
    - by a message box / error Provider
    - set error flag
   */

   /*
   5(a) Override
   5(b)(i) derived class
    */
    public class Wedding : Party{
        //field declaration
        private int[] noRooms = new int[2];

        //constructor
        public Wedding(int eventNo, String description, double pricePerHead,
            int noBooked, DateTime dateOfEvent, String bandName, double bandCost,
            int tableType, int[] noRooms) : base (eventNo, description, pricePerHead, noBooked,
            dateOfEvent, bandName, bandCost, tableType)
        {
                this.noRooms = noRooms;
            
        }
        
        //get and set methods

        //method 1
        public int[] noRooms{
            set {noRooms = value;}
            get { return noRooms;}
        }

        //method 2
        public setNoRooms(value){
            this.noRooms = value;
        }
        public int[] getNoRooms(){
            return this.noRooms;
        }
    }
   /*
   5(b)(ii) array calculation
    */
    public double costOfRooms(){
        double total = 0.0;
        double[] prices = {175.0, 130.0};
        for(int xc=c0; x < noRooms.Length; x++){
            total += noRooms[x] * prices[x];
            return total;
        }
    }
   /*
   5(b)(iii) calculation + method call
    */
    public override double income(){
        return base.income() + costOfRooms();
    }
    /*
    6(a) loop array and find total sum
     */
     double total = 0.0;
     for(int x = 0; x < arrayEvent.Length; x++){
         total += arrayEvent[x].income();
     }
     Console.WriteLine(String.Format("{0:-30}{1:c}", "Income for all events is ", total));
    /*
    6(b) code to out additional info
     */
     double totalWedding = 0.0;
     int countWedding = 0;
     for(int x = 0; x < arrayEvent.Length; x++){
         if(arrayEvent[x].GetType() == typeof(Wedding))
         //or
         //if(arrayEvent[x] is Wedding)
         {
             totalWedding += ((Wedding)arrayEvent[x]).income();
             countWedding++;
         }
     }
     Console. Writeline (String.Format {0:–30} {1:c},"Income for Wedding", totalWedding)
     Console. Writeline (String.Format ({0:–30} {1}, "Number of Weddings", countWedding)




