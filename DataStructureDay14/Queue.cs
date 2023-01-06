using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay14
{
    internal class Queue
    {
        public Node head;   
        public void Enqueue(int item)           //Creating enqueue method 
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("{0} is inserted into Queue", new_node.data);
        }
        public void Dequeue()           //Creating Dequeue
        {
            if (head == null)
                Console.WriteLine("No nodes are present in queue");
            else
                head = head.next;
        }
        public void Display()           //Creating display method
        {
            Node temp = this.head;

            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
