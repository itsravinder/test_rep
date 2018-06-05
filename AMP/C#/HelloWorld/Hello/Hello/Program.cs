using System;

 class Tickets
 {
     public static void Main()
     {
         Console.WriteLine("please enter your value");
         int defaultvalue = 0;

         int uservalue = int.Parse(Console.ReadLine());
         while (defaultvalue <= uservalue)
         {
             Console.WriteLine(defaultvalue);

             defaultvalue += 2;
         }
     
     }
 }

