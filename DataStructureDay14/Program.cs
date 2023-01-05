namespace DataStructureDay14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure programs");
            Console.WriteLine("Please enter option given below");           //Taking user input
            Console.WriteLine("Enter\n1:Add LinkedList\n2:Create LinkedList by Adding\n3:Create LinkedList by Appending\n4:Insert an element in LinkedList");
            int option = Convert.ToInt32(Console.ReadLine());
            LinkedList linkedlist = new LinkedList();
            switch (option)             //Calling different methods for UC1, UC2, UC3 and UC4
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
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
        }
    }
}