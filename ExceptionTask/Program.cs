using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExceptionTask
{
    internal class Program
    {

        public static void Vowels(string s)
        {
           
            s = s.ToLower();

            string vowels = "aeiou";
            bool foundVowel = false;

            foreach (char c in vowels)
            {
                if (s.Contains(c))
                {
                    foundVowel = true;
                    break; 
                }
            }

           
            if (!foundVowel)
            {
                throw new Exception("The string does not contain any vowels.");
            }
        }
        static void Main(string[] args)
        {
            //execption no dublication in the list//
            //try
            //{
            //    Console.WriteLine("Please enter the number of items in the list");
            //    List<int> numbers = new List<int>();
            //    int n=Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter the numbers");
            //    for (int i = 0; i < n; i++)
            //    {
            //        int x = Convert.ToInt32(Console.ReadLine());
            //        if (numbers.Contains(x))
            //        {
            //            throw new Exception("Duplicate number found: " + x);
            //        }
            //        numbers.Add(x);

            //    }



            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message); 
            //}

            try
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

              
                Vowels(input);

                Console.WriteLine("The string contains vowels.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }
    }
}
