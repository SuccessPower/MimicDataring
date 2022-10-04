using MimicDataring;

namespace MimicDataring
{
    internal class LinkedList<T>
    {
        int Count;
        Node<T> head;

        public LinkedList()
        {
            head = null;
            Count = 0;
        }

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            node.next = head;
            head = node;
            Count++;
        }

        public void Remove(T Item)
        {
            while (Item != null)
            {
                Node<T> node = null;
                if (node.next == null)
                {
                    return true;
                }
            }
        }

    }
}
