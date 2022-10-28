using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_events_and_delegates
{
    public class RenderingEngine
    {
        // at the start of the game,
        // we want to enable the rendering engine and start drawing the visuals
        public void StartGame()
        {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visual...");
        }

        // when the game is over, we want to stop our rendering engine
        public void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
