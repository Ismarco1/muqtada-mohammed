namespace OOP_HomeWork
{
    class Vehical
    {
        public string brand;
    }
    class MotorVehical : Vehical
    {
        public string modelName;
    }
    class Car : MotorVehical
    {
        public Car(string brand, string modelName)
        {
            this.brand = brand;
            this.modelName = modelName;
        }
    }
    class Truck : MotorVehical
    {
        public Truck(string brand, string modelName)
        {
            this.brand = brand;
            this.modelName = modelName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Truck mytrck = new Truck("BMW", "C600");
            Car mycar = new Car("volvo", "B50");
            Console.WriteLine($"my car brand is  {mycar.brand} and model is {mycar.modelName}");
            Console.WriteLine($"my truck brand is  {mytrck.brand} and model is {mytrck.modelName}");


        }
    }
}
