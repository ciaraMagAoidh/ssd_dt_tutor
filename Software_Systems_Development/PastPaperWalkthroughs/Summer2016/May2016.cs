//1 false, true, false, true, true, false

//2 (a)
if(saleAmount >= 75.00 && rating != 'C')
{
    discountRate = 0.1;
}

//2 (b)

//method to print sentence
public void printSentence()
{
    Console.WriteLine(containsThe("the quick brown fox jumped over the lazy dog"))
}

//method to check sentence
public string containsThe(string sentence)
{
    string word;

    if(sentence.Contains(" the "))
    {
        sentence = sentence.Replace(" the ", " a ")
        for(int i = 0; i < sentence.Length - 3; i++)
        {
            if(sentence.subString(x,3) == " a ")
            {
                word = sentence.subString(x+3, 2);

                switch(word[0])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        sentence = sentence.subString(0, x+2) + 'n' + sentence.subString(x+2);
                        break:

                }
            }
        }
        return "changed sentence: " + sentence;
    }
    else
    {
        return "no change to sentence: " + sentence;
    }
}


//3(a)
public Booking(int bookingNo, string clientName, char package, DateTime bookingDate, int noInParty)
{
    this.bookingNo = bookingNo;
    this.clientName = clientName;
    this.package = package;
    this.bookingDate = bookingDate;
    this.noInParty = noInParty;
}

public int getNoInParty(){
    return this.noInParty;
}

public void setNoInParty(int noInParty){
    this.noInParty = noInParty;
}

public double getCost()
{
    double cost = 0.00;

    switch(package)
    {
        case 'A':
            cost  = 50.00;
            break:
        case 'B':
            cost = 75.00;
            break:
        case 'C':
            cost = 125.00;
            if (noInParty >= 6)
            {
                cost *= 1.15 * noInParty;
            }
            break:
        case 'D':
            cost = 395.00;
            if (noInParty >= 6)
            {
                cost *= 1.15 * noInParty;
            }
            break:
    }
    return cost;
}

//3(b)(i)
//instantion of object type Booking
//method call for today's date from class DateTime

//3(b)(ii)
Console.Write("\n\n\t Outstanding Cost is {0:.00} " , booking.calcOutstandingCost() ); 

//4(a)(i)
/*
data type – alphabetic, numeric, alphanumeric;
 format – A999 letter followed by three digits, email address;
 range – number lying between 2.00 and 15.00;
 presence – surname, forename, address exists;
 compatibility – height/weight;
 dependancy – cost/selling price
 */

 //4(a)(ii)
 //noInParty - presence, type, range

 //4(b)(i)
 /*
 //try, catch,finally
 //many classes inbuilt for exception
 //example error messages
 //apply appropriate checks to a value before the field is SET
 //error causes throw of an exception object
 //customised classes must extend the exception class
  */

//4 (b)(ii)
try
{
    //try to execute block of code
}
catch // (...Exceptions)  if Exception is used to it last
{
    //if error occurs code flow drops to the catch
}
finally
{
    //finally block gets executed whether or not there is an exception
}

//5(a)
/*
Accommodation has been defined as abstract. Abstract classes cannot be instantiated from but serve as a definition for class derivation.
Sub classes of Accommodation will be more specific but must have their own instances of abstract members
*/

//5(b)
public double incomeYear(){
    return rent * noRentPaymentsPerYear;
}

//5(c)(i) derived class Flat
public class Flat : Housing
{
    private double maintenanceCharge;

    public Flat(int accommodationNo, string address1, string address2, string postcode, double valuation, double rent, int noRentPaymentsPerYear, string type, int noBedrooms, int noCarParkingSites)
        :base(accommodationNo, address1, address2, postcode, valuation, rent, noRentPaymentsPerYear, type, noBedrooms, noCarParkingSites))
    {
        this.maintenanceCharge = maintenanceCharge;
    }

    public int getMaintenanceCharge(){
        return this.maintenanceCharge;
    }

    public void setMaintenanceCharge(double maintenanceCharge){
        this.maintenanceCharge = maintenanceCharge;
    }
}

//5(c)(ii)
public override double incomeYear()
{
    double cost = base.incomeYear() + maintenanceCharge;
    return cost;
}

//5(c)(iii) @override

//5 (d)
Accommodation[] accAr = new Accommodation[50];
double totalAnnualIncome = 0.00;
for(int i = 0; i < accArr.Length; i++){
    totalAnnualIncome += accArr[i].incomeYear();
}
Console.WriteLine("Total Annual Income: {0:C}",totalAnnualIncome);

//6 (a)
/*
– implements an interface
 – to allow comparison of two objects
 – return type is integer-0 if same, -ve if smaller,+ve if greater.
 – Allows use of Array/Arrays class
 – Sort an array of objects
 – applies structure
 – inherits methods
 – empty methods in interface
 – polymorphism
 – stimulates multiple inheritance
*/


//6 (b)
public int CompareTo(Object obj){
    Accommodation other = obj as Accomodation;
    return this.rent.CompareTo(other.rent);
}

//6 (c)
Array.Sort(accArray);
Console.WriteLine("\n\tProperties in order of rent charged\n\n”);
for (int x = 0; x < accArray.Length; x++)
{
 Console.WriteLine(accArray[x].ToString());
} 