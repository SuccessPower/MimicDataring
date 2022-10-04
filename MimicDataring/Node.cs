using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MimicDataring
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T item)
        {
            data = item;
            next = null;
        }

        
    }
}
