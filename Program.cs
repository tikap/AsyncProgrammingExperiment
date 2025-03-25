namespace AsyncProgrammingExperiment
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var rabbitRace = BeginRaceForRabbitAsync();
            var turtleRace = BeginRaceForTurtleAsync();
            var snakeRace = BeginRaceForSnakeAsync();

            // Task[] racers = { rabbitRace, turtleRace, snakeRace };

            string bunnyName = "";
            string turtleName = "";
            string snakeName = "";

            try
            {
                bunnyName = await rabbitRace;
                turtleName = await turtleRace;
                snakeName = await snakeRace;
            }
            catch (Exception e)
            {
                Console.WriteLine("The race was not completed by all runners: " + e.Message);
            }

            Console.WriteLine($"The race has ended. Congratulation {bunnyName}, {turtleName} and {snakeName}!");
            Console.ReadLine();
        }

        static async Task<string> BeginRaceForRabbitAsync()
        {
            Console.WriteLine("Rabbit has started to hop towards the finish line.");
            await Task.Delay(2000);
            Console.WriteLine("Rabbit has reached the finish line!");

            return "Mr. Looney";
        }

        static async Task<string> BeginRaceForTurtleAsync()
        {
            Console.WriteLine("Turtle has started to crawl towards the finish line.");
            await Task.Delay(7000);
            Console.WriteLine("Turtle has reached the finish line!");

            return "Mr. Slowy";
        }

        static async Task<string> BeginRaceForSnakeAsync()
        {
            Console.WriteLine("Snake has started to slither towards the finish line.");
            await Task.Delay(4000);
            // throw new InvalidOperationException("The snake has died");
            Console.WriteLine("Snake has reached the finish line!");

            return "Mr. Slithy";
        }
    }
}
