using System.Reflection.Metadata;

namespace curly_octo_potato_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's your name?");
            string name = Console.ReadLine().ToLower();
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


        static void Jack()
        {
            string favDay;
            Console.WriteLine("What's your favorite day of the week?");
            favDay = Console.ReadLine().ToLower();

            bool validAnswer = false;

            while (validAnswer = false)
            {
                switch (favDay)
                {
                    case "monday":
                        Console.WriteLine("mondays are literally the worst.You are insane");
                        validAnswer = true;
                        break;
                    case "tuesday":
                        Console.WriteLine("Tuesdays are just Mondays without the Monday");
                        validAnswer = true;
                        break;
                    case "wednesday":
                        Console.WriteLine("Wednesday is good I guess");
                        validAnswer = true;
                        break;
                    case "thursday":
                        Console.WriteLine("Thursdays are good. Friday is close, and Monday is far");
                        validAnswer = true;
                        break;
                    case "friday":
                        Console.WriteLine("Finally, the weekend! ");
                        validAnswer = true;
                        break;
                    case "saturday":
                        Console.WriteLine("Saturdays are good. I like to do nothing.");
                        validAnswer = true;
                        break;
                    case "sunday":
                        Console.WriteLine("I also like Sundays, but I don't like how close Monday is");
                        validAnswer = true;
                        break;
                    default:
                        Console.WriteLine("That's not a valid day of the week.");
                        break;
                        Thread.Sleep(5000);
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
            Console.WriteLine("My name is Jacob");
            Console.ReadLine();
        }       
               
     
    }
}
