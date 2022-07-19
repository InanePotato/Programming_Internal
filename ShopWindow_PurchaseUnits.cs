using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class ShopWindow_PurchaseUnits : Form
    {
        public ShopWindow_PurchaseUnits()
        {
            InitializeComponent();
        }

        private void ShopWindow_PurchaseUnits_Load(object sender, EventArgs e)
        {
            string BasicUnit_Name;

            if (GlobalVariables.UnitUpgrades_Basic == 2) { BasicUnit_Name = "axe"; }
            else if (GlobalVariables.UnitUpgrades_Basic == 1) { BasicUnit_Name = "sword"; }
            else { BasicUnit_Name = "spear"; }

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == BasicUnit_Name)
                {
                    lbl_BasicUnit_Health.Text = i.Health.ToString();
                    lbl_BasicUnit_Damage.Text = i.Damage.ToString();
                    lbl_BasicUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_BasicUnit_Range.Text = i.Range;
                }
            }
        }
    }
}
