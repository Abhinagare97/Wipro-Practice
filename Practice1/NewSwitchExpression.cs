using System;
namespace Delegate
{
     enum weekdays{
        mon, tues, wed ,thurs,fri,sat, sun
     }

public class Switches{
  
    public static void Main(string [] args){

        static string GetClass(int rs)=>rs switch{
            100=> "silver", 
            200=>"gold",
            300=>"platinum",
            _ => "stay outside"
        };


        Console.WriteLine(GetClass(100));
         
        Console.WriteLine(GetClass(200));
        Console.WriteLine(GetClass(466));


        //using enums
        static string GetFood(weekdays day)=>day switch{
            weekdays.mon => "burger",
            weekdays.tues => "pizza",
            weekdays.wed => "pasta",
            weekdays.thurs => "sushi",
            weekdays.fri => "sushi",
            weekdays.sat => "sushi",
            weekdays.sun => "sushi",
        };  
        Console.WriteLine(GetFood(weekdays.mon));
        Console.WriteLine(GetFood(weekdays.tues));
        Console.WriteLine(GetFood(weekdays.wed));

       
    }

}
}