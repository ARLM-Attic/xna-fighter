using System;

namespace XnaFighterWindows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (XnaFighterGame game = new XnaFighterGame())
            {
                game.Run();
            }
        }
    }
}

