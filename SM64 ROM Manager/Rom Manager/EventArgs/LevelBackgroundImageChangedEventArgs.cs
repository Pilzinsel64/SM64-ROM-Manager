using System;
using System.Drawing;
using global::SM64Lib.Geolayout;

namespace SM64_ROM_Manager.EventArguments
{
    public class LevelBackgroundImageChangedEventArgs : EventArgs
    {
        public BackgroundIDs BackgroundID { get; private set; }
        public Image BackgroundImage { get; private set; }

        public LevelBackgroundImageChangedEventArgs(BackgroundIDs id, Image image)
        {
            BackgroundID = id;
            BackgroundImage = image;
        }
    }
}