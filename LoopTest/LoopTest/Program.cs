namespace LoopTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Printing " + name + " 5 times");
            Console.WriteLine("Using For Loop: ");
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Using While Loop: ");
            while(num != 0)
            {
                Console.WriteLine(name);
                num--;
            }
        }
    }
}
