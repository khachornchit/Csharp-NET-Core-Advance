using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockTower tower = new ClockTower();
            Person john = new Person("John", tower);
            tower.ChimeSixAM();
            tower.ChimeFivePM();
        }
    }
}
