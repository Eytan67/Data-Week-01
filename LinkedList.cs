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

        public int getValue()
        {
            return this.Value;
        }
        public Node getNext()
        {
            return this.Next;
        }

        public void setValue(int value)
        {
            this.Value = value;
        }
        public void setNext(Node next)
        {
            this.Next = next;
        }


        public Node(int value)
        {
            this.setValue(value);
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
                    cur = cur.getNext();
                }
                cur.setNext(newNode);
            }
                
            
        }


        public string Display()
        {
            //1-> 2-> 5-> - 5-> 5
            var cur = this.head;
            string res = "";
            while(cur != null)
            {
                res += cur.getValue().ToString() + "-> ";
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
                cur = cur.getNext();
            }
            return count;
        }
    
        // Method to remove the first value
        public void RemoveValue(int data)
        {
            if(this.head == null)//-----------------!!!!!!!!!!!!!!!!!!-----------
                return;
            if(this.head.getValue() == data)
            {
                this.head = this.head.getNext();
                return;
            }
            var cur = this.head;
            while (cur.getNext() != null)
            {
                if(cur.getNext().getValue() == data)
                {
                    cur.setNext(cur.getNext().getNext());
                    return;
                }
                cur = cur.getNext();
            }
        }

        // Method to remove the first value
        public void RemoveAllValues(int data)
        {
            if (this.head == null)//-----------------!!!!!!!!!!!!!!!!!!-----------
                return;
            if (this.head.getValue() == data)
            {
                this.head = this.head.getNext();
                return;
            }
            var cur = this.head;
            while (cur.getNext() != null)
            {
                if (cur.getNext().getValue() == data)
                {
                    cur.setNext(cur.getNext().getNext());
                }
                cur = cur.getNext();
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
                cur = cur.getNext();    
            }
            cur.setNext(cur.getNext().getNext());
        }

        // Method to find by value
        public Find(data)
        {

        }

        // Method to get a value by  index
        public Get(data)
        {

        }
    }
}