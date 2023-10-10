namespace StaticDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cannot make an instance of a static class
            //var helper = new MathHelper();

            Console.WriteLine(Classroom.Subject);

            var classOne = new Classroom();

            classOne.RoomNumber = 1;

            Console.WriteLine();

            var classTwo = new Classroom();

            classTwo.RoomNumber = 2;

            Classroom.Subject = "Java";

            Console.WriteLine(Classroom.Subject);
           

            Greet("Seth");

        }

        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}