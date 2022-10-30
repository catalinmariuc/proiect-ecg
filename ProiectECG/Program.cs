using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectECG
{
    class Program
    {
        static void Main(string[] args)
        {
            Window3D window3d = new Window3D();
            window3d.Run(30.0, 0.0);
        }
    }
}
