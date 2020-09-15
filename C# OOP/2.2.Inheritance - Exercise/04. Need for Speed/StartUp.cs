namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle test1 = new Vehicle(100, 50);

            SportCar test2 = new SportCar(100, 50);
            Car test3 = new Car(100, 50);

            test1.Drive(5);
            test2.Drive(5);
            test3.Drive(5);

            System.Console.WriteLine(test1.Fuel);
            System.Console.WriteLine(test2.Fuel);
            System.Console.WriteLine(test3.Fuel);
        }
    }
}
