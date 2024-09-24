namespace TestCode
{
    internal class QuestionTest
    {
        static void Main(string[] args)
        {
            Xavier();
            Console.ReadLine();
        }
        static int correct = 0;
        public static void Xavier()
        {
            Console.Write("Is 97 a prime number? Y/N? ");
            char answer = Convert.ToChar(Console.ReadLine().ToUpper());
            if (answer == 'Y')
            {
                correct++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
