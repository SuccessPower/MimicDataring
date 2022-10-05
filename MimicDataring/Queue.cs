using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MimicDataring
{
    internal class Queue<T>
    {
        Node<T> head;
        Node<T> tail;
        int Count = 0;
        int index = 0;


        public bool IsEmpty(T AQueue)
        {
            Node<T> node = new Node<T>(AQueue);
            node.next = null;

            if(head == null)
                return true;
            else
            {
                return false;
            }
            
        }

        public void Enqueue(T AQueue)
        {
            var node = new Node<T>(AQueue);

            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
                Count++;
            }

        }

        public T Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("queue is empty");
            }
                

            Node<T> temp = head;
            head = head.next;
            return temp.data;
                        
        }

        public int Size()
        {
            return Count;
        }
    }
}
