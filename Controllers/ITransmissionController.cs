namespace FacadeTutorial.Controllers
{
    public interface ITransmissionController
    {
        int Gear { get; set; }
        int MaxGear { get; set; }
        void ShiftUp();
        void ShiftDown();
    }
}