using System;
using System.Collections.Generic;


namespace PointProposer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int imageNumber = Int32.Parse(args[0]);
            int i = 1;
            while(i < args.Length) {
                string imgName = args[i++];
                Console.WriteLine(imgName);
                int labelCount = Int32.Parse(args[i++]);
                for(int k=0; k<labelCount; k++)
                {
                    Console.WriteLine("{0} {1} {2}", args[i++],random.NextDouble(),random.NextDouble());
                }
            }


        }
    }
}
