using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Geolayout
{
    public class CameraFrustrum
    {
        /// <summary>
        /// This is essentially render distance of geometry.
        /// </summary>
        public short CameraFar { get; set; } = 0x64;
        /// <summary>
        /// Defines how close to the camera geometry will render.
        /// </summary>
        public short CameraNear { get; set; } = 0x7530;
    }
}
