using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{

    public class Node
    {
        int Value;
        Node Next;

        public int GetValue()
        {
            return this.Value;
        }
        public Node GetNext()
        {
            return this.Next;
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }
        public void SetNext(Node next)
        {
            this.Next = next;
        }


        public Node(int value)
        {
            this.SetValue(value);
            this.Next = null;
        }
    }




    public class LinkedList
    {
        Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public LinkedList(int data)
        {
            Node newNode = new Node(data);
            this.head = newNode;
        }

        // Method to add to the end of the list.
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                var cur = this.head;
                for (int i = 0; i < this.Length() - 1; ++i)
                {
                    cur = cur.GetNext();
                }
                cur.SetNext(newNode);
            }
                
            
        }


        public string Display()
        {
            if (this.head == null)
                return "";
            string res = this.head.GetValue().ToString();
            var cur = this.head.GetNext();
            while(cur != null)
            {
                res += "-> " + cur.GetValue().ToString();
            }
            return res;
        }

        public int Length()
        {
            var cur = this.head;
            int count = 0;
            while(cur != null)
            {
                ++count;
                cur = cur.GetNext();
            }
            return count;
        }
    
        // Method to remove the first value
        public void RemoveValue(int data)
        {
            if(this.head == null)
                return;
            if(this.head.GetValue() == data)
            {
                this.head = this.head.GetNext();
                return;
            }
            var cur = this.head;
            while (cur.GetNext() != null)
            {
                if(cur.GetNext().GetValue() == data)
                {
                    cur.SetNext(cur.GetNext().GetNext());
                    return;
                }
                cur = cur.GetNext();
            }
        }

        // Method to remove the first value
        public void RemoveAllValues(int data)
        {
            if (this.head == null)
                return;
            if (this.head.GetValue() == data)
            {
                this.head = this.head.GetNext();
                return;
            }
            var cur = this.head;
            while (cur.GetNext() != null)
            {
                if (cur.GetNext().GetValue() == data)
                {
                    cur.SetNext(cur.GetNext().GetNext());
                }
                cur = cur.GetNext();
            }
        }

        // Method to remove the value in an index
        public void RemoveIndex(int idx)
        {
            var len = this.Length();
            if (this.head == null || idx > len)
                return;
            var cur = this.head;
            for (int i = 0; i < idx -1; ++i)
            {
                cur = cur.GetNext();    
            }
            cur.SetNext(cur.GetNext().GetNext());
        }

        // Method to find by value
        public int Find(int data)
        {
            int count = 0;
            var cur = this.head;
            while(cur != null)
            {
                if(cur.GetValue() == data)
                {
                    return count;
                }
                cur = cur.GetNext();
            }
            return -1;
        }

        // Method to get a value by  index
        public int Get(int idx)
        {
            if (this.head == null)
                return int.MinValue;
            int count = 0;
            var cur = this.head;
            while(cur != null && count != idx)
            {
                cur= cur.GetNext();
            }
            return cur.GetValue();

        }
    }
}