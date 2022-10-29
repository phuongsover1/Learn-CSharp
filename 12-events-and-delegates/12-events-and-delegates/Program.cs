using System;
namespace _12_events_and_delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create an audio system
            AudioSystem audioSystem = new AudioSystem();

            // create a rendering engine
            RenderingEngine engine = new RenderingEngine();

            // create two players and give them Id's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running ... press any key to end the game.");
            // pause
            Console.Read();

            GameEventManager.TriggerGameOver();

        }


    }
}
