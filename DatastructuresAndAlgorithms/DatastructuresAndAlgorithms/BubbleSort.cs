using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructuresAndAlgorithms
{
    class BubbleSort
    {
        public void CheckBubbleSort()
        {
            Console.WriteLine("Enter the length of an array");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            Console.WriteLine("Enter the elements in array");
            for (int i = 0; i < number; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Elements after sorting :");
            foreach(var element in array)
            {
                Console.Write(element);
            }
        }
    }
}
   
            

