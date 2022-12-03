using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class AreaOfCircle
    {
        public void Area()
        {
            const float Pi = 3.14f;
            int radius = 10;
            float area=Pi*radius*radius;
            Console.WriteLine("Area of Circle is : "+area);
        }
    }
}
