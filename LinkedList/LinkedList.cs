using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListStruct
{

    public class LinkedList<T> : IEnumerable<T>, IComparer<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        private int count;
        public int Count => count;
        public LinkedList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }
        public LinkedList(T data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data), "Data is empty");
            var node = new Node<T>(data);
            Head = node;
            Tail = node;
            count = 1;
        }
        public void Add(T data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data), "Data is empty");
            var node = new Node<T>(data);
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                count = 1;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
                count++;
            }
        }
        public void Remove(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (previous.Next != null)
                {
                    if (current.Data.Equals(data))
                    {
                        if (Tail == current)
                            Tail = previous;
                        previous.Next = current.Next;
                        count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;

                }
            }
        }
        public void Remove(int count)
        {
            if (Head != null && count <= this.count)
            {
                if (count == 1)
                {
                    Head = Head.Next;
                    count--;
                    return;
                }

                var iter = 2;
                var current = Head.Next;
                var previous = Head;
                while (iter != count + 1)
                {
                    if (iter == count)
                    {
                        if (Tail == current)
                            Tail = previous;
                        previous.Next = current.Next;
                        this.count--;
                        return;
                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                        iter++;
                    }
                }
            }
        }

        public void Clear()
        {
            Head = Tail = null;
            count = 0;

        }

        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = Head;
            Head = node;
            if (count == 0)
                Tail = Head;
            count++;
        }
        public void Sort()
        {
            Form1 form = Application.OpenForms.Cast<Form1>().First();
            int time = count * 2 / 100 <= 0 ? 100 : count * 2 / 100;
            
            int percent = 2;
            var previous = Head;
            var current = Head.Next;

            var backcurrent = Head;
            var temp = Head;
            int i = 2;
            while (previous != Tail)
            {
                if (Compare(previous.Data, current.Data) == 1)
                {
                    previous.Next = current.Next;
                    temp = current;
                    if (Compare(Head.Data, temp.Data) == 1)
                    {
                        temp.Next = Head;
                        Head = temp;
                    }
                    else
                    {
                        while (backcurrent != previous)
                        {

                            if (Compare(backcurrent.Next.Data, temp.Data) == 1)
                            {
                                temp.Next = backcurrent.Next;
                                backcurrent.Next = temp;
                                backcurrent = Head;
                                form.worker.ReportProgress(percent);
                                break;
                            }

                            backcurrent = backcurrent.Next;

                        }
                    }
                    if (i >= time)
                    {
                        percent += 2;
                        time += count * 2 / 100;
                    }
                    i++;

                }

                previous = current;
                current = current.Next;

            }
        }
    
        public bool Contains(T data)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public int Compare(T? x, T? y)
        {
            int var = Comparer<T>.Default.Compare(x, y);
                return var;
        }
    }
}
