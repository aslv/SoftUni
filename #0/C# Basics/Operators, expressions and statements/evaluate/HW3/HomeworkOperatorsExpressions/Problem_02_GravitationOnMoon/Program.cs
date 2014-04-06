using System;
using System.Threading;

class GravitationOnMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        float weightOnEarth = float.Parse(Console.ReadLine());
        float weightOnMoon = (weightOnEarth * 17) / 100;
        Console.WriteLine(weightOnMoon);
    }
}

