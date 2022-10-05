namespace MimicDataring
{
    public class LinkedList<T>
    {

        Node<T> head;
        Node<T> tail;
        int Count = 0;
        int index = 0;

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            node.next = null;

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = new Node<T>(item);
                temp = head;

                while (temp != null)
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

            if (head.data.Equals(item))
            {
                head = head.next;
                Count--;
                return;

            }

            var temp = head;
            while (temp.next != null)
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

        public bool Check(T item)
        {
            Node<T> temp = head;
            while (head != null)
            {
                if (temp.data.Equals(item))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;

        }

        public int Index(T item)
        {
            Node<T> temp = head;
            while (head != null)
            {
                if (temp.data.Equals(item))
                {
                    return index;
                    temp = temp.next;
                    index++;
                }             
            }
            return index;
        }

        //public Node<T> Print(T value)
        //{
        //    while (Node.next != null)
        //    {
        //        Console.WriteLine(Node.data);
        //        Node = Node.next;

        //    }
        //}

    }
}
