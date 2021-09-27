using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("Enter a number:");
    double number = Convert.ToDouble (Console.ReadLine()) ;
bool Prime = true;
    for (double a = 2; a < number/2; a++)
     {
       if (number % a ==0)
       {
         Prime = false;
         break;
       }

     }
    if (Prime) 
     {
     Console.WriteLine("Number is a prime number");
    }
     else
     {
     Console.WriteLine("Number is not a prime number");
  
     }       
  }
}