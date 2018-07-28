namespace FacadeTutorial.Controllers
{
    public interface ITachometerController
    {
        int Rpm { get; set; }
        int Limit { get; }
    }
}