using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace image_processor
{
    class ImageProcessor
    {
        private static string[] _filenames;

        public static void Inverse(string[] filenames)
        {
            Console.WriteLine(filenames[0]);
            _filenames = filenames;
            Thread.CurrentThread.Name = "Main";
            Task[] tasks = new Task[filenames.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                var i1 = i;
                tasks[i] = Task.Factory.StartNew(() =>
                {
                    InvertTask(filenames[i1]);
                });
            }
            
            Console.WriteLine("Starting Tasks");
            Task.WaitAll(tasks);
            Console.WriteLine("Finished Tasks");

            
        }


        private static void Invert()
        {
            foreach (var filename in _filenames)
            {
                Console.WriteLine($"Processing: {filename}");
                Image img = Image.FromFile(filename);

                Bitmap bitmap = new Bitmap(img);
                Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);

                for (int x = 0; x < bitmap.Width; x++)
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        var pixel = bitmap.GetPixel(x, y);
                        pixel = Color.FromArgb(pixel.ToArgb() ^ 0xffffff);
                        newBitmap.SetPixel(x,y, pixel);
                    }

                var fn = Path.GetFileNameWithoutExtension(filename);
                var ext = Path.GetExtension(filename);
                var file = $"images/{fn}_inverse.{ext}";
                newBitmap.Save(file);
                // var e = img.GetEncoderParameterList(Guid.Empty);
                // Console.WriteLine($"{e.Param}");
                
            }
        }
      
        private static void InvertTask(string filename)
        {
            Console.WriteLine($"Processing: {filename}");
                Image img = Image.FromFile(filename);

                Bitmap bitmap = new Bitmap(img);
                Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);

                for (int x = 0; x < bitmap.Width; x++)
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        var pixel = bitmap.GetPixel(x, y);
                        pixel = Color.FromArgb(pixel.ToArgb() ^ 0xffffff);
                        newBitmap.SetPixel(x,y, pixel);
                    }

                var fn = Path.GetFileNameWithoutExtension(filename);
                var ext = Path.GetExtension(filename);
                var file = $"images/{fn}_inverse.{ext}";
                newBitmap.Save(file);

        }
    }
}