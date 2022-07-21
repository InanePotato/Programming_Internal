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

        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            if (File.Exists(filepath))
            {                
                new Game().Show();
                this.Close();
            }
            else
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
                Origonal_Unit_Info.Add(new Get_Unit_Info("gunner", 5, 15, 1, "yes", "5%bleed 10%decrease_accuracy none", 30));
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

                new Game().Show();
                this.Close();
            }
        }
    }
}
