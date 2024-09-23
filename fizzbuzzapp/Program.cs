namespace fizzbuzzapp
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(GetFizzBuzz(i));
            }
        }

        public static string GetFizzBuzz(int number)
        {
            string fizzorbuzz = "";
            if (number % 3 == 0)
            {
                fizzorbuzz += "Fizz";
            }
            if (number % 5 == 0)
            {
                fizzorbuzz += "Buzz";
            }
            if (fizzorbuzz.Length == 0)
            {
                fizzorbuzz = number.ToString();
            }
            return fizzorbuzz;
        }
    }
}