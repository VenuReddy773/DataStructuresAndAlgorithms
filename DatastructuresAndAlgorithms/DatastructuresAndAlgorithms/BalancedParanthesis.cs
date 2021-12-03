using DataStructures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DatastructuresAndAlgorithms
{
    class BalancedParanthesis
    {
        public static LinkedListStack<string> stack = new LinkedListStack<string>();
        public static string filepath = @"C:\Users\Venu Gopal Reddy\Bridgelabz\c#\.net\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\DatastructuresAndAlgorithms\DatastructuresAndAlgorithms\Utility\Paranthesis.txt";
        public static string data = File.ReadAllText(filepath);
        string[] check = data.Split(" ");
        public void Read()
        {
            foreach (var result in check)
            {
                if(result =="(")
                {
                    stack.Push(result);
                }
                if(result==")")
                {
                    stack.Pop();                    
                }
            }
            if(stack.IsEmpty())
            {
                Console.WriteLine("\nbalnced");
            }
            else
            {
                Console.WriteLine("\nunbalanced");
            }
        }
    }
}
