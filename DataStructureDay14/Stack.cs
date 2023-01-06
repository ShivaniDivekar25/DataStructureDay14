using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay14
{
    internal class Stack        //Creating class
    {
        public Node top;
        public void Push(int newData)       //Creating method to push into stack
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} pushed to stack", newData);
        }
        public void Display()       //Creating display method 
        {
            Node temp = this.top;

            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peek()          //Creating peek method to show topmost element
        {
            if (this.top == null)
            {
                Console.WriteLine("no element present in the stack");
                return;
            }
            Console.WriteLine("\nTop most element " + this.top.data);
        }
        public void Pop()       //Creating Pop method to delete element
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, deleting is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()           //Creating empty method to make stack empty
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("The stack is empty");
        }
    }
}
