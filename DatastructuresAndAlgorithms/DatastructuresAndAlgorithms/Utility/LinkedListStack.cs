using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class LinkedListStack<T> where T :IComparable
    {
        internal Node<T> top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack",value);
        }
        internal void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty,Deletion is not possible");
                return;
            }
            Console.WriteLine(" Value popped");
            this.top = this.top.next;
        }
        internal bool IsEmpty()
        {
            Node<T> node = this.top;
            while (this.top != null)
            {
                //Peek();
                Console.WriteLine("empty");
                //Pop();
            }
            return false;
        }
    }
}
