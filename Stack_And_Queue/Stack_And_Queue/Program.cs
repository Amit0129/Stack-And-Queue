namespace Stack_And_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackMethods<int> stackMethods= new StackMethods<int>();
            Console.WriteLine("Enter 1 to add element to Stack");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bool check = true;
                    while (check)
                    {
                        Console.WriteLine("Enter a number");
                        int valu = Convert.ToInt32(Console.ReadLine());
                        stackMethods.Add(valu);
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
                    stackMethods.Display();
                    break;
                default:
                    break;
            }
        }
    }
}