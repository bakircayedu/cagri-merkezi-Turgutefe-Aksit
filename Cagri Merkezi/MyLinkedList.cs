using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi
{
    public class MyLinkedList<T> : LinkedListADT<T>
    {
        public override void Insert(T value)
        {
            var current = Head;
            Node<T> newNode = new(value);
            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            Size++;
        }
        public override void Delete(T value)
        {
            if (Head == null) throw new Exception("Silinecek veri bulunamadi...");
            if (value == null) throw new ArgumentNullException();
            var current = Head.Next;
            var temp = Head;
            if (Head.Value.Equals(value))
            {
                Head = current;
                return;
            }
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    temp.Next = current.Next;
                    return;
                }
                current = current.Next;
                temp = temp.Next;
            }

        }
        public override List<T> DisplayElements()
        {
            var temp = Head;
            List<T> list = new List<T>();
            temp = Head;

            if (temp == null)
            {
                throw new Exception("Liste Boş...");
            }
            else
            {
                while (temp.Next != null)
                {
                    list.Add(temp.Value);
                    temp = temp.Next;
                }

                list.Add(temp.Value);
                return list;
            }
    }
}
}
