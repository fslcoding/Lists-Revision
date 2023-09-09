using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
  {

    List<int> numbers = new List<int>();
    int number;
    for(int i =0;i<2;i++)
    {
      Console.WriteLine("Please enter a value");
      number = Convert.ToInt16(Console.ReadLine());
      numbers.Add(number);
    }
    Console.WriteLine("The total cost is "+totalCost(numbers));
    Console.WriteLine("There are " + numbers.Count + " numbers in this list");
    

    List<string> presidents = new List<string>();

    Console.WriteLine("How many presidents can you name?");
    int noOfPresidents = Convert.ToInt16(Console.ReadLine()); 
    for(int i =0;i<noOfPresidents;i++)
    {
      Console.WriteLine("Enter president (surname only e.g. obama" + i + ": ");
      presidents.Add(Console.ReadLine().ToLower());
    }
    
    Console.WriteLine("You named the following presidents");

    foreach(string president in presidents)
    {
      Console.WriteLine("President" +": " + president);
    }

    Console.WriteLine("Does the list contain the following president");
    string searchPresi = Console.ReadLine();
    
    int index = presidents.BinarySearch(searchPresi);

    if(index<0)
    {
      Console.WriteLine("This president does not appear in the list");
    }

    else
    {
    Console.WriteLine("Yes this president appears in position " + index + " in the list");
    }
  }

  public static int totalCost(List<int> cost)
  {

    int subTotal=0;
    foreach(int i in cost)
    {
      subTotal=subTotal+i;
    }

    return subTotal;
  }
}
