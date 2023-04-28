namespace InterfacePractice
{
    interface IFirstInterface
    {
        void sum(int a, int b);
    }
    //interface ISecondInterface:IFirstInterface 
    interface ISecondInterface
    {
        void Sub(int a, int b);
    }
    class Demo: IFirstInterface,ISecondInterface 
    {
        public void sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.sum(1, 2);
            d.Sub(2, 1);
        }
    }
}