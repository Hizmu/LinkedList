using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStruct
{
    public class Node<T>
    {
        public Node(T data) { this.Data = data; }

        private T data = default(T);
        public Node<T> Next { get; set; }
        public T Data
        {
            get =>  data;
           
            set => data = value ?? throw new ArgumentNullException(nameof(value));
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
