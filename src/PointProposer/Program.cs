using System;
using System.Drawing;


namespace PointProposer
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var imageCount = Int32.Parse(
                args[0], System.Globalization.CultureInfo.CurrentCulture
            );
            var i = 1;
            while (i < args.Length)
            {
                string imgPath = args[i++];
                using var img = new Bitmap(imgPath);
                Console.WriteLine(imgPath);

                var labelCount = Int32.Parse(
                    args[i++], System.Globalization.CultureInfo.CurrentCulture
                );
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
