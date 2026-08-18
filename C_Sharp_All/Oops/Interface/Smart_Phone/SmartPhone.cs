using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Interface.Smart_Phone
{
    interface ICamera
    {
        void Start();
    }

    interface IMusicPlayer
    {
        void Start();
    }

    interface IGPS
    {
        void Start();
    }

    class Phone : ICamera, IMusicPlayer, IGPS
    {

        void ICamera.Start()
        {
            Console.WriteLine("Camera is starting...");
        }

        void IMusicPlayer.Start()
        {
            Console.WriteLine("Music Player is starting...");
        }

        void IGPS.Start()
        {
            Console.WriteLine("GPS navigation is starting...");
        }
    }


    class SmartPhone
    {
        static void Main1(string[] args)
        {
            SmartPhone sm = new SmartPhone();

            ((ICamera)sm).Start();
            ((IMusicPlayer)sm).Start();
            ((IGPS)sm).Start();

            Console.ReadLine();
        }
    }
}
