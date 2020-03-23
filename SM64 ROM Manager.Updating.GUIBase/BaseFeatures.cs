using System;
using global::System.Drawing;
using global::System.Runtime.InteropServices;
using global::System.Windows.Forms;

namespace SM64_ROM_Manager.Updating.GUIBase
{
    internal static class BaseFeatures
    {
        [DllImport("user32")]
        private static extern uint SendMessage(IntPtr hWnd, uint msg, uint wParam, uint lParam);

        private const int BCM_FIRST = 0x1600; // Normal button
        private const int BCM_SETSHIELD = BCM_FIRST + 0xC; // Elevated button

        public static void AddShieldToButton(Button b)
        {
            b.FlatStyle = FlatStyle.System;
            SendMessage(b.Handle, BCM_SETSHIELD, 0, 0xFFFFFFFFU);
        }

        // Return a bitmap containing the UAC shield.
        private static Bitmap shield_bm = null;

        public static Bitmap GetUacShieldImage()
        {
            if (shield_bm is object)
            {
                return shield_bm;
            }

            const int WID = 50;
            const int HGT = 50;
            const int MARGIN = 4;

            // Make the button. For some reason, it must
            // have text or the UAC shield won't appear.
            var btn = new Button();
            btn.Text = " ";
            btn.Size = new Size(WID, HGT);
            AddShieldToButton(btn);

            // Draw the button onto a bitmap.
            var bm = new Bitmap(WID, HGT);
            btn.Refresh();
            btn.DrawToBitmap(bm, new Rectangle(0, 0, WID, HGT));

            // Find the part containing the shield.
            int min_x = WID;
            int max_x = 0;
            int min_y = HGT;
            int max_y = 0;

            // Fill on the left.
            int y = MARGIN;
            while (y < HGT - MARGIN)
            {
                // Get the leftmost pixel's color.
                var target_color = bm.GetPixel(MARGIN, y);

                // Fill in with this color as long as we see the target.
                int x = MARGIN;
                while (x < WID - MARGIN)
                {
                    // See if this pixel is part of the shield.
                    if (bm.GetPixel(x, y).Equals(target_color))
                    {
                        // It's not part of the shield.
                        // Clear the pixel.
                        bm.SetPixel(x, y, Color.Transparent);
                    }
                    else
                    {
                        // It's part of the shield.
                        if (min_y > y)
                        {
                            min_y = y;
                        }

                        if (min_x > x)
                        {
                            min_x = x;
                        }

                        if (max_y < y)
                        {
                            max_y = y;
                        }

                        if (max_x < x)
                        {
                            max_x = x;
                        }
                    }

                    x += 1;
                }

                y += 1;
            }

            // Clip out the shield part.
            int shield_wid = max_x - min_x + 1;
            int shield_hgt = max_y - min_y + 1;
            shield_bm = new Bitmap(shield_wid, shield_hgt);
            var shield_gr = Graphics.FromImage(shield_bm);
            shield_gr.DrawImage(bm, 0, 0, new Rectangle(min_x, min_y, shield_wid, shield_hgt), GraphicsUnit.Pixel);

            // Return the shield.
            return shield_bm;
        }
    }
}