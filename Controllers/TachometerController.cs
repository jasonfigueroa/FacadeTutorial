namespace FacadeTutorial.Controllers
{
    public class TachometerController : ITachometerController
    {
        public int Rpm { get; set; }

        public int Limit { get; private set; }

        public TachometerController()
        {
            Limit = 5000;
        }
    }
}