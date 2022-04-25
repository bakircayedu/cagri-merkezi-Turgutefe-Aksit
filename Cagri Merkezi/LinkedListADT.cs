using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi
{
    public abstract class LinkedListADT<T>
    {
        public Node<T> Head;
        public int Size = 0;
        public abstract void Insert(T value);
        public abstract void Delete(T value);
        public abstract List<T> DisplayElements();


    }
}
