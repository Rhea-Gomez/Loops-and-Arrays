namespace ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            string[] colours = { "red", "blue", "green", "yellow", "violet", "white" };

            Console.WriteLine("Using For loop: ");
            for(int i = 0; i < colours.Length; i++)
            {
                Console.WriteLine(colours[i]);
            }

            Console.WriteLine("Using For Each: ");
            foreach(string colour in colours)
            {
                Console.WriteLine(colour);
            }

            int[] array = { 12, 34, 56, 32, 83 };
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            average = sum / array.Length;

            Console.Write("Average of all the elements in the integer array is : " +average);
        }
    }
}
