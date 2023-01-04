using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int x, int y) 
        {
            return x + y; 
        }
        public static decimal Add(decimal x, decimal y) 
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isTrue) 
        {
            var sum = 0;
            var answer = "";
            if (isTrue) 
            {
                sum = x + y;
                answer = (sum == 1) ? $"{sum} dollar." : $"{sum} dollars.";
            }
            return answer;
        }   

        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(4, 9, false));
            Console.WriteLine(Add(6, 22, true));
            Console.WriteLine(Add(7, -4, true));
        }
    }
}
