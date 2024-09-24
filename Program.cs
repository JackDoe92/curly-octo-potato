using System.Reflection.Metadata;

namespace curly_octo_potato_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's your name?");
            string name = Convert.ToString(Console.ReadLine().ToLower());
            if (name == "jack")
            {
                Console.Clear();
                Jack();
            }
            else
            {
                if (name == "jacob")
                {
                    Console.Clear();
                    Jacob();
                }
                else
                    if (name == "xavier")
                {
                    Console.Clear();
                    Xavier();
                }
            }    

        }
        public static void Xavier()
        {
            Console.WriteLine("g'day");
            Console.ReadLine();
        }                
                                                
        public static void Jacob()
        {
            Console.WriteLine("tes2");
            Console.ReadLine();
        }       
               
        public static void Jack()
        {
            Console.WriteLine("test3");
            Console.ReadLine();
        }
    }
}
