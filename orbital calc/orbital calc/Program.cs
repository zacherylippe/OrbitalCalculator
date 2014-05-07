using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace orbital_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gravityAndDragEst = 1.20512821; //wild estimate of gravitiational and air drag combined
            const double gravitationalConstant = .0000000000667384;
            double massEarth = 5.97219*(Math.Pow(10,24)); //I'm shocked this works
            double massKerbin = 5.2915793*(Math.Pow(10,22));
            const double kerbinRadius = 600000;
            const double earthRadius = 6371000;
            double desiredOrbit = 0;
            char planet = 'A';
            double orbit = 0;
            double radius = 0;
            double result = 0;

            Console.Write("Which planet would you like to calculate an orbit for?\r\n");
            Console.Write("K for Kerbin E for Earth.");
            planet = Convert.ToChar(Console.Read());
            if (planet == 'K')
            {
                radius = kerbinRadius;
            }
            else
            {
                radius = earthRadius;
            }
            Console.Write("What is the desired orbit in kilometers?");
            orbit = Console.ReadDouble();
            orbit = orbit * 1000;
            result = (gravitationalConstant * massEarth * (1/orbit));
            result = Math.Sqrt(result);
            Console.Write(result);
        }
    }
}
