using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;


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

            using var inputStream = Console.OpenStandardInput();
            using var reader = new StreamReader(inputStream);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split("\0");
                var imgPath = data[0];
                using var img = new Bitmap(imgPath);
                foreach (var labelName in data.Skip(1))
                {
                    Console.WriteLine(
                        "{0}\0{1}\0{2}\0{3}",
                        imgPath,
                        labelName,
                        random.Next(0, img.Width),
                        random.Next(0, img.Height)
                    );
                }
            }
        }
    }
}
