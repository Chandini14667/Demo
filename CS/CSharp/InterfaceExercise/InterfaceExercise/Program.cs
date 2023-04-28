using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    interface IVehiculo
    {
        void Drive();

        bool Refuel(int value);
    }

    class Car : IVehiculo
    {
        int gasoline;
        public Car(int Gasoline)
        {
            gasoline = Gasoline;
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("The car is not driving.");

            }
        }

        public bool Refuel(int gasolineToAdd)
        {
            gasoline += gasolineToAdd;
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of gasoline to refuel: ");
            int gasolineToAdd = int.Parse(Console.ReadLine());

            Car myCar = new Car(0);
            myCar.Refuel(gasolineToAdd);
            myCar.Drive();
        }
    }
}
