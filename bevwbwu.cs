namespace CWTrainer
{
    class Offsets
    {
        internal static string version = "1.10.6.8845202";

        public static class Bases
        {
            public static int Globalstats_Pregame = 0x1360CD10; //1.10.1

            public static int PlayerBase = 0x109BCE20; //1.10.1

            public static int XPScaleBase = 0x109E4E18; //1.10.1

            public static int CMDBufferBase = 0x121AA300; // + 0x50418; //1.10.1

            public static int TimeScaleBase = 0xF494A64; //1.10.1

            public static int JumpHeightBase = 0x10AB3B58; //1.10.1
        }

        public static class PlayerCompPtr
        {
            public static int PC_Coords = 0xDE8; // Vector3 Writeable
            public static int ArraySizeOffset = 0xB940; //1.9.0
            public static int InfraredVision = 0xE66;
            public static int GodMode = 0xE67;
            public static int RunSpeed = 0x5C60; //1.9.0
            public static int AutoFire = 0xE70;
            public static int Ammo = 0x13D4;
            public static int Points = 0x5D14; //1.9.0
            public static int RapidFire1 = 0xE6C;
            public static int RapidFire2 = 0xE80;
            public static int Name = 0x5C0A; //1.9.0
            public static int CurrentUsedWeaponID = 0x28;
            public static int SetWeaponID = 0xB0; // + (0-5 * 0x40 for WP1 to WP6)

            public static int CritKill1 = 0x10CC;
            public static int CritKill2 = 0x10D2;
            public static int CritKill3 = 0x10E4;
            public static int CritKill4 = 0x10E8;
            public static int CritKill5 = 0x10C4;
            public static int CritKill6 = 0x10C8;
            public static int CritKill7 = 0x10D4;
            public static int CritKill8 = 0x10D6;
            public static int CritKill9 = 0x10D8; //1.10


            public static int KillCount = 0x5CE8;
        }

        public static class PlayerPedPtr
        {
            public static int Coords = 0x2D4;

            public static int HeadingXY = 0x38;

            public static int HeadingZ = 0x34;

            public static int ArraySizeOffset = 0x5F8;
        }

        public static class ZombieBotListBase
        {
            public static int BotMaxHealth = 0x39C;

            public static int BotHealth = 0x398;

            public static int BotArraySizeOffset = 0x5F8;

            public static int Coords = 0x2D4;
        }

        public static class ZombieGlobalClass
        {
            public static int ZombieLeftCount = 0x3C;
        }

        public static class ZombieXpScaleBase
        {
            public static int XPGun = 0x30; //XPGun_Offset

            public static int XPUserReal = 0x40; //0x10AC8BE8; //Real XPEP_RealAdd_Offset

            public static int xp_address_1 = 0x108674D0;

            public static int xp_address_2 = 0x108674D8;

            public static int weaponxp = 0x108674E0;
            //public static int ZMXPFake = 0x10AC8BE0;
        }

        public static class CommandManager
        {
            public static int SendCommand = 0x120A35A5; //0x10DD4A80;

            public static int ExecuteCommand = SendCommand - 0x1B;
        }
    }
}
