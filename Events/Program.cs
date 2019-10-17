namespace Events
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