namespace Stack_And_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackMethods<int> stackMethods = new StackMethods<int>();
            QueueMethods<int> queueMethods = new QueueMethods<int>();
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter 1 to add element to Stack");
                Console.WriteLine("Enter 2 to empty the Stack");
                Console.WriteLine("Enter 3 to add element to Queue");
                Console.WriteLine("Enter 4 to Dequeue element from Queue");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter a number");
                        int valu = Convert.ToInt32(Console.ReadLine());
                        stackMethods.Add(valu);
                        stackMethods.Display();
                        break;
                    case 2:
                        stackMethods.EmptyStack();
                        stackMethods.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter a number");
                        int qValu = Convert.ToInt32(Console.ReadLine());
                        queueMethods.Add(qValu);
                        queueMethods.Display();
                        break;
                    case 4:
                        queueMethods.Dequeue();
                        queueMethods.Display();
                        break;
                    default:
                        Console.WriteLine("Choose a valid choice");
                        break;
                }
                Console.WriteLine("Enter y for adding more data");
                string doOrNot = Console.ReadLine().ToLower();
                if (doOrNot == "y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
        }
    }
}