/*
    1(i) Instantiation
    1(ii) Object - classes
    1(iii) Overloading - signatures
    1(iv) Inheritance
    1(v) Interfaces
    1(vi) Polymorphism - late binding
 */

 /*
    2(a)
 */
    //constant variable to hold the value 20 for the hourly rate
    const int HOURLY_RATE = 20;

    //get set methods for noHours field
    //method 1
    public NoHours{
        get {return noHours;}
        set {noHours = value;}
    }
    //method 2
    public int getNoHourse(){
        return this.noHours;
    }
    public void setNoHours(int value){
        this.noHours = value;
    }

    //method to determine production cost
    public double productionCost(){
        return noHours * HOURLY_RATE + materialCost + specialismCost;
    }

    //method to determine salePrice for a job
    public double salePrice(){
        return productionCost() * 1.4;
    }

    /*
    2(b)(i) explain -> new Job[150];
        Instantiate an array of size 150. 
        Referencing objects of type Job.
        Initialised to null - no references set

    2(b)(ii) Display the details of lamps available for sail,
        assuming that a toString method exists for the class Job to return
        jobNo, description, production cost, and sale price
  */
    int size =72;
    double totalProductionCosts= 0.0;
    for(int x=0; x<size; x++){
        if(jobArray[x].Category == 'A' && jobArray[x].SaleDate.Year ==
            0001)
        { 
            Console.WriteLine(jobArray[x].toString());
            totalProductionCosts+= jobArray[x].ProductionCost();
        }
        Console.WriteLine(“\n\nTotal production cost “ +
        totalProductionCosts);
    }

  /*
    3(a)(i) Name and describe a simple sorting method
        Selection, Bubble, Quick Sort, Insertion
    */

    //3((a)(ii) Using these numbers - 5, 16, 11, 7, 26 - indicate the contents after 
    //    each pass of your chosen sort. Indicate the number of swaps at each pass
    
    /*
        Selection Sort - finds the smallest element in the array and swaps it 
            with the element in the first position, then finds the second smallest element
            in the array and swaps it with the element in the second position. i
            It does this until the entire array is sorted
            O(n^2) performance - It does no more than n swaps
        
                5   16  11  7   26
        pass 1: 5   16  11  7   26 -> start at position 1- no swap
        pass 2: 5   7   11  16  26 -> start at position 2- swap 7 and 16 - the array is now sorted
        pass 3: starting at position 3 no swap 
        pass 4: starting at position 4 no swap -> end of list so terminates
     */

     /*
        Bubble Sort - The algorithm compares two adjacent elements and swaps them if they are
            not in order. The process is repeated until no more swapping is needed
                 5  16  11  7   26
        pass 1:  5  11  7   16  26  -> 2 swaps
        pass 2:  5  7   11  16  26 -> 1 swap - the array is now sorted
        pass 3: no swaps - terminate because the array is sorted

        Reverse Bubble - Bubble sort in Descending order
                5  16  11  7   26
        pass 1: 16 11  7   26  5 
        pass 2: 16 11  26  7   5
        pass 3: 16 26  11  7   5
        pass 4: 26 16  11  7   5
        n-1 passes at most
      */

      /*
        Quicksort Sort - A pivot element is picked (first, last, median, or randomly selected element).
            Once the pivot is picked, the array is partitioned into 2 halves - one half containing
            all the elements less than the pivot and the other containing all the elements greater than
            the pivot. The same process occurs on each half of the array recursively, resulting in a sorted array
            
                 5  16  11  7   26
        pivot = 11
          [ 5  7 ] 11  [ 16  26]  

        left partition pivot = 5
        right partition pivot = 16
          [ 5   7   11  11   26] 

       */

       /*
        Insertion Sort - We have an array of sorted elements on the left and an array of elements
            still to be sorted on the right. Sort the first two elements of the array and put them on the left.
            Take each element on the right and put it in the appropriate position on the left

                     5  16  11  7   26
            pass 1:  [ 5    16 ], [ 11   7   26 ]
            pass 2:  [ 5    11  16 ], [ 7   26 ]
            pass 3:  [ 5    7   11  16 ], [ 26 ]
            pass 4:  [ 5    7   11  16  26 ] 
            pass 4:  [ 5    7   11  16  26 ] -> array sorted, terminate            
        */



    /*
    

    
    3(b)(i) To allow use of the SORT facility class a class header must implement
        the interface called IComparable

        IComparable interface
        Comparable interface

    3(b)(ii)
     Write a method to sort alphabetical order and price categories in ascending order
   */
   public int compareTo(Object obj){
         Product productObj = (Product)obj;
         ///if the categories are the same then sort price
         //strings have their own compareTo method
         if(this.category.compareTo(productObj.category) < 0)
             return -1;
         else if(this.category.compareTo(productObj.category) > 0)
             return 1;
         else
             if(this.price < productObj.price)
                 return -1;
             else if( this.price > productObj.price)
                 return 1;
             else
                 return 0;
        }

   /*
    4(a) Write an output statement to display all details of an item of stock, including stock value
        
    */
    Console.WriteLine(String.Format(“\n {0,-8} {1,–15} {2:D} {3:C} {4:C}”,
        stockNo, model, qtyInStock, price, (qtyInStock * price ));
    /*

    4(b) What ammendment should be made to the class definition to facilitate reading and writing
        stock object to and from a binary file
        c# [Serializable]
        java implements Serializable
    
    4(c) Explain understanding of emboldened terms
        - Open and read the contents of the file Stock.dat into a stream
        - Declare and instantiate a binary formatter object to handle bit patterns
        - Read a pattern from the stream cast as a type StockObject
        - Into the current position in an array of Stock objects
     */

    /*

    4(d) Name two exceptions that would be applicable in the code in oart (c).
        IOException  SerializableException  FileNotFoundException  Exception
    */

    /*
    5(a) Explain the term - abstract - and why it has been applied to a class
        Class Object Cannot Be Instantiated
        More data required to describe valid event type
        Abstract classes cannot be instantiated from but serve as a definition for derivation

    5(b) Write code for a method HostedIncome that will return the income generated from a Hosted Event
     */
     public double HostedIncome(){
         return (ticketcharge - venueChargePerPerson) * noAttended + donation;
     }
    /*
    5(c) Write code for a derived class FlagDay
     */
    //field definitions

    class FlagDay: Event{
        private int noOfBoxes;
        private double[] arrayBoxAmount;

        //default and field constructors
        public FlagDay()
            : base(){
                this noOfBoxes = 0;
        }

        public FlagDay(int eventNo, Date eventDate, String branchName,
            int startTime, int endTime, int noOfBoxes):
                base(eventNo, eventDate, branchName, startTime, endTime){
            this.noOfBoxes = noOfBoxes;
        }

         //getters and setters
         //method 1
         public int NoOfBoxes{
             get { return noOfBoxes;}
             set { this.noOfBoxes = value;
                    arrayBoxAmount = new double[noOfBoxes];}
         }
         //method 2
         public int getNoOfBoxes(){
             return noOfBoxes;
         }
         public void setNoOfBoxes(int value){
             this.noOfBoxes = value;
             arrayBoxAmount = new double[noOfBoxes];
         }

         //toString() method
    }
    
    /*

    5(d) Write code for the method FlagDayIncome()
     */
     public double FlagDayIncome(){
         double total = 0.0;
         for(int i= 0; i < arrayBoxAmount.Length; i++)
            total += arrayBoxAmount[x];
        return total;
     }

     /*
     6 Complete the body of code for a method that will return the total income for an individual fund-raising branch
      */
        public double BranchIncome (Event [ ] arrayEvent, String requiredBranch, int currentSize)
        {
            double total = 0.0;
            for( int x =0; x< currentSize; x++)
            {
                if(arrayEvent[x].BranchName.CompareTo (requiredBranch) ==0)
                {
                    if (arrayEvent[x].GetType() == typeof( Hosted))
                    OR if (arrayEvent[x] is Hosted)
                        total += ((Hosted)arrayEvent[x]).HostedIncome();
                    else
                        total += ((FlagDay)arrayEvent[x]).FlagDayIncome();
                }
            }
            return total;
        }