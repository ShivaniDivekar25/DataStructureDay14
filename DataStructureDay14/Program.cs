namespace DataStructureDay14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure programs");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("Enter\n1:Add LinkedList\n2:Create LinkedList by Adding ");
            int option = Convert.ToInt32(Console.ReadLine());
            LinkedList linkedlist = new LinkedList();
            switch (option)
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
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
        }
    }
}