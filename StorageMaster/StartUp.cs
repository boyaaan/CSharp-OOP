using System;

namespace StorageMaster
{
    using Controller;

    public class StartUp
    {
        public static void Main()
        {
            Engine engine = new Engine();
            
            engine.Run();
        }
    }
}
