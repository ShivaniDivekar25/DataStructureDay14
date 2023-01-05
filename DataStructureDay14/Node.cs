using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay14
{
    internal class Node         //Created class
    {
        public int data;        //Initialize input
        public Node next;
        public Node(int data)       //Creating constructor
        {
            this.data = data;
            this.next = null;
        }

    }
}
