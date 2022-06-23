using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //declater values 
      int litterSize;
      int yearlyLitters;
      int annualMice;

      
      
     //assign values 
       
    litterSize = 3;
    yearlyLitters = 5;
    annualMice = litterSize*yearlyLitters;
    Console.WriteLine("one female mouse may give birth to" );
    Console.WriteLine(annualMice + " to ");
    litterSize = 14; 
    yearlyLitters = 10 ;
    annualMice = litterSize*yearlyLitters;
    
    //output values
          Console.WriteLine(annualMice);
          Console.WriteLine("mice per year" );