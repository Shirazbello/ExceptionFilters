using System;

namespace ExceptionFilters
{
    class Program
    {
        static int[] arry = { 0, 0, 0, 0 };
        static void SetArrayValue(int index, int value)
        {
            try
            {
                arry[index] = value;
            }
            catch (Exception) when (index < 0)
            {

                Console.WriteLine($"Negative Index ({ index}) cannot be used ,the smallest index is 0");
            }
            catch (Exception) when (index > arry.Length)
            {
                Console.WriteLine($"The total length of the array is {arry.Length}, Hence index {index} is not accepted");
            }
        }
        static void Main(string[] args)
        {
            SetArrayValue(-2, 20);
            SetArrayValue(7, 30);
            Console.ReadKey();
            
        }
    }
}
