using System;
using System.Drawing;
using global::SM64Lib.Geolayout;

namespace SM64_ROM_Manager.EventArguments
{
    public class LevelBackgroundModeChangedEventArgs : EventArgs
    {
        public int BackgroundMode { get; private set; }
        public BackgroundIDs BackgroundID { get; private set; }
        public Image BackgroundImage { get; private set; }

        public LevelBackgroundModeChangedEventArgs(int mode, BackgroundIDs id, Image image)
        {
            BackgroundMode = mode;
            BackgroundID = id;
            BackgroundImage = image;
        }
    }
}