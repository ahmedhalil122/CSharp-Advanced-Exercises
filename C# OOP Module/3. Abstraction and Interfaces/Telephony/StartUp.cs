using Telephony.Core;
using Telephony.Interfaces;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
         Engine engine = new Engine();
            engine.Run();
        }
    }
}