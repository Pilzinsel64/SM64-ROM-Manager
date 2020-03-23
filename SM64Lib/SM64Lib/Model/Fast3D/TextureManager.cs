using System;
using global::System.Drawing;
using global::System.Drawing.Drawing2D;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.Model.Fast3D
{
    public static class TextureManager
    {
        public static void PrepaireImage(ref Bitmap bmp, RotateFlipType rotateFlipTexture, N64Graphics.N64Codec texFormat, bool fitImageSize)
        {
            if (fitImageSize)
            {
                int maxPixels = GetMaxPixls(texFormat);

                // Resize Texture
                if (bmp.Height * bmp.Width > maxPixels)
                {
                    int curPixels = bmp.Height * bmp.Width;
                    float verhälltnis = Conversions.ToSingle(Math.Sqrt(curPixels / (double)maxPixels));
                    float newHeight = bmp.Height / verhälltnis;
                    float newWidth = bmp.Width / verhälltnis;
                    int nhlog = Conversions.ToInteger(Math.Truncate(Math.Log(newHeight, 2)));
                    int nwlog = Conversions.ToInteger(Math.Truncate(Math.Log(newWidth, 2)));
                    newHeight = Conversions.ToSingle(Math.Pow(2, nhlog));
                    newWidth = Conversions.ToSingle(Math.Pow(2, nwlog));
                    bmp = (Bitmap)ResizeImage(bmp, new Size(Conversions.ToInteger(newHeight), Conversions.ToInteger(newWidth)));
                }
            }

            RotateFlipImage(bmp, rotateFlipTexture);
        }

        public static Image ResizeImage(Image image, Size size, bool preserveAspectRatio = false, bool forceSize = false)
        {
            var result = new Size();
            if (preserveAspectRatio)
            {
                float val = (float)(image.Size.Width / (double)size.Width);
                float num = (float)(image.Size.Height / (double)size.Height);
                if (num > val)
                {
                    result.Width = Conversions.ToInteger(Math.Truncate(size.Width * val));
                    result.Height = size.Height;
                }
                else if (num < val)
                {
                    result.Width = size.Width;
                    result.Height = Conversions.ToInteger(Math.Truncate(size.Height * num));
                }
                else
                {
                    result = size;
                }
            }
            else
            {
                result = size;
            }

            Image newImage = new Bitmap(image, forceSize ? size : result);
            using (var g = Graphics.FromImage(newImage))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.PageUnit = GraphicsUnit.Pixel;
                // g.InterpolationMode = InterpolationMode.HighQualityBicubic

                Point pointToDraw;
                if (forceSize && result.Width / (double)result.Height != size.Width / (double)size.Height)
                {
                    int px, py;
                    px = (int)((size.Width - result.Width) / (double)2);
                    py = (int)((size.Height - result.Height) / (double)2);
                    pointToDraw = new Point(px, py);
                }
                else
                {
                    pointToDraw = Point.Empty;
                }

                g.Clear(Color.Transparent);
                g.DrawImage(image, new Rectangle(pointToDraw, result));
                g.Dispose();
            }

            return newImage;
        }

        public static void RotateFlipImage(Bitmap bmp, RotateFlipType rotateFlipTexture)
        {
            if (rotateFlipTexture != RotateFlipType.RotateNoneFlipNone)
            {
                bmp.RotateFlip(rotateFlipTexture);
            }
        }

        public static int GetMaxPixls(N64Graphics.N64Codec texFormat)
        {
            switch (texFormat)
            {
                case N64Graphics.N64Codec.CI4:
                    return 64 * 64;
                case N64Graphics.N64Codec.CI8:
                    return 32 * 64;
                case N64Graphics.N64Codec.I4:
                    return 128 * 64;
                case N64Graphics.N64Codec.I8:
                    return 64 * 64;
                case N64Graphics.N64Codec.IA4:
                    return 128 * 64;
                case N64Graphics.N64Codec.IA8:
                    return 64 * 64;
                case N64Graphics.N64Codec.IA16:
                    return 32 * 64;
                case N64Graphics.N64Codec.RGBA16:
                    return 32 * 64;
                case N64Graphics.N64Codec.RGBA32:
                    return 32 * 32;
                default:
                    return 32 * 32;
            }
        }
    }
}