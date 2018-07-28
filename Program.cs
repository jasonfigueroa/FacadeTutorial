using System;
using FacadeTutorial.Controllers;

namespace FacadeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFacade vehicle = new VehicleFacade(new EngineController(),
                                                        new TransmissionController(),
                                                        new TractionControlController(),
                                                        new TachometerController());

            vehicle.Start();

            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(100);
                vehicle.Accelerate();
            }

            for (int i = 0; i < 30; i++)
            {
                System.Threading.Thread.Sleep(100);
                vehicle.Brake();
            }

            vehicle.Off();
        }
    }
}
