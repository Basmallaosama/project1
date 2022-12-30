using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
       int num1 , num2  ,num3;
       
       Console.WriteLine("Please enter the strting (smallest) number");
       
      
       num1 = int.Parse(Console.ReadLine());
       
       
       Console.WriteLine("Please enter the ending (biggesr) number");
       num2 = int.Parse(Console.ReadLine());
       
       
       
       for(int z=num1 ; z<=num2 ; z++)
       
       
       
       {
         
         
         
         for(num3=2; num3<z/2; num3++)
         
         
         
       {
         
         
         if(z%num3==0)
       
         break;
         
      } 
      
      
      if(z%num3!=0  && z!=-1)
      
      
      Console.WriteLine(z);
      }
       
     }
   }
 }
