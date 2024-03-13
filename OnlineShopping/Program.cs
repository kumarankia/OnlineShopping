using System;
namespace OnlineShopping
{ class Program
    {
         static void Main(string[] args)
        {
            double total,discountPrice;
            
            Console.WriteLine("Hey customer Your total amount of pursase : ");
            total = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your total amount is $ "+total);
            if (total > 100) { discountPrice = total-total * 1 / 10;
                Console.WriteLine("Your amount after discount $" + discountPrice);
            } 
            else if (total > 50) 
                { discountPrice = total-total*5/100;
                Console.WriteLine("Your amount after discount give $"+discountPrice);
            }else { Console.WriteLine("You are not eligle for discount "); }









        }



    }




}