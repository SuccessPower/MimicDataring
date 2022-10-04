using MimicDataring;

namespace MimicDataring
{
    public class LinkedList<T>
    {
        
        Node<T> head;
        Node<T> tail;
        int Count = 0;

        
        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            node.next = null;

            if(head == null)
            {
                head = node;    
            }
            else
            {
                Node<T> temp = new Node<T>(item);
                temp = head;

                while(temp != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Count++;
        }

        public void Remove(T item)
        {
            if (head == null)
                return;

            if(head.data.Equals(item))
            {
                head = head.next;
                Count--;
                return;
                
            }

            var temp = head;
            while(temp.next != null)
            {
                if (temp.next.data.Equals(item))
                {
                    temp.next = temp.next.next;
                    Count--;
                    return;
                }
                temp = temp.next;
            }

        }

             
    }
}
