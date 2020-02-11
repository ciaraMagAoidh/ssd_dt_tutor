/*
1 define encapsulation, inheritance, polymorphism with regards to object orientated development
 */

/*
2(a) 3 advantages of methods
*/

// 2(b)
public double findCost(char style, int size)
{
    double cost = 0.00;

    switch(style)
    {
        case 'S':
            cost = 120.00;
            break;
        case 'R':
            cost = 139.99;
            break;
        case 'I':
            cost = 215.00;
            break;
        case 'C':
            cost = 349.99;
            break;
    }      

    if(size == 2){
        cost *= 1.5;
    }

    //apply VAT
    cost *= 1.2;
}

// 2(c)
char style;
int size;
double cost;

Console.WriteLine("Enter S fpr Square, R fot Rectangle, I for Igloo, C for Castle");
style = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Enter 1 for Standard or 2 for Deluxe");
size = Convert.ToInt32(Console.ReadLine());

cost = findCost(style, size);

Console.WriteLine("here is the cost {0:C}", cost);


// 3(a)
//field constructor
public Loan(string loanCode, double amount, int noOfYears)
{
    this.loanCode = loanCode;
    this.amount = amount;
    this.noOfYears = noOfYears;
}

//GET and SET for the field amount only
public double getAmount(){
    return this.amount;
}
public void setAmount(double amount){
    this.amount = amount;
}

//method to determine actual rate of interest
public double getActualRate()
{
    double baseRate = 0.0;

    if(amount <= 50000){
        baseRate = 5;
    } else if (amount > 50000 && amount <= 150000){
        baseRate = 5.25;
    } else {
        baseRate = 6.05;
    }

    if (noOfYears >= 7){
        baseRate -= 0.5
    }
}

/// 3(b)(i)
Loan aLoan = new Loan(loanCode, amount, noOfYears);

// 3(b)(ii)
actualRate = aLoan.getActualRate();

Console.WriteLine("Actual rate of interest: {0}", actualRate);

//4 (a)
//Exception, IOException, FileNotFoundException,NumberFormatException, IndexOutOfRangeException

// 4 (b)
try
{
    //try to execute body of try - jump to catch block on error
}
catch /*(......) */
{
    //hierarchial block
    //Exception if used it goes last
}
finally
{
    //block of code executed whether or not errors occur
}

// 4 (c)
//set loan code method
public string setLoanCode(string loanCode)
{
    if (!validCode(loanCode))
    {
        throw new LoanException("Invalid Loan Code");
    } 
    else 
    {
        this.loanCode = loanCode;
    }
}

//method to check if code is valid
public bool validCode(string loanCode)
{
    bool isValid = true;
    string twoChar;
    string digits;

    if(loanCode.length != 8){
        isValid = false;
    }

    twoChar = loanCode.subString(0,2);
    digits = loanCode.subString(2);

    switch(twoChar)
    {
        case "CA":
            break;
        case "CI":
            break;
        case "MA":
            break;
        default:
            isValid = false;
    }

    if(digits.All(Char.IsDigit()))
    {
        int number = digits.Convert.ToInt32();

        if(number < 100000 || number > 199999){
            isValid = false;
        }
    }

    return isValid;
}

//5 (a) abstract

//5 (b)
public double calc_Income()
{
    double income = ratePerDay * noRentalsPerDate;
}

//5 (c) define the class car using inheritance
class Car : Vehicle
{
    private string regNo;
    private int power;
    private char satNav;

    public Car():base()
    {
        this.regNo = "";
        this.power = 0;
        this.satNav '';
    }

    public Car(int vehicleNo, string make, string model, string colour, double ratePerDay, int noRentalsPerDate, string regNo, int power, char satNav)
        :base(vehicleNo, make, model, colour, ratePerDay, noRentalsPerDate)
    {
        this.regNo = regNo;
        this.power = power;
        this.satNav = satNav;
    }
    
    public string getRegNo(){
        return this.regNo;
    }
    public int getPower(){
        return this.power;
    }
    public char getSatNav(){
        return this.satNav;
    }

    public void setRegNo(string regNo){
        this.regNo = regNo;
    }
    public void setPower(int power){
        this.power = power;
    }
    public void setSatNav(char satNav){
        this.satNav = satNav;
    }

    @Override
    public string toString(){
        return base.toString + "\nregNo: " + this.regNo + "\npower: " + this.power + "\nsatNav: " + satNave;
    }
}

//5(d)(i)
@Override
public double calc_Income()
{
    double increaseRate = 1;
    double income = base.calc_Income();

    switch(satNav)
    {
        case 'A':
            increaseRate = 1.0;
            break;
        case 'B':
            increaseRate = 1.04;
            break;
        case 'C':
            increaseRate = 1.075;
            break;
    }

    income *= increaseRate;

    return income;
}

//5(d)(ii)
//method overriding

//6(a)
Vehicle[] vehicleArray = new Vehicle[150];

//6(b)
vehicleArray{0} =  //sample details of car (base data , car data)

//6(c)
//output total income for green rentals.
double totalIncome = 0;

for(int i=0; i<vehicleArray.length; i++)
{
    totalIncome += vehicleArray[i]].calc_Income();
}
Console.WriteLine("total income: " + totalIncome);



