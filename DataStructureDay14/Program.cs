namespace DataStructureDay14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure programs");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("Enter/n1:Add LinkedList");
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
            }
        }
    }
}