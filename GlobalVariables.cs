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

        private static bool v_Paused;

        private static string v_ChildOpen;
        private static string v_ChildToOpen;
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

        public static bool Paused
        {
            get { return v_Paused; }
            set { v_Paused = value; }
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
    }
}
