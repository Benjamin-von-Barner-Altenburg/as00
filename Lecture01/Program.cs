using System;

namespace Lecture01  
{  
    public class Program   
    {  
       public static bool isLeap = false; 

        public static void Main(string[] args)  
        {  
           try{ 
            Console.WriteLine("Enter Year : ");  
            int Year = int.Parse(Console.ReadLine());

            if (Year < 1582) Console.WriteLine("It is not possible to calculate leap years earlier that 1582. Please select another Year");  
            else{
                IsLeapYear(Year);
                if (isLeap ==true) Console.WriteLine("{0} is a Leap Year.", Year);  
                else Console.WriteLine("{0} is not a Leap Year.", Year);  
            }
           }catch(System.FormatException){
               Console.WriteLine("Only intengers are allowed!");
           }
        }  

        public static bool IsLeapYear(int year){
           if (year>=1582 && (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))) return isLeap = true;   
            else return isLeap = false;   
        }
    }  
}
