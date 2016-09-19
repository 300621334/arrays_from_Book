using System;

namespace arrays_misc
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] hello = { 'h', 'e', 'l', 'l', 'o' };
            //string word = new string(hello);
            //Console.WriteLine(word);


            ////sub = subscript that is the position of elements in array.
            //int[] myScores = { 100, 200, 300, 400, 500 };
            //for(int sub=0;sub<myScores.Length;++sub)
            //{
            //    myScores[sub] += 3;
            //    Console.WriteLine(myScores[sub]);
            //}


            //bool validCode = false; double price = 0;
            //int[] productCodes = { 111, 222, 333, 444, 555, 666, 777, 888, 999 };
            //double[] prices = {0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26};
            //Console.Write("Enter Product Code: ");
            //int userEntered = Convert.ToInt32(Console.ReadLine());
            //for (int x = 0; x < productCodes.Length; ++x)
            //{
            //    if (userEntered == productCodes[x])
            //    {
            //        validCode = true;
            //        price = prices[x];
            //    }
            //}
            //if (validCode)
            //    Console.WriteLine("This product is available. Price is {0}", price);
            //else
            //    Console.WriteLine("No such product there!.");



            //in Qs e a "range", if u use lower limit then start matching from last element in array &
            //have to use decrement op on subtrate (;;sub--). 
            //To avoid such, use UPPER limits in arrays & increment & start matching from 1st(lowest) element in array.
            //e.g discount on purchase of 1-100 items is 0%, 101-200 items=20%, 201-300 items=30%, >300=40%.
            //999999999 used so that loop will NOT execute if items > 3rd element(>300).

            //int[] rangeUpperLimit = {100, 200, 300, 999999999};
            //double[] discounts = {0, 0.2, 0.3, 0.4};
            //int x = 0; double discount = 0;
            //Console.Write("How many items purchased? ");
            //int items = Convert.ToInt32(Console.ReadLine());
            //while (x < rangeUpperLimit.Length  &&  items > rangeUpperLimit[x])
            //{
            //    x++;
            //}
            //discount = discounts[x];
            //Console.WriteLine("Discount rate is {0}", discount);


            //binary search in an array of ascending-arranged elements. Returns element place or if not found then "-1"
            int[] num = { 99, 88, 77, 66, 55, 44, 33, 22, 11 };
            Console.Write("What # to find?  ");
            int find = Convert.ToInt32(Console.ReadLine());
            Array.Sort(num);
            //since binarysearch works ONLY on ascending-ordered objects(strings/ints) so sort() method makes sure of that.
            //int[] num = { 11, 22, 33, 44, 55, 66, 77, 88, 99 }; //after sorting  
            int x = Array.BinarySearch(num, find);
            if (x < 0)
                Console.WriteLine("No match found!!!");
            else
                Console.WriteLine("Num {0} is present at position# {1}.", num[x], x);











        }
    }
}

