using System;

namespace DatastructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures And Alogorithm Programs...");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose an Option : \n 1.Unordered List\n 2.OrderedList\n 3.BalancedParanthesi\n 4.Bubblesort\n 5.PrimeNumbers\n 6.Anagram\n 7.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UnOrderedList unordered = new UnOrderedList();
                        unordered.Read();
                        unordered.Search("R");
                        break;
                    case 2:
                        OrderedList ordered = new OrderedList();
                        ordered.Read();
                        ordered.Search(2);
                        break;
                    case 3:
                        BalancedParanthesis  result = new BalancedParanthesis();
                        result.Read();
                        break;
                    case 4:
                        BubbleSort sort = new BubbleSort();
                        sort.CheckBubbleSort();
                        break;
                    case 5:
                        PrimeNumbers numbers = new PrimeNumbers();
                        numbers.Prime();
                        break;
                    case 6:
                        Anagram check = new Anagram();
                        check.AnagramCheck();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}
