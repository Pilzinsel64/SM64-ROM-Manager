using global::System.Drawing;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Data.System;
using global::SM64Lib.Model.Fast3D;
using Newtonsoft.Json;

namespace SM64Lib.Levels
{
    public class LevelBG
    {
        private Bitmap _Image = null;

        // A u t o   P r o p e r t i e s

        public byte[] ImageData { get; set; } = null;
        public bool Enabled { get; set; } = true;
        public bool IsCustom { get; set; } = false;
        public Geolayout.BackgroundIDs ID { get; set; } = Geolayout.BackgroundIDs.Ocean;

        // A u t o   P r o p e r t i e s

        [JsonIgnore]
        public Bitmap Image
        {
            get
            {
                if (_Image is object)
                {
                    return _Image;
                }
                else
                {
                    var img = GetImage();
                    _Image = (Bitmap)img;
                    return (Bitmap)img;
                }
            }
        }

        [JsonIgnore]
        public int ImageLength
        {
            get
            {
                return ImageData?.Length ?? 0;
            }
        }

        [JsonIgnore]
        public bool HasImage
        {
            get
            {
                return ImageData is object;
            }
        }

        // C o n s t r c u t o r s

        public LevelBG()
        {
        }

        public LevelBG(Geolayout.BackgroundIDs ID)
        {
            this.ID = ID;
        }

        public LevelBG(Image Image)
        {
            ID = Geolayout.BackgroundIDs.Custom;
            SetImage(Image);
        }

        // M e t h o d s

        public void WriteImage(Stream s, int offset)
        {
            // Write Image Data
            s.Position = offset;
            if (ImageData is object)
            {
                s.Write(ImageData, 0, ImageData.Length);
            }
        }

        public void ReadImage(Stream s, int offset)
        {
            // Read Image Data
            ImageData = new byte[131072];
            s.Position = offset;
            s.Read(ImageData, 0, ImageData.Length);
            _Image = null;
        }

        public void SetImage(Image image)
        {
            SetImage(new Bitmap(image));
        }

        public void SetImage(Bitmap bmp)
        {
            var s = new Size(248, 248); // ((&H20140 - &H140) / 256 / 2 / 32) * 31)
            if (bmp.Size != s)
            {
                bmp = (Bitmap)TextureManager.ResizeImage(bmp, s, false);
            }

            ImageData = BackgroundImageConverter.GetBytes(bmp);
            _Image = null;
        }

        public Image GetImage()
        {
            if (ImageData is object)
            {
                var s = new Size(248, 248); // ((_ImageByts.Length - &H140) / 256 / 2 / 32) * 31)
                var img = BackgroundImageConverter.GetImage(ImageData, s);
                _Image = img;
                return img;
            }
            else
            {
                return null;
            }
        }

        public static byte[] GetBackgroundPointerTable()
        {
            return new byte[] { 0xA, 0x0, 0x0, 0x0, 0xA, 0x0, 0x8, 0x0, 0xA, 0x0, 0x10, 0x0, 0xA, 0x0, 0x18, 0x0, 0xA, 0x0, 0x20, 0x0, 0xA, 0x0, 0x28, 0x0, 0xA, 0x0, 0x30, 0x0, 0xA, 0x0, 0x38, 0x0, 0xA, 0x0, 0x0, 0x0, 0xA, 0x0, 0x8, 0x0, 0xA, 0x0, 0x40, 0x0, 0xA, 0x0, 0x48, 0x0, 0xA, 0x0, 0x50, 0x0, 0xA, 0x0, 0x58, 0x0, 0xA, 0x0, 0x60, 0x0, 0xA, 0x0, 0x68, 0x0, 0xA, 0x0, 0x70, 0x0, 0xA, 0x0, 0x78, 0x0, 0xA, 0x0, 0x40, 0x0, 0xA, 0x0, 0x48, 0x0, 0xA, 0x0, 0x80, 0x0, 0xA, 0x0, 0x88, 0x0, 0xA, 0x0, 0x90, 0x0, 0xA, 0x0, 0x98, 0x0, 0xA, 0x0, 0xA0, 0x0, 0xA, 0x0, 0xA8, 0x0, 0xA, 0x0, 0xB0, 0x0, 0xA, 0x0, 0xB8, 0x0, 0xA, 0x0, 0x80, 0x0, 0xA, 0x0, 0x88, 0x0, 0xA, 0x0, 0xC0, 0x0, 0xA, 0x0, 0xC8, 0x0, 0xA, 0x0, 0xD0, 0x0, 0xA, 0x0, 0xD8, 0x0, 0xA, 0x0, 0xE0, 0x0, 0xA, 0x0, 0xE8, 0x0, 0xA, 0x0, 0xF0, 0x0, 0xA, 0x0, 0xF8, 0x0, 0xA, 0x0, 0xC0, 0x0, 0xA, 0x0, 0xC8, 0x0, 0xA, 0x1, 0x0, 0x0, 0xA, 0x1, 0x8, 0x0, 0xA, 0x1, 0x10, 0x0, 0xA, 0x1, 0x18, 0x0, 0xA, 0x1, 0x20, 0x0, 0xA, 0x1, 0x28, 0x0, 0xA, 0x1, 0x30, 0x0, 0xA, 0x1, 0x38, 0x0, 0xA, 0x1, 0x0, 0x0, 0xA, 0x1, 0x8, 0x0, 0xA, 0x1, 0x40, 0x0, 0xA, 0x1, 0x48, 0x0, 0xA, 0x1, 0x50, 0x0, 0xA, 0x1, 0x58, 0x0, 0xA, 0x1, 0x60, 0x0, 0xA, 0x1, 0x68, 0x0, 0xA, 0x1, 0x70, 0x0, 0xA, 0x1, 0x78, 0x0, 0xA, 0x1, 0x40, 0x0, 0xA, 0x1, 0x48, 0x0, 0xA, 0x1, 0x80, 0x0, 0xA, 0x1, 0x88, 0x0, 0xA, 0x1, 0x90, 0x0, 0xA, 0x1, 0x98, 0x0, 0xA, 0x1, 0xA0, 0x0, 0xA, 0x1, 0xA8, 0x0, 0xA, 0x1, 0xB0, 0x0, 0xA, 0x1, 0xB8, 0x0, 0xA, 0x1, 0x80, 0x0, 0xA, 0x1, 0x88, 0x0, 0xA, 0x1, 0xC0, 0x0, 0xA, 0x1, 0xC8, 0x0, 0xA, 0x1, 0xD0, 0x0, 0xA, 0x1, 0xD8, 0x0, 0xA, 0x1, 0xE0, 0x0, 0xA, 0x1, 0xE8, 0x0, 0xA, 0x1, 0xF0, 0x0, 0xA, 0x1, 0xF8, 0x0, 0xA, 0x1, 0xC0, 0x0, 0xA, 0x1, 0xC8, 0x0 };
        }

        // C l a s s e s

        private class BackgroundImageConverter
        {
            public static Bitmap GetImage(byte[] data, Size size)
            {
                var ms = new MemoryStream(data);
                var br = new BinaryReader(ms);
                var img = new Bitmap(size.Width, size.Height);
                uint current_address = 0;
                for (int y = 0, loopTo = (int)(size.Height / (double)31 - 1); y <= loopTo; y++)
                {
                    for (int x = 0, loopTo1 = (int)(size.Width / (double)31 - 1); x <= loopTo1; x++)
                    {
                        ParseBlock(br, img, current_address, new Rectangle(x * 31, y * 31, 31, 31));
                        current_address += 2048;
                    }
                }

                ms.Close();
                return img;
            }

            private static void ParseBlock(BinaryReader br, Bitmap map, uint address, Rectangle rect)
            {
                for (int yy = 0, loopTo = rect.Height - 1; yy <= loopTo; yy++)
                {
                    for (int xx = 0, loopTo1 = rect.Width - 1; xx <= loopTo1; xx++)
                    {
                        int offset = (int)(address + (yy * (rect.Width + 1) + xx) * 2);
                        br.BaseStream.Position = offset;
                        ushort pixel = SwapInts.SwapUInt16(br.ReadUInt16());
                        byte red = Conversions.ToByte((pixel >> 11 & 0x1F) * 8);
                        byte green = Conversions.ToByte((pixel >> 6 & 0x1F) * 8);
                        byte blue = Conversions.ToByte((pixel >> 1 & 0x1F) * 8);
                        byte alpha = Conversions.ToByte((pixel & 1) > 0 ? 0xFF : 0);
                        var pixcol = Color.FromArgb(alpha, red, green, blue);
                        map.SetPixel(rect.X + xx, rect.Y + yy, pixcol);
                    }
                }
            }

            public static byte[] GetBytes(Bitmap img)
            {
                var ms = new MemoryStream();
                var bw = new BinaryWriter(ms);
                int wTiles = (int)(img.Width / (double)31);
                int hTiles = (int)(img.Height / (double)31);
                int current_address = 0;
                for (int y = 0, loopTo = hTiles - 1; y <= loopTo; y++)
                {
                    for (int x = 0, loopTo1 = wTiles - 1; x <= loopTo1; x++)
                    {
                        ConvertBlock(bw, img, Conversions.ToUInteger(current_address), x * 31, y * 31, 0, 0, 0, 0, 31, 31, 32);
                        if (x < wTiles - 1)
                        {
                            ConvertBlock(bw, img, Conversions.ToUInteger(current_address), (x + 1) * 31 - 30, y * 31, 30, 0, 1, 0, 31, 31, 32);
                            ConvertBlock(bw, img, Conversions.ToUInteger(current_address), (x + 1) * 31 - 30, y * 31, 30, 30, 1, 1, 31, 31, 32);
                        }
                        else
                        {
                            ConvertBlock(bw, img, Conversions.ToUInteger(current_address), -30, y * 31, 30, 0, 1, 0, 31, 31, 32);
                            ConvertBlock(bw, img, Conversions.ToUInteger(current_address), -30, y * 31, 30, 30, 1, 1, 31, 31, 32);
                        }

                        if (y < hTiles - 1)
                        {
                            ConvertBlock(bw, img, Conversions.ToUInteger(current_address), x * 31, (y + 1) * 31 - 30, 0, 30, 0, 1, 31, 31, 32);
                        }
                        else
                        {
                            ConvertBlock(bw, img, Conversions.ToUInteger(current_address), x * 31, -30, 0, 30, 0, 1, 31, 31, 32);
                        }

                        current_address += 2048;
                    }
                }

                var temp = ms.ToArray();
                ms.Close();
                return temp;
            }

            private static void ConvertBlock(BinaryWriter bw, Bitmap map, uint address, int src_x, int src_y, int start_x, int start_y, int offset_x, int offset_y, int w, int h, int lineWidth)
            {
                for (int yy = start_y, loopTo = h - 1; yy <= loopTo; yy++)
                {
                    for (int xx = start_x, loopTo1 = w - 1; xx <= loopTo1; xx++)
                    {
                        var pixel = map.GetPixel(src_x + xx, src_y + yy);
                        int r = pixel.R / 8;
                        int g = pixel.G / 8;
                        int b = pixel.B / 8;
                        int a = pixel.A == 0xFF ? 1 : 0;
                        bw.BaseStream.Position = address + ((yy + offset_y) * lineWidth + xx + offset_x) * 2;
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(r << 11 | g << 6 | b << 1 | a)));
                    }
                }
            }
        }
    }
}