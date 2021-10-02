using System;
using System.Collections.Generic;
using System.Text;

namespace RGBCombiner
{
    class MyProgram
    {
        public void Run()
        {
            int red1 = 0;
            int red2 = 0;
            int green1 = 0;
            int green2 = 0;
            int blue1 = 0;
            int blue2 = 0;


            //get first RGB values
            Console.WriteLine("Red1");
            red1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Green1");
            green1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Blue1");
            blue1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //get second RGB values
            Console.WriteLine("Red2");
            red2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Green2");
            green2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Blue2");
            blue2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //check so numbers are even so they dont create decimals
            //red
            if (red1 % 2 == 0){ }
            else { red1 = red1 + 1; }
            if (red2 % 2 == 0) { }
            else { red2 = red2 + 1; }
            //green
            if (green1 % 2 == 0) { }
            else { green1 = green1 + 1; }
            if (green2 % 2 == 0) { }
            else { green2 = green2 + 1; }
            //blue
            if (blue1 % 2 == 0) { }
            else { blue1 = blue1 + 1; }
            if (blue2 % 2 == 0) { }
            else { blue2 = blue2 + 1; }




            //combine values
            //red
            if (red1 <= red2)
            {
                int red3 = red2 / 2 - red1 / 2;
                int red4 = red1 + red3;
                Console.WriteLine(red4);
            }
            else 
            {
                int red3 = red1 / 2 - red2 / 2;
                int red4 = red2 + red3;
                Console.WriteLine(red4);
            }

            //Green
            if (green1 <= green2)
            {
                int green3 = green2 / 2 - green1 / 2;
                int green4 = green1 + green3; 
                Console.WriteLine(green4);
            }
            else
            {
                int green3 = green1 / 2 - green2 / 2;
                int green4 = green2 + green3;
                Console.WriteLine(green4);
            }

            //Blue
            if (blue1 <= blue2)
            {
                int blue3 = blue2 / 2 - blue1 / 2;
                int blue4 = blue1 + blue3;
                Console.WriteLine(blue4);
            }
            else
            {
                int blue3 = blue1 / 2 - blue2 / 2;
                int blue4 = blue2 + blue3;
                Console.WriteLine(blue4);
            }
        }
    }
}
