using System;
using System.Drawing;

namespace SM64_ROM_Manager.EventArguments
{
    public class OtherStatusInfosChangedEventArgs : EventArgs
    {
        public string Text { get; private set; }
        public Color ForeColor { get; private set; }

        public OtherStatusInfosChangedEventArgs(string text, Color foreColor)
        {
            Text = text;
            ForeColor = foreColor;
        }
    }
}