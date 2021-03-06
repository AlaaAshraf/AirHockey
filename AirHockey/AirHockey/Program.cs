using System;

namespace AirHockey
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (NewGame game = new NewGame())
            {
                game.Run();
            }
        }
    }
#endif
}

