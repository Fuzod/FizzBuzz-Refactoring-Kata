namespace FizzBuzz
{
    public class Foo
    {
        public readonly int number;
        private readonly string name;

        public Foo(int number, string name)
        {
            this.number = number;
            this.name = name;
        }

        public string ToString(int index)
        {
            return index % number == 0 ? name : string.Empty;
        }
    }
}