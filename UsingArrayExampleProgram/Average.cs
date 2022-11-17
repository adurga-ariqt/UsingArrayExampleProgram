using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace UsingArrayExampleProgram
{
    public class Average
    {

        public void FixArray()
        {
            try
            {
                int i;
                Console.WriteLine("Enter array of size:");
                int lengthofarray = int.Parse(Console.ReadLine());
                int[] str = new int[lengthofarray];
                //Console.WriteLine("enter elements");
                for (i = 0; i < str.Length; i++)
                {
                    // Console.WriteLine($"enter element if index {i}:");
                    Console.WriteLine("Element in index     " + i + ":");
                    str[i] = int.Parse(Console.ReadLine());


                }

                Console.WriteLine("the elements in the array ");
                foreach (int str2 in str)
                {
                    Console.WriteLine(str2);
                }

                Console.Write("Enter index number:");
                int n = int.Parse(Console.ReadLine());
                for (i = 0; i < str.Length; i++)                                                    //foreach (int str2 in str)
                                                                                                       //{
                                                                                                 //    if (str2.Equals(str[n]))
                                                                                               //    {
                                                                                   //        Console.WriteLine(str2);
                                                                                         //    }
                                                                                       //    break;
                                                                                    //}
                {
                    if (n == i)
                        Console.WriteLine("the value is ;" +str[i]);
               }


                // Console.WriteLine("old value at index :" );
                Console.WriteLine("The new value of array element is  :");
                int a = int.Parse(Console.ReadLine());
                str[n] = a;
                Console.WriteLine("the elements in the array ");
                foreach (int str2 in str)
                {
                    Console.WriteLine(str2);
                }
                int   m = str.Min();
                Console.WriteLine("The smallest value of array elements is :" + m);
                int index=Array.IndexOf(str ,m);
               Console.WriteLine("the smallest value of array index is :" +index);
               int x = str.Max();
                Console.WriteLine("The largest value of array elements is :" + str.Max());
                int index1 = Array.IndexOf(str, x);
                Console.WriteLine("the largest value of array index is :" + index1);
                float s = str.Sum();
                Console.WriteLine(" sum of array elements is :" +str.Sum());
                float c = str.Count();
                Console.WriteLine("the number of array elements is :" +str.Count());
                float avg = s / c;
                Console.WriteLine("the average of array elements is ;" +avg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}









