using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action act = new Action();
            Console.WriteLine("Yarıçapını giriniz:");
            int radius = Convert.ToInt32((Console.ReadLine()));
            act.DrawCircle(radius);
            
        }
    }
}
