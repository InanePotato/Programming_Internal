using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class GlobalVariables
    {
        private static int v_UnitUpgrades_Basic;
        private static int v_UnitUpgrades_Range;
        private static int v_UnitUpgrades_Magic;
        private static int v_UnitUpgrades_Gun;
        private static int v_UnitUpgrades_Giant;
        private static int v_PauseCoverX;
        private static int v_PauseCoverY;
        private static int v_PauseCoverWidth;
        private static int v_PauseCoverHeight;
        private static int v_Coins;
        private static int v_Strength;
        private static int v_Health;
        private static int v_BasicUnit_Count;
        private static int v_RangeUnit_Count;
        private static int v_MagicUnit_Count;
        private static int v_GunUnit_Count;
        private static int v_GiantUnit_Count;
        private static int v_Level;

        private static bool v_Paused;
        private static bool v_BasicUnitUnlocked;
        private static bool v_RangeUnitUnlocked;
        private static bool v_MagicUnitUnlocked;
        private static bool v_GunUnitUnlocked;
        private static bool v_GiantUnitUnlocked;
        private static bool v_AdminMode;
        private static bool v_AdminSnap;
        private static bool v_CloseAdmin;
        private static bool v_AdminAccount;
        private static bool v_SlotChange;

        private static string v_ChildOpen;
        private static string v_ChildToOpen;
        private static string v_SnappedAdminWindowOpen;
        private static string[] v_SlotContents = new string[5];

        private static Image[] v_Basic_Ducks = new Image[3];
        private static Image[] v_Range_Ducks = new Image[3];
        private static Image[] v_Magic_Ducks = new Image[3];
        private static Image[] v_Gun_Ducks = new Image[3];
        private static Image[] v_Giant_Ducks = new Image[3];
        private static Image[] v_Basic_Ducks_FR = new Image[3];
        private static Image[] v_Range_Ducks_FR = new Image[3];
        private static Image[] v_Magic_Ducks_FR = new Image[3];
        private static Image[] v_Gun_Ducks_FR = new Image[3];
        private static Image[] v_Giant_Ducks_FR = new Image[3];
        private static Image[] v_Enemy_Lemons = new Image[4];
        private static Image[] v_BossPics = new Image[4];

        private static List<Get_Unit_Info> v_Unit_Info = new List<Get_Unit_Info>();
        private static List<Get_EUnit_Info> v_EUnit_Info = new List<Get_EUnit_Info>();
        private static List<Unit> v_Units = new List<Unit>();
        private static List<Enemy_Unit> v_Enemy_Units = new List<Enemy_Unit>();
        private static List<Get_Level_Info> v_Level_Info = new List<Get_Level_Info>();
        private static List<Explosion> v_Explosion = new List<Explosion>();

        private static Graphics v_ExplosionGraphics;

        public static int UnitUpgrades_Basic
        {
            get { return v_UnitUpgrades_Basic; }
            set { v_UnitUpgrades_Basic = value; }
        }
        public static int UnitUpgrades_Range
        {
            get { return v_UnitUpgrades_Range; }
            set { v_UnitUpgrades_Range = value; }
        }
        public static int UnitUpgrades_Magic
        {
            get { return v_UnitUpgrades_Magic; }
            set { v_UnitUpgrades_Magic = value; }
        }
        public static int UnitUpgrades_Gun
        {
            get { return v_UnitUpgrades_Gun; }
            set { v_UnitUpgrades_Gun = value; }
        }
        public static int UnitUpgrades_Giant
        {
            get { return v_UnitUpgrades_Giant; }
            set { v_UnitUpgrades_Giant = value; }
        }
        public static int PauseCoverX
        {
            get { return v_PauseCoverX; }
            set { v_PauseCoverX = value; }
        }
        public static int PauseCoverY
        {
            get { return v_PauseCoverY; }
            set { v_PauseCoverY = value; }
        }
        public static int PauseCoverWidth
        {
            get { return v_PauseCoverWidth; }
            set { v_PauseCoverWidth = value; }
        }
        public static int PauseCoverHeight
        {
            get { return v_PauseCoverHeight; }
            set { v_PauseCoverHeight = value; }
        }
        public static int Coins
        {
            get { return v_Coins; }
            set { v_Coins = value; }
        }
        public static int Strength
        {
            get { return v_Strength; }
            set { v_Strength = value; }
        }
        public static int Health
        {
            get { return v_Health; }
            set { v_Health = value; }
        }
        public static int BasicUnit_Count
        {
            get { return v_BasicUnit_Count; }
            set { v_BasicUnit_Count = value; }
        }
        public static int RangeUnit_Count
        {
            get { return v_RangeUnit_Count; }
            set { v_RangeUnit_Count = value; }
        }
        public static int MagicUnit_Count
        {
            get { return v_MagicUnit_Count; }
            set { v_MagicUnit_Count = value; }
        }
        public static int GunUnit_Count
        {
            get { return v_GunUnit_Count; }
            set { v_GunUnit_Count = value; }
        }
        public static int GiantUnit_Count
        {
            get { return v_GiantUnit_Count; }
            set { v_GiantUnit_Count = value; }
        }
        public static int Level
        {
            get { return v_Level; }
            set { v_Level = value; }
        }

        public static bool Paused
        {
            get { return v_Paused; }
            set { v_Paused = value; }
        }
        public static bool BasicUnitUnlocked
        {
            get { return v_BasicUnitUnlocked; }
            set { v_BasicUnitUnlocked = value; }
        }
        public static bool RangeUnitUnlocked
        {
            get { return v_RangeUnitUnlocked; }
            set { v_RangeUnitUnlocked = value; }
        }
        public static bool MagicUnitUnlocked
        {
            get { return v_MagicUnitUnlocked; }
            set { v_MagicUnitUnlocked = value; }
        }
        public static bool GunUnitUnlocked
        {
            get { return v_GunUnitUnlocked; }
            set { v_GunUnitUnlocked = value; }
        }
        public static bool GiantUnitUnlocked
        {
            get { return v_GiantUnitUnlocked; }
            set { v_GiantUnitUnlocked = value; }
        }
        public static bool AdminMode
        {
            get { return v_AdminMode; }
            set { v_AdminMode = value; }
        }
        public static bool AdminSnap
        {
            get { return v_AdminSnap; }
            set { v_AdminSnap = value; }
        }
        public static bool CloseAdmin
        {
            get { return v_CloseAdmin; }
            set { v_CloseAdmin = value; }
        }
        public static bool AdminAccount
        {
            get { return v_AdminAccount; }
            set { v_AdminAccount = value; }
        }
        public static bool SlotChange
        {
            get { return v_SlotChange; }
            set { v_SlotChange = value; }
        }

        public static string ChildOpen
        {
            get { return v_ChildOpen; }
            set { v_ChildOpen = value; }
        }
        public static string ChildToOpen
        {
            get { return v_ChildToOpen; }
            set { v_ChildToOpen = value; }
        }
        public static string SnappedAdminWindowOpen
        {
            get { return v_SnappedAdminWindowOpen; }
            set { v_SnappedAdminWindowOpen = value; }
        }
        public static string[] SlotContents
        {
            get { return v_SlotContents; }
            set { v_SlotContents = value; }
        }

        public static Image[] Basic_Ducks
        {
            get { return v_Basic_Ducks; }
            set { v_Basic_Ducks = value; }
        }
        public static Image[] Range_Ducks
        {
            get { return v_Range_Ducks; }
            set { v_Range_Ducks = value; }
        }
        public static Image[] Magic_Ducks
        {
            get { return v_Magic_Ducks; }
            set { v_Magic_Ducks = value; }
        }
        public static Image[] Gun_Ducks
        {
            get { return v_Gun_Ducks; }
            set { v_Gun_Ducks = value; }
        }
        public static Image[] Giant_Ducks
        {
            get { return v_Giant_Ducks; }
            set { v_Giant_Ducks = value; }
        }
        public static Image[] Basic_Ducks_FR
        {
            get { return v_Basic_Ducks_FR; }
            set { v_Basic_Ducks_FR = value; }
        }
        public static Image[] Range_Ducks_FR
        {
            get { return v_Range_Ducks_FR; }
            set { v_Range_Ducks_FR = value; }
        }
        public static Image[] Magic_Ducks_FR
        {
            get { return v_Magic_Ducks_FR; }
            set { v_Magic_Ducks_FR = value; }
        }
        public static Image[] Gun_Ducks_FR
        {
            get { return v_Gun_Ducks_FR; }
            set { v_Gun_Ducks_FR = value; }
        }
        public static Image[] Giant_Ducks_FR
        {
            get { return v_Giant_Ducks_FR; }
            set { v_Giant_Ducks_FR = value; }
        }
        public static Image[] Enemy_Lemons
        {
            get { return v_Enemy_Lemons; }
            set { v_Enemy_Lemons = value; }
        }
        public static Image[] BossPics
        {
            get { return v_BossPics; }
            set { v_BossPics = value; }
        }

        public static List<Get_Unit_Info> Unit_Info
        {
            get { return v_Unit_Info; }
            set { v_Unit_Info = value; }
        }
        public static List<Get_EUnit_Info> EUnit_Info
        {
            get { return v_EUnit_Info; }
            set { v_EUnit_Info = value; }
        }
        public static List<Unit> Units
        {
            get { return v_Units; }
            set { v_Units = value; }
        }
        public static List<Enemy_Unit> Enemy_Units
        {
            get { return v_Enemy_Units; }
            set { v_Enemy_Units = value; }
        }
        public static List<Get_Level_Info> Level_Info
        {
            get { return v_Level_Info; }
            set { v_Level_Info = value; }
        }
        public static List<Explosion> Explosions
        {
            get { return v_Explosion; }
            set { v_Explosion = value; }
        }

        public static Graphics ExplosionGraphics
        {
            get { return v_ExplosionGraphics; }
            set { v_ExplosionGraphics = value; }
        }
    }
}
