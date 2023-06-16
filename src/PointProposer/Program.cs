using System;
using System.Drawing;
using System.Globalization;


namespace PointProposer
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            // allow reproducibility by allowing to provide initialization seed
            var seed = Environment.GetEnvironmentVariable("POINT_PROPOSER_SEED");
            if (!String.IsNullOrEmpty(seed))
            {
                random = new(Int32.Parse(seed, CultureInfo.InvariantCulture));
            }

            var imageCount = Int32.Parse(args[0], CultureInfo.InvariantCulture);
            var i = 1;
            while (i < args.Length)
            {
                string imgPath = args[i++];
                using var img = new Bitmap(imgPath);
                Console.WriteLine(imgPath);

                var labelCount = Int32.Parse(args[i++], CultureInfo.InvariantCulture);
                for (var k = 0; k < labelCount; k++)
                {
                    Console.WriteLine(
                        "{0} {1} {2}",
                        args[i++],
                        random.Next(0, img.Width),
                        random.Next(0, img.Height)
                    );
                }
            }
        }
    }
}
