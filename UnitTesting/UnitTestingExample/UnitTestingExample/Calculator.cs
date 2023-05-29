namespace UnitTestingExample
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            return x / y;
        }
        public int Mod(int x, int y)
        {
            return x % y;
        }
        public int GreatestNumber(int a, int b)
        {
            return a > b ? a : b;
        }
        public IEnumerable<int> GetOddNumbers(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                if (i % 2 != 0)
                {
                    yield return i;
                }
            }
        }
    }
}