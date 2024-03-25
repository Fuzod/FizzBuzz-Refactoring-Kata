using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private readonly Foo[] foos;

        public FizzBuzz()
        {
            foos = new Foo[] { new(3, "Fizz"), new(5, "Buzz"), new(7, "Whizz"), new(11, "Bang"), };
        }

        public void Print()
        {
            string keyword = string.Empty;

            for (int i = 1; keyword != GetStopCondition(); i++)
            {
                keyword = Convert(i);
                Console.WriteLine(keyword);
            }
        }

        public string Convert(int number)
        {
            StringBuilder result = new();
            foreach (Foo foo in foos)
            {
                result.Append(foo.ToString(number));
            }

            return result.Length == 0 ? number.ToString() : result.ToString();
        }

        private string GetStopCondition() => foos.Aggregate(new StringBuilder(), (sb, foo) => sb.Append(foo.ToString(foo.number))).ToString();
    }
}