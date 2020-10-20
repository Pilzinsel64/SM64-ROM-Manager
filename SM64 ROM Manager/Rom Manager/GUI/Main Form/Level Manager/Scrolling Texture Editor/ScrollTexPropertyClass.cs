using global::System.ComponentModel;
using global::SM64Lib.Levels.ScrolTex;

namespace SM64_ROM_Manager
{
    public class ScrollTexPropertyClass
    {
        [Browsable(false)]
        public ManagedScrollingTexture ScrollingTexture { get; private set; }

        public ScrollTexPropertyClass(ManagedScrollingTexture scrollTex)
        {
            ScrollingTexture = scrollTex;
        }

        [DisplayName("Group ID")]
        [Description("Indicates the group ID (by default deticted to the used texture).")]
        [Category("Grouping")]
        public short GroupID
        {
            get
            {
                return ScrollingTexture.GroupID;
            }

            set
            {
                ScrollingTexture.GroupID = value;
            }
        }

        [DisplayName("Behavior")]
        [Description("Indicates the axis and behavior.")]
        [Category("Behavior")]
        //[DevComponents.DotNetBar.PropertyMultiChoiceEditor(new string[] { "X-Scrolling", "Y-Scrolling", "Z-Scrolling", "UV-Scrolling Back/Forth", "UV-Scrolling Left/Right" }, new object[] { ScrollBehavior.ScrollingX, ScrollBehavior.ScrollingY, ScrollBehavior.ScrollingZ, ScrollBehavior.ScrollUVBackAndForth, ScrollBehavior.ScrollUVLeftAndRight })] // <PropertyMultiChoiceEditor("X-Scrolling,Y-Scrolling,Z-Scrolling,Scroll UV Back and Forth,Scroll UV Left and Right", True)>
        public ScrollBehavior Behavior
        {
            get
            {
                return ScrollingTexture.Behavior;
            }

            set
            {
                ScrollingTexture.Behavior = value;
            }
        }

        [DisplayName("Type")]
        [Description("Indicates the scroll type.")]
        [Category("Behavior")]
        //[DevComponents.DotNetBar.PropertyMultiChoiceEditor(new string[] { "Normal Scrolling", "Jumping Scroll", "Sine Wave" }, new object[] { ScrollType.NormalScrolling, ScrollType.JumpingScroll, ScrollType.SineWave })]
        public ScrollType Type
        {
            get
            {
                return ScrollingTexture.Type;
            }

            set
            {
                ScrollingTexture.Type = value;
            }
        }

        [DisplayName("Scrolling Speed")]
        [Description("The Scrolling Speed per Frame (less then 0x1000).")]
        [Category("Params")]
        public short ScrollingSpeed
        {
            get
            {
                return ScrollingTexture.ScrollingSpeed;
            }

            set
            {
                ScrollingTexture.ScrollingSpeed = value;
            }
        }

        [DisplayName("Face Count")]
        [Description("Amount of vertices to count.")]
        [Category("Data")]
        public ushort FacesCount
        {
            get
            {
                return ScrollingTexture.FacesCount;
            }

            set
            {
                ScrollingTexture.FacesCount = value;
            }
        }

        [DisplayName("Vertex Pointer")]
        [Description("Pointer to the vertices.")]
        [Category("Data")]
        public int VertexPointer
        {
            get
            {
                return ScrollingTexture.VertexPointer;
            }

            set
            {
                ScrollingTexture.VertexPointer = value;
            }
        }

        [DisplayName("Cycle Duration")]
        [Description("Cycle duration of the sine wave or jumpy scrolling.")]
        [Category("Params")]
        public byte CycleDuration
        {
            get
            {
                return ScrollingTexture.CycleDuration;
            }

            set
            {
                ScrollingTexture.CycleDuration = value;
            }
        }

        [DisplayName("Act 1")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 1.")]
        public bool Act1
        {
            get
            {
                return ScrollingTexture.Act1;
            }

            set
            {
                ScrollingTexture.Act1 = value;
            }
        }

        [DisplayName("Act 2")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 2.")]
        public bool Act2
        {
            get
            {
                return ScrollingTexture.Act2;
            }

            set
            {
                ScrollingTexture.Act2 = value;
            }
        }

        [DisplayName("Act 3")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 3.")]
        public bool Act3
        {
            get
            {
                return ScrollingTexture.Act3;
            }

            set
            {
                ScrollingTexture.Act3 = value;
            }
        }

        [DisplayName("Act 4")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 4.")]
        public bool Act4
        {
            get
            {
                return ScrollingTexture.Act4;
            }

            set
            {
                ScrollingTexture.Act4 = value;
            }
        }

        [DisplayName("Act 5")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 5.")]
        public bool Act5
        {
            get
            {
                return ScrollingTexture.Act5;
            }

            set
            {
                ScrollingTexture.Act5 = value;
            }
        }

        [DisplayName("Act 6")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible if you select Star 6.")]
        public bool Act6
        {
            get
            {
                return ScrollingTexture.Act6;
            }

            set
            {
                ScrollingTexture.Act6 = value;
            }
        }

        [DisplayName("All Acts")]
        [Category("Acts")]
        [Description("If Yes, the Object will be visible always.")]
        public bool AllActs
        {
            get
            {
                return ScrollingTexture.AllActs;
            }

            set
            {
                ScrollingTexture.AllActs = value;
            }
        }
    }
}