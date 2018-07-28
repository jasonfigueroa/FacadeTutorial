namespace FacadeTutorial.Controllers
{
    public interface ITractionControlController
    {
        bool Enabled { get; set; }
        void Enable();
        void Disable();
    }
}