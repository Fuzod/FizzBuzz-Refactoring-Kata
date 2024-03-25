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
            string stopCondition = foos.Aggregate(new StringBuilder(), (sb, foo) => sb.Append(foo.ToString(foo.number))).ToString();

            for (int i = 1; keyword != stopCondition; i++)
            {
                keyword = Convert(i);
                Console.WriteLine(keyword);
            }
        }

        public string Convert(int number)
        {
            string result = string.Empty;
            foreach (Foo foo in foos)
            {
                result += foo.ToString(number);
            }

            return result.Length == 0 ? number.ToString() : result.ToString();
        }
    }
}