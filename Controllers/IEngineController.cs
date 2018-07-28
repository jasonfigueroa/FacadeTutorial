namespace FacadeTutorial.Controllers
{
    public interface IEngineController
    {
        bool Running { get; }
        void Start();
        void Stop();
    }
}