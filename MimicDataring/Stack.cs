using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MimicDataring
{
    internal class Stack<T>
    {
        Node<T> head;
        Node<T> tail;
        Node<T> top;
        int Count = 0;
        int index = 0;


        public bool IsEmpty()
        {
            if(head == null)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public void Push(T item)
        {
            var temp = new Node<T>(item);

            if(temp == null)
            {
                throw new Exception("Nothing in stack");

            }
            temp.next = head;
            temp.next = top;
            top = head;
            Count++;
        }

        public void Pop()
        {
            if (top == null)
            {
                throw new Exception("Stack Empty");
            }
            else
            {
                top = top.next;
                Count--;
            }
        }

        public T Peek()
        {
            if(!IsEmpty())
            {
                return top.data;
            }
            else
            {
                throw new Exception("No item found");
            }
            top = top.next;
            Count--;
        }

        public int Size()
        {
            return Count;
        }
    }
}
 