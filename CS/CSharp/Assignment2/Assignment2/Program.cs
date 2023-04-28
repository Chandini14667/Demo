namespace Assignment2
{
    class MyStack<T>
    {
        public int count;
        public T[] array;
        public MyStack()
        {
            array = new T[10];
            count = 0;
        }

        public void push(T obj)
        {
            array[count] = obj;
            count++;
        }

        public T pop()
        {
            T item = array[count - 1];
            count--;
            return item;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int z = 0;

            
            MyStack<int> myStack = new MyStack<int>();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);

            foreach (int i in myStack.array)
            {
                int p = 0;
                Console.WriteLine($"Pushed element{++p} : {i}");
            }
            Console.WriteLine($"Number of objects in the stack = {myStack.count}");

            Console.WriteLine($"Poped item-{++j} is: {myStack.pop()}");
            Console.WriteLine($"Poped item-{++j} is: {myStack.pop()}");


            
            MyStack<string> myStack1 = new MyStack<string>();
            myStack1.push("one");
            myStack1.push("two");
            myStack1.push("three");
            myStack1.push("four");

            foreach (string i in myStack1.array)
            {
                int p = 0;
                Console.WriteLine($"Pushed element{++p} : {i}");
            }
            Console.WriteLine($"Number of objects in the stack = {myStack1.count}");
            Console.WriteLine($"Poped item-{++z} is: {myStack1.pop()}");
            Console.WriteLine($"Poped item-{++z} is: {myStack1.pop()}");
        }
    }
}