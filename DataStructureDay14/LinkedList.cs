using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay14
{
    internal class LinkedList           //Created class
    {
        public Node head;           //Initializing input
        public void AddLast(int data)       //Addlast Method for creating Linked list
        {
           Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added into LinkedList", newNode.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is added into LinkedList", newNode.data);
            }
        }
        public void AddFirst(int data)        //AddFirst Method for creating linked list
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} is added into LinkedList", newNode.data);
        }
        public void Append(int data)          //Append Method for creating linked list
        {
            AddLast(data);
        }
        public void Display1()          //Display method for append method
        {
            Console.WriteLine("\nDisplaying all the nodes");
            if (head == null)
                Console.WriteLine("LinkedList is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public void Insertnode(int data, int afterNum)          //Insert method for creating inserting element
        {
            Node node = new Node(data);
            Node temp = head;
            while(temp.data != afterNum)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            Console.WriteLine("Node {0} inserted after {1}.", data,afterNum);
        }
        public void RemoveFirst()       //Remove first method for removing element
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Removed first node");
            }
        }
        public void PopLast()         //Remove last method for removing element
        {
            if (head == null)
            {
                Console.WriteLine("The LinkedList is Empty");
            }
            else
            {
                if (head.next == null)
                    head = null;
                else
                {
                    Node temp = head;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                }
            }
        }
        public void Search(int input)          //Search method for searching element in linked list
        {
            bool isFound = false;
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        isFound = true;
                        Console.WriteLine("Given node {0} is present.", input);
                        break;
                    }
                    temp = temp.next;
                }
                if (!isFound)
                    Console.WriteLine("Given node {0} is not present", input);
            }
        }
        public void RemoveAtGivenPosition()     //Creating remove at given postion method
        {
            Node temp1 = head;
            Node temp2 = head;
            if (head == null)
            {
                Console.WriteLine("The LinkedList is Empty");
            }
            else
            {
                temp2.next.next = temp1.next.next.next;
            }
        }
        public void size()          //Creating size method
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("The size of linked list is:" + count);
        }
        public void Display()           //Display method for UC1, UC2, UC5, UC6, UC7, UC8, UC9 method
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
