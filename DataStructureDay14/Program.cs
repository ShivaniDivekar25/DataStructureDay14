namespace DataStructureDay14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure programs");
            Console.WriteLine("Please enter option given below");           //Taking user input
            Console.WriteLine("Enter\n1:Add LinkedList\n2:Create LinkedList by Adding\n3:Create LinkedList by Appending\n4:Insert an element in LinkedList\n5:Remove first element in LinkedList\n6:Remove last element in LinkedList\n7:Searching node in LinkedList\n8:Insert an element after searching in LinkedList");
            int option = Convert.ToInt32(Console.ReadLine());
            LinkedList linkedlist = new LinkedList();
            Stack stack = new Stack();
            Queue queue = new Queue();
            switch (option)             //Calling different methods for UC1, UC2, UC3, UC4, UC5, UC6, UC7 and UC8
            {
                case 1:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.Display();
                    break;
                case 2:
                    linkedlist.AddFirst(70);
                    linkedlist.AddFirst(30);
                    linkedlist.AddFirst(56);
                    linkedlist.Display();
                    break;
                case 3:
                    linkedlist.Append(56);
                    linkedlist.Append(30);
                    linkedlist.Append(70);
                    linkedlist.Display1();
                    break;
                case 4:
                    linkedlist.Append(56);
                    linkedlist.Append(70);
                    linkedlist.Insertnode(30, 56);
                    linkedlist.Display1();
                    break;
                case 5:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.RemoveFirst();
                    linkedlist.Display();
                    break;
                case 6:
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.AddLast(56);
                    linkedlist.PopLast();
                    linkedlist.Display();
                    break;
                case 7:
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.AddLast(56);
                    linkedlist.Display();
                    linkedlist.Search(30);
                    break;
                case 8:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.Search(30);
                    linkedlist.Insertnode(40,30);
                    linkedlist.Display();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("Enter\n1:Create stack using LinkedList\n2:Creating Empty method to stack\n3:Create Queue by using Enqueue method\n4:Dequeue method for Queue");        //Taking user input
            int option1 = Convert.ToInt32(Console.ReadLine());
            switch (option1)        //Calling different methods for stack and queue
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.IsEmpty();
                    break;
                case 3:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
                case 4:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Dequeue();
                    queue.Display();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}