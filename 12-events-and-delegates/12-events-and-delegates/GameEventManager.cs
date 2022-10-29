using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_events_and_delegates
{
    public class GameEventManager
    {
        // create a new delegate type called GameEvent
        public delegate void GameEvent();

        // create two delegates variables called OnGameStart and OnGameOver
        public static GameEvent OnGameStart, OnGameOver;

        // a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            // check if the OnGameStart event is not empty
            // meaning that other methods already subscribed to it
            if (OnGameStart != null)
            {
                // print a simple message
                Console.WriteLine("The game has started....");
                // call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        // a static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            // check if the OnGameOver event is not empty
            // meaning that other methods already subscribed to it
            if (OnGameOver != null)
            {
                // print a simple message
                Console.WriteLine("The game has stopped!");
                // call the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();

            }
        }
    }
}
