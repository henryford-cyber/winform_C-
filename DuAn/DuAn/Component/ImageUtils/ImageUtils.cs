using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn.Component.ImageUtils
{
    public class ImageUtils
    {
        public static string AppPathImage = $"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\Assets\\Resources\\Images\\";

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string Store(string path, string imageName)
        {

            Image img = Image.FromFile(path);

            // assign safe name for saving
            string imgSafeName = imageName;

            // give generic banner name so only one file exists at a time
            string[] nameArray = imgSafeName.Split('.');

            string imgTempName = nameArray[0];
            string extension = nameArray[1];

            imgTempName = RandomString(20);

            string pngString = imgTempName + ".png";

            // get debug folder path
            string nameImage = $"{RandomString(20)}.{extension}";
            string locationImage = $"{AppPathImage}{nameImage}";

            // check if file path exits
            if (!Directory.Exists(AppPathImage))
            {
                Directory.CreateDirectory(AppPathImage);
            }


            // if file exists, delete existing banner ad
            if (File.Exists(locationImage))
            {
                File.Delete(locationImage);
            }


            // save new banner ad
            File.Copy(path, locationImage);

            // If the file was not a png, reopen file and save it as a png
            if (!extension.Equals("png"))
            {
                // resave as png
                System.Drawing.Image image = System.Drawing.Image.FromFile(locationImage);
                image.Save(AppPathImage + pngString, System.Drawing.Imaging.ImageFormat.Png);
            }

            return nameImage;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="path">Path Image.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(string path, int width, int height)
        {
            Image image = Image.FromFile(path);
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
