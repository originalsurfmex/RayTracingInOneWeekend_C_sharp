using System;

namespace RayTracingOneWeekend
{
    class Program
    {
        /// <summary>
        /// Ray Tracing in One Weekend
        /// To Run in Powershell type this to avoid BOM errors:
        /// > main.exe | set-content image.ppm -encoding String
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
/*
            //image
            const int image_width = 256;
            const int image_height = 256;

            //render
            Console.WriteLine("P3");
            Console.WriteLine($"{image_width} {image_height}");
            Console.WriteLine(255);

            for (int j = image_height - 1; j >= 0; j--)
            {
                //progress bar "\r" is like C++ flush
                //added extra spaces after {j} to also clear extra numbers
                Console.Error.Write($"\rScanlines Remaining: {j}   ");
                for (int i = 0; i < image_height; i++)
                {
                    var r = (double)i / (image_width - 1);
                    var g = (double)j / (image_height - 1);
                    var b = 0.25;

                    int ir = (int)(255.999 * r);
                    int ig = (int)(255.999 * g);
                    int ib = (int)(255.999 * b);

                    Console.WriteLine($"{ir} {ig} {ib}");
                }
            }
*/
            //done message
            Console.Error.WriteLine("\nDone");

            Console.WriteLine("Hello World");
            Vec3 testV = new Vec3(1, 2, 3);
            Vec3 testV2 = new Vec3();
            Vec3 testV3 = new Vec3(3, 4, 5);
            Console.WriteLine(-testV[1]);
            Console.WriteLine(testV.Z);
            Console.WriteLine(testV2);
            Console.WriteLine(testV += testV3);
            Console.WriteLine(testV);
            Console.WriteLine($"muliplication of vector and number: {testV *= 6}");
            Console.WriteLine($"division of vector and number: {testV /= 2}");
            Console.WriteLine(testV3[2]);
            Console.WriteLine(testV3.Length);

        }
    }
}
