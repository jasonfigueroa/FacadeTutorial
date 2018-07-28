using System;

namespace FacadeTutorial.Controllers
{
    public class TractionControlController : ITractionControlController
    {
        public bool Enabled { get; set; }

        public void Enable()
        {
            Enabled = true;
            Console.WriteLine("Traction controlled enabled");
        }
        
        public void Disable()
        {
            Enabled = false;
            Console.WriteLine("Traction controlled disabled");
        }
    }
}