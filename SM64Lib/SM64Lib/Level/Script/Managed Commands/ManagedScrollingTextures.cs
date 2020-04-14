using global::System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Data.System;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using SM64Lib.Configuration;

namespace SM64Lib.Levels.ScrolTex
{
    public class ManagedScrollingTexture : IManagedLevelscriptCommand
    {

        /// <summary>
        /// The underlying levelscript command which provide all the properties.
        /// </summary>
        /// <returns></returns>
        public LevelscriptCommand Command { get; private set; } = null;

        /// <summary>
        /// Creates a new managed scrolling texture instance with an new levelscript command.
        /// </summary>
        public ManagedScrollingTexture()
        {
            Command = new LevelscriptCommand("24 18 1F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 40 17 00");
            SaveProperties();
        }

        /// <summary>
        /// Creates a new managed scrolling texture instance using some data with an new levelscript command.
        /// </summary>
        /// <param name="facesCount">Amount of faces to count.</param>
        /// <param name="vertexPtr">Pointer to the Vertices.</param>
        /// <param name="groupID"></param>
        public ManagedScrollingTexture(ushort facesCount, int vertexPtr, short groupID) : this()
        {
            FacesCount = facesCount;
            VertexPointer = vertexPtr;
            GroupID = groupID;
        }

        /// <summary>
        /// Creates a new managed scrolling texture instance using an existing levelscript command.
        /// </summary>
        /// <param name="cmd">The levelscript command to use.</param>
        public ManagedScrollingTexture(LevelscriptCommand cmd)
        {
            Command = cmd;
            LoadProperties();
        }

        /// <summary>
        /// Indicates the group (by default deticted to the used texture).
        /// </summary>
        /// <returns></returns>
        [DisplayName("Group ID")]
        [Description("Indicates the group ID (by default deticted to the used texture).")]
        [Category("Grouping")]
        public short GroupID { get; set; } = 0;

        /// <summary>
        /// Indicates the cycle duration of sine wave or jumping scrolling.
        /// </summary>
        /// <returns></returns>
        [DisplayName("Behavior")]
        [Description("Indicates the axis and behavior.")]
        [Category("Behavior")]
        public ScrollBehavior Behavior { get; set; } = ScrollBehavior.ScrollUVBackAndForth;

        /// <summary>
        /// Indicates the scroll behavior.
        /// </summary>
        /// <returns></returns>
        [DisplayName("Type")]
        [Description("Indicates the scroll type.")]
        [Category("Behavior")]
        public ScrollType Type { get; set; } = ScrollType.NormalScrolling;

        /// <summary>
        /// The Scrolling Speed per Frame (less then 0x1000).
        /// </summary>
        /// <returns></returns>
        [DisplayName("Scrolling Speed")]
        [Description("The Scrolling Speed per Frame (less then 0x1000).")]
        [Category("Params")]
        public short ScrollingSpeed { get; set; } = 60;

        /// <summary>
        /// Indicates the duration of a cycle in frames.
        /// </summary>
        /// <returns></returns>
        [DisplayName("Cycle Duration")]
        [Description("Cycle duration of the sine wave or jumpy scrolling in frames.")]
        [Category("Params")]
        public byte CycleDuration { get; set; } = 20;

        /// <summary>
        /// Amount of faces to count.
        /// </summary>
        /// <returns></returns>
        [DisplayName("Vertex Data")]
        [Description("Amount of vertices to count.")]
        [Category("Data")]
        public ushort FacesCount { get; set; } = 0;

        /// <summary>
        /// Pointer to the vertices.
        /// </summary>
        /// <returns></returns>
        [DisplayName("Vertex Data")]
        [Description("Pointer to the vertices.")]
        [Category("Data")]
        public int VertexPointer { get; set; } = 0;
        [DisplayName("Act 1")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 1.")]
        public bool Act1 { get; set; } = true;
        [DisplayName("Act 2")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 2.")]
        public bool Act2 { get; set; } = true;
        [DisplayName("Act 3")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 3.")]
        public bool Act3 { get; set; } = true;
        [DisplayName("Act 4")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 4.")]
        public bool Act4 { get; set; } = true;
        [DisplayName("Act 5")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 5.")]
        public bool Act5 { get; set; } = true;
        [DisplayName("Act 6")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 6.")]
        public bool Act6 { get; set; } = false;

        [DisplayName("All Acts")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible always.")]
        public bool AllActs
        {
            get
            {
                return Act1 && Act2 && Act3 && Act4 && Act5 && !Act6;
            }

            set
            {
                Act1 = value;
                Act2 = value;
                Act3 = value;
                Act4 = value;
                Act5 = value;
                Act6 = false;
            }
        }

        public void LoadProperties()
        {
            CycleDuration = clScrollingTexture.GetCycleDuration(Command);
            VertexPointer = Conversions.ToInteger(clScrollingTexture.GetVertexPointer(Command));
            FacesCount = clScrollingTexture.GetCountOfFaces(Command);
            ScrollingSpeed = clScrollingTexture.GetScrollSpeed(Command);
            Type = (ScrollType)clScrollingTexture.GetScrollType(Command);
            Behavior = (ScrollBehavior)clScrollingTexture.GetScrollBehavior(Command);
            GroupID = clScrollingTexture.GetGroupID(Command);
            var acts = Bits.ByteToBoolArray(clNormal3DObject.GetActs(Command));
            Act1 = acts[7];
            Act2 = acts[6];
            Act3 = acts[5];
            Act4 = acts[4];
            Act5 = acts[3];
            Act6 = acts[2];
        }

        public void SaveProperties()
        {
            SaveProperties((ScrollTexConfig)null);
        }

        public void SaveProperties(ScrollTexConfig config)
        {
            SaveProperties(Command, config);
        }

        public void SaveProperties(LevelscriptCommand Command)
        {
            SaveProperties(Command, null);
        }

        public void SaveProperties(LevelscriptCommand Command, ScrollTexConfig config)
        {
            clScrollingTexture.SetCycleDuration(Command, CycleDuration);
            clScrollingTexture.SetVertexPointer(Command, Conversions.ToUInteger(VertexPointer));
            clScrollingTexture.SetCountOfFaces(Command, FacesCount);
            clScrollingTexture.SetScrollSpeed(Command, ScrollingSpeed);
            clScrollingTexture.SetScrollType(Command, (byte)Type);
            clScrollingTexture.SetScrollBehavior(Command, (byte)Behavior);
            clScrollingTexture.SetGroupID(Command, GroupID);
            clNormal3DObject.SetSegBehaviorAddr(Command,
                config is object && config.UseCustomBehavior && config.CustomBehaviorAddress > -1 ? (uint)config.CustomBehaviorAddress : 0x401700);
            var acts = new[] { false, false, false, false, false, false, false, false };
            acts[7] = Act1;
            acts[6] = Act2;
            acts[5] = Act3;
            acts[4] = Act4;
            acts[3] = Act5;
            acts[2] = Act6;
            clNormal3DObject.SetActs(Command, Bits.ArrayToByte(acts));
        }
    }

    public enum ScrollBehavior
    {
        ScrollingX = 0x0,
        ScrollingY = 0x20,
        ScrollingZ = 0x40,
        ScrollUVBackAndForth = 0x80,
        ScrollUVLeftAndRight = 0xA0
    }

    public enum ScrollType
    {
        NormalScrolling = 0x0,
        SineWave = 0x1,
        JumpingScroll = 0x2
    }
}