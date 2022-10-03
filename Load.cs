using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programming_Internal
{
    public partial class Load : Form
    {
        string filepath = Application.StartupPath + @"\Application_Resources\Unit_Settings.txt";
        List<Get_Unit_Info> Origonal_Unit_Info = new List<Get_Unit_Info>();

        string filepath2 = Application.StartupPath + @"\Application_Resources\EUnit_Settings.txt";
        List<Get_EUnit_Info> Origonal_EUnit_Info = new List<Get_EUnit_Info>();

        string filepath3 = Application.StartupPath + @"\Application_Resources\Level_Settings.txt";
        List<Get_Level_Info> Origonal_Level_Info = new List<Get_Level_Info>();

        string LoadText_Prefix = "Loading";
        string LoadText_Suffix = ".";
        int WaitTick = 5;

        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filepath))
            {
                Origonal_Unit_Info.Clear();

                Origonal_Unit_Info.Add(new Get_Unit_Info("spear", 5, 15, 10, "no", "none none none", 10));
                Origonal_Unit_Info.Add(new Get_Unit_Info("sword", 10, 20, 10, "no", "none none none", 15));
                Origonal_Unit_Info.Add(new Get_Unit_Info("axe", 20, 22, 10, "no", "none none none", 20));
                Origonal_Unit_Info.Add(new Get_Unit_Info("archer", 4, 10, 10, "yes", "none none none", 15));
                Origonal_Unit_Info.Add(new Get_Unit_Info("catapult", 10, 12, 12, "yes", "100%group_damage none none", 20));
                Origonal_Unit_Info.Add(new Get_Unit_Info("cannon", 20, 15, 11, "yes", "100%group_damage 2%decreased_evade none", 25));
                Origonal_Unit_Info.Add(new Get_Unit_Info("magician", 11, 20, 10, "no", "2%stun none none", 25));
                Origonal_Unit_Info.Add(new Get_Unit_Info("wizard", 12, 30, 11, "yes", "2%stun 5%fire none", 30));
                Origonal_Unit_Info.Add(new Get_Unit_Info("sorcerer", 15, 30, 11, "yes", "5%stun 10%fire 1%backfire", 35));
                Origonal_Unit_Info.Add(new Get_Unit_Info("agent", 10, 10, 11, "yes", "5%increase_evade none none", 25));
                Origonal_Unit_Info.Add(new Get_Unit_Info("gunner", 5, 15, 5, "yes", "5%bleed 10%decrease_accuracy none", 30));
                Origonal_Unit_Info.Add(new Get_Unit_Info("sniper", 50, 30, 13, "yes", "10%instant_kill 2%bleed none", 40));
                Origonal_Unit_Info.Add(new Get_Unit_Info("stacked", 25, 50, 12, "no", "100%split none none", 30));
                Origonal_Unit_Info.Add(new Get_Unit_Info("tall", 30, 80, 14, "no", "2%increase_evade none none", 40));
                Origonal_Unit_Info.Add(new Get_Unit_Info("buff", 30, 100, 15, "no", "10%risistance none none", 50));

                if (!File.Exists(Application.StartupPath + @"\Application_Resources"))
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Application_Resources");
                }

                StringBuilder builder = new StringBuilder();
                foreach (Get_Unit_Info i in Origonal_Unit_Info)
                {
                    //{0} is for the Name, {1} is for the Score and {2} is for a new line
                    builder.Append(string.Format("{0},{1},{2},{3},{4},{5},{6}{7}", i.Name, i.Damage, i.Health, i.Attack_Speed, i.Range, i.Abilities, i.Cost, Environment.NewLine));
                }
                File.WriteAllText(filepath, builder.ToString());
            }

            if (!File.Exists(filepath2))
            {
                Origonal_EUnit_Info.Clear();

                Origonal_EUnit_Info.Add(new Get_EUnit_Info("small", 10, 15, 10, "no"));
                Origonal_EUnit_Info.Add(new Get_EUnit_Info("big", 15, 20, 11, "no"));
                Origonal_EUnit_Info.Add(new Get_EUnit_Info("glass", 25, 30, 13, "no"));
                Origonal_EUnit_Info.Add(new Get_EUnit_Info("bottle", 30, 40, 13, "yes"));
                Origonal_EUnit_Info.Add(new Get_EUnit_Info("boss1", 15, 60, 14, "no"));
                Origonal_EUnit_Info.Add(new Get_EUnit_Info("boss2", 25, 90, 14, "no"));
                Origonal_EUnit_Info.Add(new Get_EUnit_Info("boss3", 30, 120, 14, "no"));
                Origonal_EUnit_Info.Add(new Get_EUnit_Info("finalboss", 35, 150, 15, "yes"));


                if (!File.Exists(Application.StartupPath + @"\Application_Resources"))
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Application_Resources");
                }

                StringBuilder builder2 = new StringBuilder();
                foreach (Get_EUnit_Info i in Origonal_EUnit_Info)
                {
                    //{0} is for the Name, {1} is for the Score and {2} is for a new line
                    builder2.Append(string.Format("{0},{1},{2},{3},{4}{5}", i.Name, i.Damage, i.Health, i.Attack_Speed, i.Range, Environment.NewLine));
                }
                File.WriteAllText(filepath2, builder2.ToString());
            }

            if (!File.Exists(filepath3))
            {
                Origonal_Level_Info.Clear();

                Origonal_Level_Info.Add(new Get_Level_Info(1, "yes", "2-5", "no", "0-0", "no", "0-0", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(2, "yes", "5-10", "no", "0-0", "no", "0-0", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(3, "yes", "10-15", "yes", "1-2", "no", "0-0", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(4, "yes", "10-15", "yes", "2-5", "no", "0-0", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(5, "yes", "10-15", "yes", "5-10", "no", "0-0", "no", "0-0", "boss1"));
                Origonal_Level_Info.Add(new Get_Level_Info(6, "yes", "15-20", "yes", "10-15", "no", "0-0", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(7, "yes", "20-25", "yes", "10-15", "yes", "2-5", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(8, "yes", "20-25", "yes", "12-18", "yes", "5-10", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(9, "yes", "20-25", "yes", "15-20", "yes", "8-12", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(10, "yes", "30-35", "yes", "20-25", "yes", "10-15", "no", "0-0", "boss2"));
                Origonal_Level_Info.Add(new Get_Level_Info(11, "yes", "30-35", "yes", "20-25", "yes", "15-20", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(12, "yes", "40-45", "yes", "28-32", "yes", "22-25", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(13, "yes", "42-46", "yes", "30-35", "yes", "25-28", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(14, "yes", "45-50", "yes", "32-38", "yes", "28-30", "no", "0-0", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(15, "yes", "50-55", "yes", "36-42", "yes", "30-35", "yes", "2-5", "boss3"));
                Origonal_Level_Info.Add(new Get_Level_Info(16, "yes", "52-60", "yes", "40-45", "yes", "32-38", "yes", "5-10", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(17, "yes", "54-62", "yes", "42-48", "yes", "35-38", "yes", "10-15", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(18, "yes", "56-64", "yes", "45-50", "yes", "35-40", "yes", "12-20", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(19, "yes", "58-65", "yes", "48-52", "yes", "38-45", "yes", "15-22", "none"));
                Origonal_Level_Info.Add(new Get_Level_Info(20, "yes", "60-70", "yes", "55-65", "yes", "48-58", "yes", "25-30", "finalboss"));


                if (!File.Exists(Application.StartupPath + @"\Application_Resources"))
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Application_Resources");
                }

                StringBuilder builder3 = new StringBuilder();
                foreach (Get_Level_Info i in Origonal_Level_Info)
                {
                    //{0} is for the Name, {1} is for the Score and {2} is for a new line
                    builder3.Append(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}{10}", i.Level, i.AllowSmall, i.SmallRange, i.AllowBig, i.BigRange, i.AllowGlass, i.GlassRange, i.AllowBottle, i.BottleRange, i.Boss, Environment.NewLine));
                }
                File.WriteAllText(filepath3, builder3.ToString());
            }
        }
        private void TMR_LoadProgress_Tick(object sender, EventArgs e)
        {
            if (PB_LoadProgress.Value < 120)
            {
                if (PB_LoadProgress.Value < 15) { LoadText_Prefix = "preparing application resources"; }
                else if (PB_LoadProgress.Value < 30) { LoadText_Prefix = "loading Unit_Settings.text"; }
                else if (PB_LoadProgress.Value < 45) { LoadText_Prefix = "loading EUnit_Settings.text"; }
                else if (PB_LoadProgress.Value < 60) { LoadText_Prefix = "loading Level_Settings.text"; }
                else if (PB_LoadProgress.Value < 75) { LoadText_Prefix = "reading Saves.text"; }
                else if (PB_LoadProgress.Value < 90) { LoadText_Prefix = "loading game saves"; }
                else if (PB_LoadProgress.Value < 105) { LoadText_Prefix = "praparing game for launch"; }
                else { LoadText_Prefix = "launching game"; }

                LBL_LoadingText.Text = LoadText_Prefix + LoadText_Suffix;

                //PB_LoadProgress.Value++;
                PB_LoadProgress.PerformStep();
            }
            else
            {
                if (WaitTick == 0)
                {
                    GlobalVariables.frmHome = new Home();
                    GlobalVariables.frmHome.Show();
                    this.Close();
                }
                else
                {
                    WaitTick--;
                }
            }


        }

        private void TMR_EditLoadTextSuffix_Tick(object sender, EventArgs e)
        {
            if (LoadText_Suffix == "") { LoadText_Suffix = "."; }
            else if (LoadText_Suffix == ".") { LoadText_Suffix = ".."; }
            else if (LoadText_Suffix == "..") { LoadText_Suffix = "..."; }
            else if (LoadText_Suffix == "...") { LoadText_Suffix = ""; }

            LBL_LoadingText.Text = LoadText_Prefix + LoadText_Suffix;
        }
    }
}
