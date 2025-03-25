namespace AsyncProgrammingExperiment
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task rabbitRace = BeginRaceForRabbitAsync();
            Task turtleRace = BeginRaceForTurtleAsync();
            Task snakeRace = BeginRaceForSnakeAsync();

            Task[] racers = { rabbitRace, turtleRace, snakeRace };

            try
            {
                await Task.WhenAll(racers);
            }
            catch (Exception e)
            {
                Console.WriteLine("The race was not completed by all runners: " + e.Message);
            }

            Console.WriteLine("The race has ended!");
            Console.ReadLine();
        }

        static async Task BeginRaceForRabbitAsync()
        {
            Console.WriteLine("Rabbit has started to hop towards the finish line.");
            await Task.Delay(2000);
            Console.WriteLine("Rabbit has reached the finish line!");
        }

        static async Task BeginRaceForTurtleAsync()
        {
            Console.WriteLine("Turtle has started to crawl towards the finish line.");
            await Task.Delay(7000);
            Console.WriteLine("Turtle has reached the finish line!");
        }

        static async Task BeginRaceForSnakeAsync()
        {
            Console.WriteLine("Snake has started to slither towards the finish line.");
            await Task.Delay(4000);
            // throw new InvalidOperationException("The snake has died");
            
            Console.WriteLine("Snake has reached the finish line!");
        }
    }
}
