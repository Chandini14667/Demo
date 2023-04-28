namespace GeneticsPractice
{
    class Demo<S>
    {
        S num;
        public void SetValue(S value)
        {
            num = value;
        }
        public S GetValue()
        {
            return num;
        }
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo<int> d = new Demo<int>();
            d.SetValue(20);
            Console.WriteLine(d.GetValue());

            Demo<string> d1 = new Demo<string>();
            d1.SetValue("Chandini");
            Console.WriteLine(d1.GetValue());

            Demo<float> d2 = new Demo<float>();
            d2.SetValue(2.4f);
            Console.WriteLine(d2.GetValue());
        }
    }
}