using GrandPrix.Core;
using System;

namespace GrandPrix
{
    public class StartUp
    {
        public static void Main()
        {
            var raceTower = new RaceTower();
            Engine engine = new Engine(raceTower);

            engine.Run();

        }
    }
}
