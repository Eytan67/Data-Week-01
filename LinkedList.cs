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

        //o(1)
        public int GetValue()
        {
            return this.Value;
        }
        //o(1)
        public Node GetNext()
        {
            return this.Next;
        }
        //o(1)
        public void SetValue(int value)
        {
            this.Value = value;
        }
        //o(1)
        public void SetNext(Node next)
        {
            this.Next = next;
        }

        //o(1)
        public Node(int value)
        {
            this.SetValue(value);
            this.Next = null;
        }
    }




    public class LinkedList
    {
        Node head;
        //o(1)
        public LinkedList()
        {
            this.head = null;
        }
        //o(1)
        public LinkedList(int data)
        {
            Node newNode = new Node(data);
            this.head = newNode;
        }
        //o(n)
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

        //o(n)
        public string Display()
        {
            if (this.head == null)
                return "";
            string res = this.head.GetValue().ToString();
            var cur = this.head.GetNext();
            while(cur != null)
            {
                res += " -> " + cur.GetValue().ToString();
                cur = cur.GetNext();
            }
            return res;
        }

        //o(n)
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

        //o(n)
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

        //o(n)
        // Method to remove the first value
        public void RemoveAllValues(int data)
        {
            if (this.head == null)
                return;
            while (this.head != null && this.head.GetValue() == data)
            {
                this.head = this.head.GetNext();
            }
            var cur = this.head;
            while (cur != null)
            {
                if (cur.GetNext().GetValue() == data)
                {
                    cur.SetNext(cur.GetNext().GetNext());
                }
                cur = cur.GetNext();
            }
        }

        //o(n)
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

        //o(n)
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
                ++count;
                cur = cur.GetNext();
            }
            return -1;
        }

        //o(n)
        // Method to get a value by  index
        public int Get(int idx)
        {
            if (this.head == null)
                return -1;
            int count = 0;
            var cur = this.head;
            while(cur != null && count != idx)
            {
                cur = cur.GetNext();
                ++count;
            }
            return cur != null ? cur.GetValue() : -1;

        }
    }
}