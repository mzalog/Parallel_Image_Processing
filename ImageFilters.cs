using System.Drawing;

namespace Parallel_Image_Processing
{
    public static class ImageFilters
    {
        public static void ConvertToGrayscale(Bitmap image)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color originalColor = image.GetPixel(i, j);
                    int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    image.SetPixel(i, j, newColor);
                }
            }
        }

        public static void ApplyNegative(Bitmap image)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color originalColor = image.GetPixel(i, j);
                    Color newColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    image.SetPixel(i, j, newColor);
                }
            }
        }

        public static void ApplyThreshold(Bitmap image, int threshold)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color originalColor = image.GetPixel(i, j);
                    int intensity = (originalColor.R + originalColor.G + originalColor.B) / 3;
                    Color newColor = intensity >= threshold ? Color.White : Color.Black;
                    image.SetPixel(i, j, newColor);
                }
            }
        }

        public static void ApplyMirrorEffect(Bitmap image)
        {
            for (int i = 0; i < image.Width / 2; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color originalColor = image.GetPixel(i, j);
                    image.SetPixel(image.Width - 1 - i, j, originalColor);
                }
            }
        }
    }
}
