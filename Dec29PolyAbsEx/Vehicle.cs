using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29PolyAbsEx
{
    public abstract class Vehicle
    {
        public abstract void Start(); public abstract void Stop();
        static void Main(string[] args)
        {
            Vehicle v1 = new Car(); v1.Start(); v1.Stop();
            Vehicle v2 = new Train(); v2.Start(); v2.Stop();
        }
    }
    public class Car : Vehicle { public override void Start() { Console.WriteLine("car start by key igneation"); } public override void Stop() { Console.WriteLine("by pressing break"); } }//end of car
    public class Train : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine(" Train runs on Power ");
        }

        public override void Stop() { Console.WriteLine("stops by off power"); }
        static void Main(string[] args)
        {
            Vehicle v1 = new Car(); v1.Start(); v1.Stop();
            Vehicle v2 = new Train(); v2.Start(); v2.Stop();
        }
    }
} // end of train
