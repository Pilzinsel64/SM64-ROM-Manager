using Newtonsoft.Json;
using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.HUD
{
    public abstract class HUDElement
    {
        [JsonProperty(nameof(DataInfo))]
        private HUDElementInfo dataInfo;

        public string Name { get; set; }
        public HUDElementInfo DataInfo => dataInfo;
        public bool? Visible { get; set; }

        public HUDElement(HUDElementInfo dataInfo)
        {
            this.dataInfo = dataInfo;
        }

        public virtual void LoadData(BinaryData data)
        {
            if (DataInfo.VisibleRomPosition.HasValue)
            {
                data.Position = DataInfo.VisibleRomPosition.Value;
                var checkVal = data.ReadInt16();
                Visible = checkVal == 0x2400;
            }
        }

        public virtual void SaveData(BinaryData data)
        {
            if (DataInfo.CanSetVisible && DataInfo.VisibleRomPosition.HasValue && Visible.HasValue)
            {
                short checkVal;

                if (Visible.Value)
                    checkVal = 0x2400;
                else
                    checkVal = 0x0C0B;

                data.Position = DataInfo.VisibleRomPosition.Value;
                data.Write(checkVal);
            }
        }
    }
}
