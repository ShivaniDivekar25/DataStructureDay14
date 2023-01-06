using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay14
{
    internal class Stack
    {
        public Node top;
        LinkedList list = new LinkedList();
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} pushed to stack", newData);
        }
        public void Display()
        {
            Node temp = this.top;

            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
