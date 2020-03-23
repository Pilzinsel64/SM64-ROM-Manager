
namespace SM64Lib.Levels
{
    public enum ObjectBank0x0C
    {
        Disabled,
        HauntedObjects,
        SnowObjects,
        AssortedEnemies1,
        DesertObjects,
        BigBobOmbBoss,
        AssortedEnemies2,
        WaterObjects,
        AssortedEnemies3,
        PeachYoshi,
        Switches,
        LavaObjects
    }

    public enum ObjectBank0x0D
    {
        Disabled,
        AssortedEnemies4,
        Moneybags,
        CastleObjects,
        GroundEnemies,
        WaterObjects2,
        Bowser
    }

    public enum ObjectBank0x0E
    {
        Disabled,
        HaundetHouse,
        CoolCoolMountain,
        InsideCastle,
        HazyMazeCave,
        ShiftingSandLand,
        BobOmbBattlefield,
        SnowandsLand,
        WetDryWorld,
        JollyRogerBay,
        TinyHugeIsland,
        TickTockClock,
        RainbowRide,
        CastleGrounds,
        Bowser1Course,
        VanishCap,
        Bowser2Course,
        Bowser3Course,
        LethalLavaLand,
        DireDireDocks,
        WhompsFortress,
        CastleCourtyard,
        WingCap,
        Bowser2Battle,
        Bowser3Battle,
        TallTallMountain
    }

    public enum ObjectBanks
    {
        Bank0x0C,
        Bank0x0D,
        Bank0x0E
    }

    public enum Levels : byte
    {
        HaundetHouse = 0x4,
        CoolCoolMountain,
        InsideCastle,
        HazyMazeCave,
        ShiftingSandLand,
        BobOmbsBattlefield,
        SnowManLand,
        WetDryWorld,
        JollyRogerBay,
        TinyHugeIsland,
        TickTockClock,
        RainbowRide,
        CastleGrounds,
        Bowser1Course,
        VanishCap,
        Bowser2Course,
        SecretAquarium,
        Bowser3Course,
        LethalLavaLand,
        DireDireDocks,
        WhompsFortress,
        EndCakePicture,
        CastleCourtyard,
        PeachsSecretSlide,
        MetalCap,
        WingCap,
        Bowser1Battle,
        RainbowClouds,
        Bowser2Battle = 0x21,
        Bowser3Battle,
        TallTallMountain = 0x24
    }

    public enum ScrollingTextureAxis
    {
        X,
        Y
    }

    public enum SpecialBoxType
    {
        Water,
        ToxicHaze,
        Mist
    }

    public enum WaterType
    {
        Default = 0x0,
        JRBWater = 0x20000,
        GreenWater = 0x30000,
        LavaWater = 0x40000
    }
}