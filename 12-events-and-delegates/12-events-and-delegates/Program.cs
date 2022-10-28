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

            // start the audio system and the rendering engine
            audioSystem.StartGame();
            engine.StartGame();

            // spawn the players
            player1.StartGame();
            player2.StartGame();

            Console.WriteLine("Game is Running ... Press any key to end the game.");

            // pause the game
            Console.Read();

            // shutdown the rendering engine and audio system
            audioSystem.GameOver();
            engine.GameOver();

            // remove the players
            player1.GameOver();
            player2.GameOver();

        }


    }
}
