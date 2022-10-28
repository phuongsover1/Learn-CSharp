using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_events_and_delegates
{
    public class Player
    {
        public string PlayerName { get; set; }

        public Player(string playerName)
        {
            PlayerName = playerName;
        }  

        // at the start of the game, spawn the player.
        public void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}"); ;
        }

        // when the game is over, remove the player from the game
        public void GameOver()
        {
            Console.WriteLine($"Removing Player with ID: {PlayerName}"); ;
        }
    }
}
